using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;

namespace BTMOB;

[StandardModule]
internal sealed class NotesManager
{
	private static void EnsureDirectoryExists()
	{
		if (!Directory.Exists(MyRes.NotesDirectory))
		{
			Directory.CreateDirectory(MyRes.NotesDirectory);
		}
	}

	private static string GetFilePath(string id)
	{
		return Path.Combine(MyRes.NotesDirectory, string.Format(EXGuarder._542A2356, id));
	}

	public static void SaveNote(string id, string noteText)
	{
		EnsureDirectoryExists();
		string filePath = GetFilePath(id);
		List<string> list = LoadNotes(id);
		list.Add(noteText);
		string text = JsonConvert.SerializeObject(list, Formatting.Indented);
		File.WriteAllText(filePath, MyCrypter.Encrypt(text, EXGuarder._75674F07));
	}

	public static List<string> LoadNotes(string id)
	{
		EnsureDirectoryExists();
		string filePath = GetFilePath(id);
		if (!File.Exists(filePath))
		{
			return new List<string>();
		}
		string text = File.ReadAllText(filePath);
		List<string> list = JsonConvert.DeserializeObject<List<string>>(MyCrypter.Decrypt(text, EXGuarder._1B71685A));
		return (list != null) ? list : new List<string>();
	}

	public static void RemoteNote(string id, string noteText)
	{
		EnsureDirectoryExists();
		string filePath = GetFilePath(id);
		if (File.Exists(filePath))
		{
			List<string> list = LoadNotes(id);
			list.Remove(noteText);
			if (list.Count == 0)
			{
				File.Delete(filePath);
				return;
			}
			string text = JsonConvert.SerializeObject(list, Formatting.Indented);
			File.WriteAllText(filePath, MyCrypter.Encrypt(text, EXGuarder._31511751));
		}
	}

	public static void RemoteAll(string id)
	{
		EnsureDirectoryExists();
		string filePath = GetFilePath(id);
		if (File.Exists(filePath))
		{
			File.Delete(filePath);
		}
	}
}
