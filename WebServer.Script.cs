//--------------------------------------------------------------
// Press F1 to get help about using script.
// To access an object that is not located in the current class, start the call with Globals.
// When using events and timers be cautious not to generate memoryleaks,
// please see the help for more information.
//---------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
	using System.Net;
	using System.Net.Sockets;
	using System.Threading;
	using System.IO;
	using System.Text;
	using System.Collections.Generic;
	
    public partial class WebServer
    {

		public String err_message="";
		
		void WebServer_Created(System.Object sender, System.EventArgs e)
		{
			Server server=new Server(8000);
			server.begin();
		}

		public static String getJson(){
			String json="{\"tanks\":[";
			
			List<Tank> tankList=Globals.Rezonans.getTanks();
			
			for(int k=0;k<tankList.Count;k++){
				Tank tank=tankList[k];
				if(k == tankList.Count-1){
					json+=tank.toJSON()+"\r\n";
				}else{
					json+=tank.toJSON()+",\r\n";
				}
			}
			
			json+="]}";
		  
			return json;
		}
		
 
    }
	
	
	public class Server
	{
		public static Server server = null;
		int port;
		TcpClient tcpClient;


		public Server(int port)
		{
			this.port = port;
		}

		public void handleClient(TcpClient tcpClient)
		{
			Stream stream = tcpClient.GetStream();
			StreamReader reader = new StreamReader(stream);
			String text = "";
			String data = "";
			while ((text = reader.ReadLine()) != null)
			{
				data += text + "\r\n";
				if (text == "") break;
			}
			Console.WriteLine(data);
			StreamWriter writer = new StreamWriter(stream);
			writer.WriteLine("HTTP/1.1 200 OK");
			writer.WriteLine("Content-Type:application/json\r\n");
			writer.WriteLine(WebServer.getJson());
			writer.Flush();
			writer.Close();
		}

		public void begin()
		{
			Thread thread = new Thread(new ThreadStart(startServer));
			  thread.IsBackground = true;
			thread.Start();
		}

		public void startServer()
		{
			TcpListener tcpListener = null;
			try
			{
				tcpListener = new TcpListener(IPAddress.Any, port);
				tcpListener.Start();
				Console.WriteLine("Waiting for a connection...");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error2: " + e.ToString());
			}

			while (true)
			{
				try
				{
					Thread.Sleep(10);
					Console.WriteLine("Waiting for client.");
					tcpClient = tcpListener.AcceptTcpClient();
					Console.WriteLine("Client Connected.");
					handleClient(tcpClient);
					tcpClient.Close();
					Console.WriteLine("Client Bağlantısı Kesildi.");
				}
				catch (Exception e)
				{
					Console.WriteLine("Error3: " + e.ToString());
				}
			}
		}
		

	}
}
