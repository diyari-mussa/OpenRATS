using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace BTMOB;

public class KeystoreEncoder
{
	private const string DELIMITER = "|";

	public static string EncodeKeystoreData(string aliasName, string password, string cn, string ou, string o, string l, string s, string c)
	{
		if (codes.StrisEmpty(aliasName))
		{
			aliasName = EXGuarder._483C616A;
		}
		if (codes.StrisEmpty(password))
		{
			password = EXGuarder._483C616A;
		}
		if (codes.StrisEmpty(cn))
		{
			cn = EXGuarder._483C616A;
		}
		if (codes.StrisEmpty(ou))
		{
			ou = EXGuarder._483C616A;
		}
		if (codes.StrisEmpty(o))
		{
			o = EXGuarder._483C616A;
		}
		if (codes.StrisEmpty(l))
		{
			l = EXGuarder._483C616A;
		}
		if (codes.StrisEmpty(s))
		{
			s = EXGuarder._483C616A;
		}
		if (codes.StrisEmpty(c))
		{
			c = EXGuarder._483C616A;
		}
		string s2 = aliasName + EXGuarder._213A0B57 + password + EXGuarder._213A0B57 + cn + EXGuarder._213A0B57 + ou + EXGuarder._213A0B57 + o + EXGuarder._213A0B57 + l + EXGuarder._213A0B57 + s + EXGuarder._213A0B57 + c;
		byte[] bytes = Encoding.UTF8.GetBytes(s2);
		return Convert.ToBase64String(bytes);
	}

	public static string[] DecodeKeystoreData(string base64)
	{
		string[] result;
		try
		{
			byte[] bytes = Convert.FromBase64String(base64);
			string text = Encoding.UTF8.GetString(bytes);
			result = text.Split('|');
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			BTAlerter.infos(EXGuarder._49790535);
			result = null;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
