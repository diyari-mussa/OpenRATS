using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using SuperSocket.ClientEngine;
using WebSocket4Net;

namespace BTMOB;

public class WebSocketClient
{
	private WebSocket websocket;

	private Thread reconnectThread;

	private ServersInfo Serverinfos;

	private int _connecting;

	private int _manualDisconnect;

	private int _reconnectDelayMs;

	private string My_IDF;

	public readonly object LockSend;

	private TaskCompletionSource<bool> connectTcs;

	private BlockingCollection<string> _messageQueue;

	private int _started;

	private int _disconnecting;

	private int _connected;

	public bool Authorized { get; set; }

	public bool IsConnected { get; set; }

	public string SocketState { get; set; }

	public bool ShouldReconnect { get; set; }

	public WebSocketClient(string Forwhat, string address, ServersInfo srverinf)
	{
		_connecting = 0;
		_manualDisconnect = 0;
		_reconnectDelayMs = 3000;
		My_IDF = EXGuarder._3F1A6A6A;
		ShouldReconnect = true;
		LockSend = RuntimeHelpers.GetObjectValue(new object());
		_started = 0;
		_disconnecting = 0;
		_connected = 0;
		Serverinfos = srverinf;
		SocketState = EXGuarder._6F16764B;
		BTEngine.SocketsCount = Operators.AddObject(BTEngine.SocketsCount, 1);
		BTEngine.MainForm.LogConnection(BTConst.nesocketstr, codes.connectionicon(EXGuarder._25097777), address, Forwhat, srverinf);
	}

	public void Connect(string uidf)
	{
		My_IDF = uidf;
		TryConnect();
	}

	private void TryConnect()
	{
		if (Volatile.Read(ref _manualDisconnect) == 1 || Interlocked.Exchange(ref _connecting, 1) == 1)
		{
			return;
		}
		try
		{
			InitializeWebSocket();
		}
		finally
		{
			Interlocked.Exchange(ref _connecting, 0);
		}
	}

	public async Task ConnectAsync(string uidf)
	{
		connectTcs = new TaskCompletionSource<bool>();
		My_IDF = uidf;
		InitializeWebSocket();
		Task task = Task.Delay(30000);
		if (await Task.WhenAny(connectTcs.Task, task) == task)
		{
			connectTcs.TrySetException(new TimeoutException("WebSocket connection timed out"));
		}
		await connectTcs.Task;
	}

	public void InitializeWebSocket()
	{
		if (websocket != null)
		{
			websocket.Opened -= OnOpen;
			websocket.Closed -= OnClose;
			websocket.Error -= OnError;
			websocket.MessageReceived -= OnMessageReceived;
		}
		websocket = new WebSocket(Conversions.ToString(BTConst.getApiUrl(BTConst.socketapi, Serverinfos.Address)), EXGuarder._6C745357, null, null, EXGuarder._6C745357, EXGuarder._6C745357);
		websocket.Opened += OnOpen;
		websocket.Closed += OnClose;
		websocket.Error += OnError;
		websocket.MessageReceived += OnMessageReceived;
		SocketState = EXGuarder._2B5D615D;
		try
		{
			websocket.Open();
		}
		catch (InvalidOperationException ex)
		{
			ProjectData.SetProjectError(ex);
			InvalidOperationException ex2 = ex;
			Console.WriteLine(EXGuarder._711B655F);
			Debuger.Log_e(EXGuarder._366D6272, codes.EXtoString(ex2));
			ProjectData.ClearProjectError();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Console.WriteLine(EXGuarder._0D073E32 + ex4.Message);
			Debuger.Log_e(EXGuarder._704B380B, codes.EXtoString(ex4));
			ProjectData.ClearProjectError();
		}
	}

	public void joinserver()
	{
		string message = JsonConvert.SerializeObject(new VB_0024AnonymousType_8<string, string, string>(EXGuarder._221F4B0E, EXGuarder._3471631E, My_IDF));
		SendMessage(message);
	}

	public void OutServer()
	{
		string message = JsonConvert.SerializeObject(new VB_0024AnonymousType_8<string, string, string>(EXGuarder._743B6639, EXGuarder._20214B04, My_IDF));
		SendMessage(message);
		Thread.Sleep(1);
	}

