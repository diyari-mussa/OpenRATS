using System.Collections.Generic;
using Craxs_Rat.sockets;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat;

[StandardModule]
internal sealed class infoServer
{
	public static string PORTS = string.Empty;

	public static int KeySize = 8;

	public static int Microseconds = -1;

	public static List<Client> WorkerRemove = new List<Client>();
}
