//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neo.ApplicationFramework.Generated
{
	using Neo.ApplicationFramework.Tools.Actions;
	
	
	public partial class Tags : Neo.ApplicationFramework.Tools.OpcClient.GlobalController, Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage
	{
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag Tag1;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag level;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag volume;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag temp;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag dip_value;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag tank_no;
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem calc_vol;
		
		public Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem tank_LISTESI;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag BT;
		
		public Neo.ApplicationFramework.Tools.OpcClient.LightweightTag ET;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup1;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup2;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup3;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup4;
		
		public Neo.ApplicationFramework.Tools.OpcClient.PollGroup PollGroup5;
		
		public Tags()
		{
			this.InitializeComponent();
			this.ApplyLanguageInternal();
		}
		
		private void InitializeComponent()
		{
			this.InitializeObjectCreations();
			this.InitializeBeginInits();
			this.InitializeObjects();
			this.InitializeEndInits();
			this.ConnectDataBindings();
		}
		
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		public virtual void ConnectDataBindings()
		{
		}
		
		private void InitializeObjectCreations()
		{
			this.Tag1 = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("Tag1", "", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), false, "", null);
			this.level = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("level", "", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), false, "", null);
			this.volume = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("volume", "", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_REAL4)), false, "", null);
			this.temp = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("temp", "", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), false, "", null);
			this.dip_value = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("dip_value", "Controller1.DataItem1", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_UINTEGER4)), false, "", null);
			this.tank_no = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("tank_no", "", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), false, "", null);
			this.calc_vol = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("calc_vol", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Core.Api.DataSource.AccessRights)((Core.Api.DataSource.AccessRights.Read | Core.Api.DataSource.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_UINTEGER4)), "", ((short)(1)), "", "");
			this.tank_LISTESI = new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataItem("tank_LISTESI", ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_DEFAULT)), ((short)(1)), 0D, 1D, ((short)(0)), false, "Value Change", ((Core.Api.DataSource.AccessRights)((Core.Api.DataSource.AccessRights.Read | Core.Api.DataSource.AccessRights.Write))), "PollGroup1", false, false, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_STRING)), "", ((short)(1)), "", "");
			this.BT = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("BT", "Controller1.DataItem2", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), false, "", null);
			this.ET = new Neo.ApplicationFramework.Tools.OpcClient.LightweightTag("ET", "Controller1.DataItem3", 500, ((Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE)(Neo.ApplicationFramework.Interop.DataSource.BEDATATYPE.DT_INTEGER2)), false, "", null);
			this.PollGroup1 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup2 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup3 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup4 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
			this.PollGroup5 = new Neo.ApplicationFramework.Tools.OpcClient.PollGroup();
		}
		
		private void InitializeBeginInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
		}
		
		private void InitializeEndInits()
		{
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
		}
		
		private void InitializeObjects()
		{
			this.calc_vol.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[0], new string[0], true));
			this.tank_LISTESI.GlobalDataSubItems.Add(new Neo.ApplicationFramework.Tools.OpcClient.GlobalDataSubItem(null, 0, new string[0], new string[0], true));
			this.LightweightTags.Add(this.Tag1);
			this.LightweightTags.Add(this.level);
			this.LightweightTags.Add(this.volume);
			this.LightweightTags.Add(this.temp);
			this.LightweightTags.Add(this.dip_value);
			this.LightweightTags.Add(this.tank_no);
			this.GlobalDataItems.Add(this.calc_vol);
			this.GlobalDataItems.Add(this.tank_LISTESI);
			this.LightweightTags.Add(this.BT);
			this.LightweightTags.Add(this.ET);
			this.PollGroup1.Interval = 500;
			this.PollGroup1.Name = "PollGroup1";
			this.PollGroup2.Interval = 500;
			this.PollGroup2.Name = "PollGroup2";
			this.PollGroup3.Interval = 500;
			this.PollGroup3.Name = "PollGroup3";
			this.PollGroup4.Interval = 500;
			this.PollGroup4.Name = "PollGroup4";
			this.PollGroup5.Interval = 500;
			this.PollGroup5.Name = "PollGroup5";
			this.PollGroups.Add(this.PollGroup1);
			this.PollGroups.Add(this.PollGroup2);
			this.PollGroups.Add(this.PollGroup3);
			this.PollGroups.Add(this.PollGroup4);
			this.PollGroups.Add(this.PollGroup5);
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		private void ApplyLanguageInternal()
		{
			Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager resources = new Neo.ApplicationFramework.Tools.MultiLanguage.MultiLanguageResourceManager(typeof(Tags));
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		void Neo.ApplicationFramework.Interfaces.ISupportMultiLanguage.ApplyLanguage()
		{
			this.ApplyLanguage();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		protected virtual void ApplyLanguage()
		{
			this.ApplyLanguageInternal();
		}
	}
}