	private void OnOpen(object sender, EventArgs e)
	{
		IsConnected = true;
		SocketState = EXGuarder._31656D2D;
		ShouldReconnect = true;
		PrepareMessageQueue();
		StartMessageWorkers();
		connectTcs?.TrySetResult(result: true);
		joinserver();
	}

	private void OnClose(object sender, EventArgs e)
	{
		IsConnected = false;
		SocketState = EXGuarder._0C4A4664;
		Volatile.Write(ref _connected, 0);
		try
		{
			_messageQueue?.CompleteAdding();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		connectTcs?.TrySetCanceled();
		if (Volatile.Read(ref _manualDisconnect) == 0 && ShouldReconnect)
		{
			ScheduleReconnect();
		}
	}

	private void OnError(object sender, ErrorEventArgs e)
	{
		IsConnected = false;
		SocketState = EXGuarder._0B296524;
		Volatile.Write(ref _connected, 0);
		connectTcs?.TrySetException(e.Exception);
		if (Volatile.Read(ref _manualDisconnect) == 0 && ShouldReconnect)
		{
			ScheduleReconnect();
		}
	}

	private void ScheduleReconnect()
	{
		if (Interlocked.Exchange(ref _connecting, 1) == 1)
		{
			return;
		}
		Task.Run([SpecialName] async () =>
		{
			try
			{
				await Task.Delay(_reconnectDelayMs);
				if (Volatile.Read(ref _manualDisconnect) != 1 && !IsConnected)
				{
					InitializeWebSocket();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Exception ex3 = ex2;
				Debuger.Log_e("ScheduleReconnect", ex3.Message);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Interlocked.Exchange(ref _connecting, 0);
			}
		});
	}

	public void SendComCommand(Dictionary<string, object> chatData, string mobpid, bool issecure)
	{
		object obj = chatData;
		if (issecure)
		{
			string plainText = JsonConvert.SerializeObject(chatData);
			byte[] sharedSecret = BTEngine.SecureClients[mobpid].SharedSecret;
			obj = RuntimeHelpers.GetObjectValue(JsonConvert.DeserializeObject(KeyGenerator.EncryptAndSign(plainText, sharedSecret)));
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary.Add(EXGuarder._03033C28, EXGuarder._70363304);
		dictionary.Add(EXGuarder._0A3A2056, EXGuarder._26482B41);
		dictionary.Add(EXGuarder._2318393C, My_IDF);
		dictionary.Add(EXGuarder._37410E26, mobpid);
		dictionary.Add(EXGuarder._2B483B6F, issecure);
		dictionary.Add(EXGuarder._6F60454E, RuntimeHelpers.GetObjectValue(obj));
		Dictionary<string, object> value = dictionary;
		string message = JsonConvert.SerializeObject(value);
		SendMessage(message);
	}

	public void Sender(string message)
	{
		checked
		{
			try
			{
				websocket.Send(message);
				Serverinfos.BytesSent += message.Length;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Console.WriteLine(string.Format(EXGuarder._0C1A6A73, codes.EXtoString(ex2)));
				ProjectData.ClearProjectError();
			}
		}
	}

	public void SendMessage(string message)
	{
		if (websocket != null && websocket.State == WebSocketState.Open)
		{
			Thread.Sleep(1);
			Sender(message);
		}
		else
		{
			Console.WriteLine(EXGuarder._513E0A34);
		}
	}

	private void PrepareMessageQueue()
	{
		_messageQueue = new BlockingCollection<string>(new ConcurrentQueue<string>(), 5000);
		Interlocked.Exchange(ref _started, 0);
		Interlocked.Exchange(ref _disconnecting, 0);
		Volatile.Write(ref _connected, 1);
	}

	private void StartMessageWorkers()
	{
		int num = 5;
		object value = BTRegistry.GetValue(EXGuarder._66332702, EXGuarder._391D7073);
		if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._0075736A, TextCompare: false))
		{
			num = 1;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._391D7073, TextCompare: false))
		{
			num = 5;
		}
		else if (Operators.ConditionalCompareObjectEqual(value, EXGuarder._31682661, TextCompare: false))
		{
			num = 10;
		}
		if (Interlocked.Exchange(ref _started, 1) != 1)
		{
			int num2 = num;
			for (int i = 1; i <= num2; i = checked(i + 1))
			{
				Task.Factory.StartNew(MessageWorker, TaskCreationOptions.LongRunning);
			}
		}
	}

