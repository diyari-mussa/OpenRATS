using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace BTMOB;

[StandardModule]
internal sealed class ServersMgr
{
	private const string BLOCKED_FIELD = "Blocked";

	private const string BLOCK_ENTRY_SEPARATOR = "[B]";

	private const char BLOCK_PAIR_SEPARATOR = ':';

	private const string Root = BTConst.RegistryPath;

	private static string KeyPath(string ipAddress)
	{
		return Root + "\\" + (ipAddress ?? "").Replace("\\", "_").Replace("/", "_");
	}

	private static void SaveServerData(string ipAddress, string fieldName, string value)
	{
		using (RegistryKey key = Registry.CurrentUser.CreateSubKey(KeyPath(ipAddress)))
			key.SetValue(fieldName, value ?? "");
	}

	private static string GetServerData(string ipAddress, string fieldName)
	{
		using (RegistryKey key = Registry.CurrentUser.OpenSubKey(KeyPath(ipAddress)))
			return key?.GetValue(fieldName) as string;
	}

	public static void SaveServerPin(string ipAddress, string pinKey)
	{
		SaveServerData(ipAddress, "pin", pinKey);
	}

	public static string GetServerPin(string ipAddress)
	{
		return GetServerData(ipAddress, "pin");
	}

	public static void SaveServerNextKey(string ipAddress, string nextKey)
	{
		SaveServerData(ipAddress, "nextkey", nextKey);
	}

	public static string GetServerNextKey(string ipAddress)
	{
		return GetServerData(ipAddress, "nextkey");
	}

	public static void SaveServerIDF(string ipAddress, string idf)
	{
		SaveServerData(ipAddress, "idf", idf);
	}

	public static string GetServerIDF(string ipAddress)
	{
		return GetServerData(ipAddress, "idf");
	}

	public static void DeleteServer(string ipAddress)
	{
		using (RegistryKey root = Registry.CurrentUser.OpenSubKey(Root, writable: true))
			root?.DeleteSubKeyTree((ipAddress ?? "").Replace("\\", "_").Replace("/", "_"), throwOnMissingSubKey: false);
	}

	public static Dictionary<string, string> GetServerBlockedMap(string serverIpAddress)
	{
		return DeserializeBlocked(GetServerData(serverIpAddress, BLOCKED_FIELD));
	}

	public static void SaveServerBlockedMap(string serverIpAddress, Dictionary<string, string> blocked)
	{
		SaveServerData(serverIpAddress, BLOCKED_FIELD, SerializeBlocked(blocked));
	}

	public static void AddServerBlockedClient(string serverIpAddress, string clientIp, string mobid)
	{
		Dictionary<string, string> map = GetServerBlockedMap(serverIpAddress);
		map[clientIp] = mobid;
		SaveServerBlockedMap(serverIpAddress, map);
	}

	public static void RemoveServerBlockedClient(string serverIpAddress, string clientIp)
	{
		Dictionary<string, string> map = GetServerBlockedMap(serverIpAddress);
		map.Remove(clientIp);
		SaveServerBlockedMap(serverIpAddress, map);
	}

	public static Dictionary<string, string> GetServerBlockedClients(string serverIpAddress)
	{
		return GetServerBlockedMap(serverIpAddress);
	}

	private static Dictionary<string, string> DeserializeBlocked(string raw)
	{
		Dictionary<string, string> map = new Dictionary<string, string>();
		if (string.IsNullOrEmpty(raw))
			return map;
		string[] entries = raw.Split(new string[1] { BLOCK_ENTRY_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string entry in entries)
		{
			int at = entry.IndexOf(BLOCK_PAIR_SEPARATOR);
			if (at <= 0)
				continue;
			map[entry.Substring(0, at)] = entry.Substring(at + 1);
		}
		return map;
	}

	private static string SerializeBlocked(Dictionary<string, string> dict)
	{
		if (dict == null || dict.Count == 0)
			return "";
		List<string> parts = new List<string>();
		foreach (KeyValuePair<string, string> pair in dict)
			parts.Add(pair.Key + BLOCK_PAIR_SEPARATOR + pair.Value);
		return string.Join(BLOCK_ENTRY_SEPARATOR, parts);
	}

	public static Dictionary<string, Dictionary<string, string>> GetAllServers()
	{
		Dictionary<string, Dictionary<string, string>> all = new Dictionary<string, Dictionary<string, string>>();
		using (RegistryKey root = Registry.CurrentUser.OpenSubKey(Root))
		{
			if (root == null)
				return all;
			foreach (string name in root.GetSubKeyNames())
			{
				using (RegistryKey child = root.OpenSubKey(name))
				{
					if (child == null)
						continue;
					Dictionary<string, string> fields = new Dictionary<string, string>();
					foreach (string valueName in child.GetValueNames())
						fields[valueName] = Convert.ToString(child.GetValue(valueName));
					all[name] = fields;
				}
			}
		}
		return all;
	}
}
