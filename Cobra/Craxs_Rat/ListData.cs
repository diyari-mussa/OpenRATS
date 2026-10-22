using System.Net.Sockets;
using System.Threading;
using Craxs_Rat.sockets;

namespace Craxs_Rat;

public sealed class ListData
{
	public bool wait;

	public ManualResetEvent WaitDataHandler;

	public byte[] bByte;

	public Client ClassClient;

	public object[] SizeData;

	public TcpClient TcpClient;

	public ListData(Client ParametersClient, byte[] ParametersByte, object[] ParametersObject, TcpClient ParametersTcpClient)
	{
		WaitDataHandler = new ManualResetEvent(initialState: false);
		wait = false;
		ClassClient = ParametersClient;
		bByte = ParametersByte;
		SizeData = ParametersObject;
		TcpClient = ParametersTcpClient;
	}
}