	private string GetSystemState()
	{
		int count = _messageQueue.Count;
		object value = BTRegistry.GetValue(EXGuarder._280F3D2F, EXGuarder._781C6613);
		int num = (Operators.ConditionalCompareObjectEqual(value, EXGuarder._51445C19, TextCompare: false) ? 1 : (Operators.ConditionalCompareObjectEqual(value, EXGuarder._781C6613, TextCompare: false) ? 5 : ((!Operators.ConditionalCompareObjectEqual(value, EXGuarder._48675B39, TextCompare: false)) ? 5 : 10)));
		checked
		{
			if (count < num * 5)
			{
				return EXGuarder._1038120F;
			}
			if (count < num * 20)
			{
				return EXGuarder._56644B3D;
			}
			return EXGuarder._2B3E143F;
		}
	}

	private void OnMessageReceived(object sender, MessageReceivedEventArgs e)
	{
		if (Volatile.Read(ref _connected) == 0)
		{
			return;
		}
		BlockingCollection<string> messageQueue = _messageQueue;
		if (messageQueue == null)
		{
			return;
		}
		string message = e.Message;
		try
		{
			if (!messageQueue.TryAdd(message))
			{
				Debuger.Log_d(EXGuarder._543C2460, EXGuarder._67406068);
			}
			ServersInfo serverinfos;
			long location = (serverinfos = Serverinfos).BytesReceived;
			Interlocked.Add(ref location, message.Length);
			serverinfos.BytesReceived = location;
		}
		catch (InvalidOperationException ex)
		{
			ProjectData.SetProjectError(ex);
			InvalidOperationException ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private void MessageWorker()
	{
		BlockingCollection<string> messageQueue = _messageQueue;
		if (messageQueue == null)
		{
			return;
		}
		try
		{
			foreach (string item in messageQueue.GetConsumingEnumerable())
			{
				try
				{
					BTEngine.HandleMessage(item, Serverinfos);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					Debuger.Log_d(EXGuarder._5A514E74, ex2.Message);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (OperationCanceledException ex3)
		{
			ProjectData.SetProjectError(ex3);
			OperationCanceledException ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		catch (ObjectDisposedException ex5)
		{
			ProjectData.SetProjectError(ex5);
			ObjectDisposedException ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Debuger.Log_d(EXGuarder._3168202C, ex8.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void Disconnect(string Forwhat, string address)
	{
		if (Interlocked.Exchange(ref _disconnecting, 1) == 1)
		{
			return;
		}
		Volatile.Write(ref _manualDisconnect, 1);
		Volatile.Write(ref _connected, 0);
		IsConnected = false;
		ShouldReconnect = false;
		SocketState = EXGuarder._1E336101;
		try
		{
			_messageQueue?.CompleteAdding();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (websocket != null)
			{
				websocket.Opened -= OnOpen;
				websocket.Closed -= OnClose;
				websocket.Error -= OnError;
				websocket.MessageReceived -= OnMessageReceived;
				websocket.Close();
				websocket.Dispose();
				websocket = null;
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		BTEngine.MainForm.LogConnection(BTConst.disconnt, codes.connectionicon(EXGuarder._3A6B1148), address, Forwhat, Serverinfos);
		Type typeFromHandle = typeof(Interlocked);
		string _2 = EXGuarder._47411940;
		object[] obj = new object[1] { BTEngine.SocketsCount };
		object[] array = obj;
		bool[] obj2 = new bool[1] { true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(null, typeFromHandle, _2, obj, null, null, obj2, IgnoreReturn: true);
		if (array2[0])
		{
			BTEngine.SocketsCount = RuntimeHelpers.GetObjectValue(array[0]);
		}
	}
}
