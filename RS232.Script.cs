
namespace Neo.ApplicationFramework.Generated
{
	using System.Windows.Forms;
	using System;
	using System.Drawing;
	using Neo.ApplicationFramework.Tools;
	using Neo.ApplicationFramework.Common.Graphics.Logic;
	using Neo.ApplicationFramework.Controls;
	using Neo.ApplicationFramework.Interfaces;
    
	using System.IO.Ports;   
	
	public partial class RS232
	{

		public static SerialCom serialCom = null;
		
		static RS232() 
		{
			Baglan();
		}
		
		public static void onRead(string data)
		{
			try{
				// id,dip,press,temp
				string[] row = data.Split(';');
				String table_no  = (row[0]);
				uint dip=uint.Parse(row[1]);
				float press=float.Parse(row[2]);
				float temp=float.Parse(row[3]);
			
				Globals.Rezonans.onData(table_no,dip,press,temp);
			}catch(Exception ex){
				MessageBox.Show("com error:"+ex.Message);
			}
		}
		
		public static void onConnect(){
			//	Globals.Tags.CONNECTION_PORT_STATUS.Value = 6;
		}
		
		public static void onDisconnect(){
			//	Globals.Tags.CONNECTION_PORT_STATUS.Value = 0;
		}
		
		public static void Baglan()
		{
			if(serialCom == null)
			{
				String comport = "COM1" ; 
				serialCom = new SerialCom(comport,9600);		
			}
		}
		
		public static void BaglantiyiKes()
		{
			if(serialCom != null)
			{
				serialCom.closeConnection();
			}
			serialCom = null;
		}
	}
	
	public class SerialCom
	{
		public SerialPort sPort = null;
		
		private Timer myTimer = new Timer();

		public SerialCom(String comport,int baud )
		{
			try{
				sPort = new SerialPort(comport, baud );
				sPort.Open();
				//sPort.DataRecived+=new SerialDataReceivedEventHandler(dataRecive);
				myTimer.Tick += new EventHandler(Scanner);
				myTimer.Interval = 100;
				myTimer.Enabled = true;
				RS232.onConnect();
			}
			catch(Exception ex)
			{
				RS232.onDisconnect();
			 
			}
		}
		
	 
		public void closeConnection(){
			sPort.Close();
			myTimer.Dispose();
			RS232.onDisconnect();
		}
		
		public void SendData(string outData) {
			sPort.Write(outData);
		}
 
		private void Scanner(Object ob, EventArgs ev) 
		{			
		 
			string data = "";
			
			try {
				data = sPort.ReadExisting();
			}
			catch (Exception) { return; }
			if (data.Length == 0) { return; }

			RS232.onRead(data);	

		}		
	}
}
