
namespace Neo.ApplicationFramework.Generated
{
    using System.Windows.Forms;
    using System;
    using System.Drawing;
    using Neo.ApplicationFramework.Tools;
    using Neo.ApplicationFramework.Common.Graphics.Logic;
    using Neo.ApplicationFramework.Controls;
    using Neo.ApplicationFramework.Interfaces;
    
	using System.Collections.Generic;
	using System.IO;
	
    public partial class Rezonans
    {	
		String dizin="\\FlashDrive\\Project\\Project Files\\tables\\";
	//	String	dizin="c:\\data\\tables\\";
		
		private	List<Tank> tankList=new List<Tank>();
		
 
		void Rezonans_Created(System.Object sender, System.EventArgs e)
		{ 
			initTanks();
		}
		
		//sistemdeki tank Listesini döndürür
		public List<Tank> getTanks(){
			return tankList;
		}

		// dip değeri gelen tankın volume hesabı yapılır
		// Hangi tank olduğu tablo numarasıyla belirlenir.
		public  void tank_hesapla(int tank_no,uint dip){
			for(int k=0;k<tankList.Count;k++){
				
				Tank tank=tankList[k];
				
				if(tank.table_no==tank_no){
					tank.dip=dip;
				
					double calc=hesapla(tank.dip,tank.table);
					tank.volume = (uint)calc;
					break;
				}
			}
			
		}
		
		// Tank Tanım tabloları okunarak Her Tablo için bir Tank Nesnesi Yaratılır
		// Ve oluşan tank nesneleri Tank Listesine Eklenir
		public void initTanks(){

			DirectoryInfo info = new DirectoryInfo(@""+dizin);
			FileInfo[] filelist = info.GetFiles("*.lst");
		 
			int k=0;
			String tankListesi="";
			foreach (FileInfo file in filelist)
			{
				if(file.Extension==".lst"){	
					
					int id=k;
					String tank_name=file.Name.Replace(file.Extension,"");
					int table_no = int.Parse(tank_name);
					
					Tank tank= new Tank(id,tank_name,table_no);
					tank.table = getTable(table_no);
				
					tankList.Add(tank);
					tankListesi+=tank.ToString()+"\r\n";
					k++;
				}
			}
			Globals.Tags.tank_LISTESI.Value=tankListesi;
			

		}
		
		// Tank Nesnesi Kullanılmadan Hesap Yapmaya Yarar
		// diğer Hesapla fonksioyuyla görevi aynıdır
		public double hesapla(uint dip,List<Data> tablo){
			double val=-1;
			
			Data prev=new Data(0,0);
			for(int k=0;k<tablo.Count;k++){
				Data d=tablo[k];
				if(dip<d.dip){
					val=(((d.hacim - prev.hacim) * (dip - prev.dip)) / (d.dip - prev.dip)) + prev.hacim;
					break;
				}	
				prev=d;
			}
			
			Globals.Tags.calc_vol.Value = val;
		//	MessageBox.Show("deger:"+val);
			return val;
		}		
		
		//Ana dizindeki Tank Dosyasını okuyarak 
		// Tank Tablosu oluşturur ve Liste olarak geri döndürür
		public List<Data> getTable(int table_index){
			List<Data> tablo=new List<Data>();
			String fileLoc=dizin+table_index+".lst";
			try{
				using (StreamReader sr = new StreamReader(fileLoc)) 
				{
					string line;
				 
					while ((line = sr.ReadLine()) != null) 
					{
						 
						String[] row=line.Split(',');
						uint dip=uint.Parse(row[0]);
						uint hacim=uint.Parse(row[1]);
						Data data=new Data(dip,hacim);
						tablo.Add(data);
						
					}
				
				}
			}catch(Exception ex){
			
			//	MessageBox.Show(table_index+": tablosu yüklenirken hata oluştu:"+ex.Message+"\r\n"+fileLoc);
			}
			return tablo;
		}
		
    }
	
	// Tank Tablo verisini tıtan Sınıf
	public class Data{
		public 	uint  dip=0;
		public	uint hacim=0;
		
		public Data(uint dip_,uint hacim_){
			this.dip=dip_;
			this.hacim=hacim_;
		}
	}
 
	
	// Tank Sınıfı Tanımlaması
	public class Tank{
		public	int id=0;
		public	String name="tank1";
		public	uint dip=0;
		public	uint volume=0;
		public	int pressure=0;
		public	int temperature=0;
		public 	int table_no=2210;
		public List<Data> table=new List<Data>();
	
		public Tank(int id_,String name_,uint dip_,uint volume_,int pressure_,int temperature_){
			this.id=id_;
			this.name=name_;
			this.dip=dip_;
			this.volume=volume_;
			this.pressure=pressure_;
			this.temperature=temperature_;
		}
		
		public Tank(int id_,String name_,int table_no_){
			this.id=id_;
			this.name=name_;
			this.table_no=table_no_;
		}
		
		public Tank setName(int table_no_){
			this.table_no=table_no_;
			return this;
		}
		public Tank setTable(int table_no_){
			this.table_no=table_no_;
			return this;
		}
		public Tank setTable(List<Data> table_){
			this.table=table_;
			return this;
		}
		
		public String ToString(){
			return this.table_no+"";
		}
		public String toJSON(){
			String json="{";
				json+="\"id\":"+"\""+id+"\",";
				json+="\"name\":"+"\""+name+"\",";
				json+="\"dip\":"+"\""+dip+"\",";
				json+="\"volume\":"+"\""+volume+"\",";
				json+="\"press\":"+"\""+pressure+"\",";
				json+="\"temp\":"+"\""+temperature+"\"";
			json+="}";
			return json;
		}
	}
}
