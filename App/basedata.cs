using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace pabk.prog
{
	/// <summary>
	/// Summary description for basedata.
	/// </summary>
	public class frm_basedata : System.Windows.Forms.Form
	{
		private System.Windows.Forms.NotifyIcon Notify;
		private System.Windows.Forms.ContextMenu mnu_ctx_notify;
		private System.Windows.Forms.MenuItem ctx_return;
		private System.Windows.Forms.MenuItem ctx_space_first;
		private System.Windows.Forms.MenuItem ctx_TimeSinceReboot;
		private System.Windows.Forms.MenuItem ctx_CurrentOSVersion;
		private System.Windows.Forms.MenuItem ctx_FrameworkVersion;
		private System.Windows.Forms.MenuItem ctx_CurrentTimeZone;
		private System.Windows.Forms.MenuItem ctx_CurrentDate;
		private System.Windows.Forms.MenuItem ctx_space_second;
		private System.Windows.Forms.MenuItem ctx_Exit;
		private ShamsiDate.msbg_sd msbg_sd1;
		private System.Windows.Forms.DataGrid dg_zone;
		private System.Windows.Forms.DataGrid dg_landtype;
		private System.Windows.Forms.DataGrid dg_documentstatus;
		private System.Windows.Forms.DataGrid dg_facing;
		private System.Windows.Forms.DataGrid dg_geographysituation;
		private System.Windows.Forms.DataGrid dg_warmsystem;
		private System.Windows.Forms.DataGrid dg_coldsystem;
		private System.Windows.Forms.DataGrid dg_kitchentype;
		private System.Windows.Forms.DataGrid dg_agreementtype;
		private AxShockwaveFlashObjects.AxShockwaveFlash gui_basedata;
		private System.Timers.Timer tmr_sh_date;
		private System.ComponentModel.IContainer components;

		public frm_basedata()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_basedata));
			this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
			this.mnu_ctx_notify = new System.Windows.Forms.ContextMenu();
			this.ctx_return = new System.Windows.Forms.MenuItem();
			this.ctx_space_first = new System.Windows.Forms.MenuItem();
			this.ctx_TimeSinceReboot = new System.Windows.Forms.MenuItem();
			this.ctx_CurrentOSVersion = new System.Windows.Forms.MenuItem();
			this.ctx_FrameworkVersion = new System.Windows.Forms.MenuItem();
			this.ctx_CurrentTimeZone = new System.Windows.Forms.MenuItem();
			this.ctx_CurrentDate = new System.Windows.Forms.MenuItem();
			this.ctx_space_second = new System.Windows.Forms.MenuItem();
			this.ctx_Exit = new System.Windows.Forms.MenuItem();
			this.msbg_sd1 = new ShamsiDate.msbg_sd();
			this.dg_zone = new System.Windows.Forms.DataGrid();
			this.dg_agreementtype = new System.Windows.Forms.DataGrid();
			this.dg_landtype = new System.Windows.Forms.DataGrid();
			this.dg_documentstatus = new System.Windows.Forms.DataGrid();
			this.dg_facing = new System.Windows.Forms.DataGrid();
			this.dg_geographysituation = new System.Windows.Forms.DataGrid();
			this.dg_kitchentype = new System.Windows.Forms.DataGrid();
			this.dg_warmsystem = new System.Windows.Forms.DataGrid();
			this.dg_coldsystem = new System.Windows.Forms.DataGrid();
			this.gui_basedata = new AxShockwaveFlashObjects.AxShockwaveFlash();
			this.tmr_sh_date = new System.Timers.Timer();
			((System.ComponentModel.ISupportInitialize)(this.dg_zone)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_agreementtype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_landtype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_documentstatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_facing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_geographysituation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_kitchentype)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_warmsystem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_coldsystem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gui_basedata)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tmr_sh_date)).BeginInit();
			this.SuspendLayout();
			// 
			// Notify
			// 
			this.Notify.ContextMenu = this.mnu_ctx_notify;
			this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
			this.Notify.Text = "";
			this.Notify.DoubleClick += new System.EventHandler(this.Notify_DoubleClick);
			// 
			// mnu_ctx_notify
			// 
			this.mnu_ctx_notify.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.ctx_return,
																						   this.ctx_space_first,
																						   this.ctx_TimeSinceReboot,
																						   this.ctx_CurrentOSVersion,
																						   this.ctx_FrameworkVersion,
																						   this.ctx_CurrentTimeZone,
																						   this.ctx_CurrentDate,
																						   this.ctx_space_second,
																						   this.ctx_Exit});
			this.mnu_ctx_notify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			// 
			// ctx_return
			// 
			this.ctx_return.Index = 0;
			this.ctx_return.Text = "»«“ê‘  »Â »—‰«„Â";
			this.ctx_return.Click += new System.EventHandler(this.ctx_return_Click);
			// 
			// ctx_space_first
			// 
			this.ctx_space_first.Index = 1;
			this.ctx_space_first.Text = "-";
			// 
			// ctx_TimeSinceReboot
			// 
			this.ctx_TimeSinceReboot.Index = 2;
			this.ctx_TimeSinceReboot.Text = "„œ  “„«‰Ì ﬂÂ Ê«—œ ÊÌ‰œÊ“ ‘œÂ «Ìœ";
			this.ctx_TimeSinceReboot.Click += new System.EventHandler(this.ctx_TimeSinceReboot_Click);
			// 
			// ctx_CurrentOSVersion
			// 
			this.ctx_CurrentOSVersion.Index = 3;
			this.ctx_CurrentOSVersion.Text = "‰”ŒÂ ”Ì” „ ⁄«„· ›⁄·Ì ‘„«";
			this.ctx_CurrentOSVersion.Click += new System.EventHandler(this.ctx_CurrentOSVersion_Click);
			// 
			// ctx_FrameworkVersion
			// 
			this.ctx_FrameworkVersion.Index = 4;
			this.ctx_FrameworkVersion.Text = "‰”ŒÂ ›⁄·Ì .NET Framework";
			this.ctx_FrameworkVersion.Click += new System.EventHandler(this.ctx_FrameworkVersion_Click);
			// 
			// ctx_CurrentTimeZone
			// 
			this.ctx_CurrentTimeZone.Index = 5;
			this.ctx_CurrentTimeZone.Text = "„‰ÿﬁÂ “„«‰Ì ›⁄·Ì";
			this.ctx_CurrentTimeZone.Click += new System.EventHandler(this.ctx_CurrentTimeZone_Click);
			// 
			// ctx_CurrentDate
			// 
			this.ctx_CurrentDate.Index = 6;
			this.ctx_CurrentDate.Text = " «—ÌŒ Ê ”«⁄  ›⁄·Ì";
			this.ctx_CurrentDate.Click += new System.EventHandler(this.ctx_CurrentDate_Click);
			// 
			// ctx_space_second
			// 
			this.ctx_space_second.Index = 7;
			this.ctx_space_second.Text = "-";
			// 
			// ctx_Exit
			// 
			this.ctx_Exit.Index = 8;
			this.ctx_Exit.Shortcut = System.Windows.Forms.Shortcut.F10;
			this.ctx_Exit.Text = "Œ—ÊÃ";
			this.ctx_Exit.Click += new System.EventHandler(this.ctx_Exit_Click);
			// 
			// msbg_sd1
			// 
			this.msbg_sd1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.msbg_sd1.Location = new System.Drawing.Point(0, 0);
			this.msbg_sd1.Name = "msbg_sd1";
			this.msbg_sd1.Size = new System.Drawing.Size(16, 16);
			this.msbg_sd1.TabIndex = 1;
			// 
			// dg_zone
			// 
			this.dg_zone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_zone.DataMember = "";
			this.dg_zone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_zone.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_zone.Location = new System.Drawing.Point(683, 105);
			this.dg_zone.Name = "dg_zone";
			this.dg_zone.PreferredColumnWidth = 165;
			this.dg_zone.ReadOnly = true;
			this.dg_zone.Size = new System.Drawing.Size(291, 613);
			this.dg_zone.TabIndex = 1;
			// 
			// dg_agreementtype
			// 
			this.dg_agreementtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_agreementtype.DataMember = "";
			this.dg_agreementtype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_agreementtype.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_agreementtype.Location = new System.Drawing.Point(366, 50);
			this.dg_agreementtype.Name = "dg_agreementtype";
			this.dg_agreementtype.PreferredColumnWidth = 165;
			this.dg_agreementtype.ReadOnly = true;
			this.dg_agreementtype.Size = new System.Drawing.Size(291, 148);
			this.dg_agreementtype.TabIndex = 2;
			// 
			// dg_landtype
			// 
			this.dg_landtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_landtype.DataMember = "";
			this.dg_landtype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_landtype.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_landtype.Location = new System.Drawing.Point(366, 223);
			this.dg_landtype.Name = "dg_landtype";
			this.dg_landtype.PreferredColumnWidth = 165;
			this.dg_landtype.ReadOnly = true;
			this.dg_landtype.Size = new System.Drawing.Size(291, 148);
			this.dg_landtype.TabIndex = 3;
			// 
			// dg_documentstatus
			// 
			this.dg_documentstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_documentstatus.DataMember = "";
			this.dg_documentstatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_documentstatus.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_documentstatus.Location = new System.Drawing.Point(366, 397);
			this.dg_documentstatus.Name = "dg_documentstatus";
			this.dg_documentstatus.PreferredColumnWidth = 165;
			this.dg_documentstatus.ReadOnly = true;
			this.dg_documentstatus.Size = new System.Drawing.Size(291, 148);
			this.dg_documentstatus.TabIndex = 4;
			// 
			// dg_facing
			// 
			this.dg_facing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_facing.DataMember = "";
			this.dg_facing.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_facing.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_facing.Location = new System.Drawing.Point(366, 570);
			this.dg_facing.Name = "dg_facing";
			this.dg_facing.PreferredColumnWidth = 165;
			this.dg_facing.ReadOnly = true;
			this.dg_facing.Size = new System.Drawing.Size(291, 148);
			this.dg_facing.TabIndex = 5;
			// 
			// dg_geographysituation
			// 
			this.dg_geographysituation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_geographysituation.DataMember = "";
			this.dg_geographysituation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_geographysituation.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_geographysituation.Location = new System.Drawing.Point(50, 50);
			this.dg_geographysituation.Name = "dg_geographysituation";
			this.dg_geographysituation.PreferredColumnWidth = 165;
			this.dg_geographysituation.ReadOnly = true;
			this.dg_geographysituation.Size = new System.Drawing.Size(291, 148);
			this.dg_geographysituation.TabIndex = 6;
			// 
			// dg_kitchentype
			// 
			this.dg_kitchentype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_kitchentype.DataMember = "";
			this.dg_kitchentype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_kitchentype.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_kitchentype.Location = new System.Drawing.Point(50, 223);
			this.dg_kitchentype.Name = "dg_kitchentype";
			this.dg_kitchentype.PreferredColumnWidth = 165;
			this.dg_kitchentype.ReadOnly = true;
			this.dg_kitchentype.Size = new System.Drawing.Size(291, 148);
			this.dg_kitchentype.TabIndex = 7;
			// 
			// dg_warmsystem
			// 
			this.dg_warmsystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_warmsystem.DataMember = "";
			this.dg_warmsystem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_warmsystem.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_warmsystem.Location = new System.Drawing.Point(50, 397);
			this.dg_warmsystem.Name = "dg_warmsystem";
			this.dg_warmsystem.PreferredColumnWidth = 165;
			this.dg_warmsystem.ReadOnly = true;
			this.dg_warmsystem.Size = new System.Drawing.Size(291, 148);
			this.dg_warmsystem.TabIndex = 8;
			// 
			// dg_coldsystem
			// 
			this.dg_coldsystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_coldsystem.DataMember = "";
			this.dg_coldsystem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_coldsystem.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_coldsystem.Location = new System.Drawing.Point(50, 570);
			this.dg_coldsystem.Name = "dg_coldsystem";
			this.dg_coldsystem.PreferredColumnWidth = 165;
			this.dg_coldsystem.ReadOnly = true;
			this.dg_coldsystem.Size = new System.Drawing.Size(291, 148);
			this.dg_coldsystem.TabIndex = 9;
			// 
			// gui_basedata
			// 
			this.gui_basedata.Enabled = true;
			this.gui_basedata.Location = new System.Drawing.Point(0, 0);
			this.gui_basedata.Name = "gui_basedata";
			this.gui_basedata.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gui_basedata.OcxState")));
			this.gui_basedata.Size = new System.Drawing.Size(1024, 768);
			this.gui_basedata.TabIndex = 0;
			this.gui_basedata.FSCommand += new AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEventHandler(this.gui_basedata_FSCommand);
			// 
			// tmr_sh_date
			// 
			this.tmr_sh_date.Enabled = true;
			this.tmr_sh_date.SynchronizingObject = this;
			this.tmr_sh_date.Elapsed += new System.Timers.ElapsedEventHandler(this.tmr_sh_date_Elapsed);
			// 
			// frm_basedata
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.ContextMenu = this.mnu_ctx_notify;
			this.ControlBox = false;
			this.Controls.Add(this.dg_coldsystem);
			this.Controls.Add(this.dg_warmsystem);
			this.Controls.Add(this.dg_kitchentype);
			this.Controls.Add(this.dg_geographysituation);
			this.Controls.Add(this.dg_facing);
			this.Controls.Add(this.dg_documentstatus);
			this.Controls.Add(this.dg_landtype);
			this.Controls.Add(this.dg_agreementtype);
			this.Controls.Add(this.dg_zone);
			this.Controls.Add(this.gui_basedata);
			this.Controls.Add(this.msbg_sd1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_basedata";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frm_basedata_Closing);
			this.Load += new System.EventHandler(this.frm_basedata_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg_zone)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_agreementtype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_landtype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_documentstatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_facing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_geographysituation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_kitchentype)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_warmsystem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_coldsystem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gui_basedata)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tmr_sh_date)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public OleDbConnection cnn = new OleDbConnection(String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_zone = new OleDbDataAdapter("SELECT * FROM bd_zone", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_agreementtype = new OleDbDataAdapter("SELECT * FROM bd_agreementtype", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_landtype = new OleDbDataAdapter("SELECT * FROM bd_landtype", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_documentstatus = new OleDbDataAdapter("SELECT * FROM bd_documentstatus", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_facing = new OleDbDataAdapter("SELECT * FROM bd_facing", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_geographysituation = new OleDbDataAdapter("SELECT * FROM bd_geographysituation", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_kitchentype = new OleDbDataAdapter("SELECT * FROM bd_kitchentype", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_warmsystem = new OleDbDataAdapter("SELECT * FROM bd_warmsystem", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_coldsystem = new OleDbDataAdapter("SELECT * FROM bd_coldsystem", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public DataSet ds_zone = new DataSet();
		public DataSet ds_agreementtype = new DataSet();
		public DataSet ds_landtype = new DataSet();
		public DataSet ds_documentstatus = new DataSet();
		public DataSet ds_facing = new DataSet();
		public DataSet ds_geographysituation = new DataSet();
		public DataSet ds_kitchentype = new DataSet();
		public DataSet ds_warmsystem = new DataSet();
		public DataSet ds_coldsystem = new DataSet();
		public string action;

		void pw_sh(string frm_pw_sh)
		{
			OleDbConnection cnn = new OleDbConnection(String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM options", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			DataSet ds = new DataSet();		

			cnn.Open();
			oda.Fill(ds, "options");

			OleDbCommand cmd = new OleDbCommand("SELECT * FROM [options] WHERE (([PassWord]=[PassWord]))", cnn);
			OleDbDataReader drr = cmd.ExecuteReader();
			while (drr.Read())
			{
				DataRow dr = ds.Tables["options"].Rows[0];

				dr.BeginEdit();
				dr["shutdown"] = frm_pw_sh;
				dr.EndEdit();

				OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
				ocb.QuotePrefix = "[";
				ocb.QuoteSuffix = "]";
				oda.UpdateCommand = ocb.GetUpdateCommand();
				if (oda.Update(ds, "options") == 1)
					ds.AcceptChanges();
				else
					ds.RejectChanges();
			}
			cnn.Close();
			drr.Close();
			drr = null;
		}

		void ReStatusGrids(DataGrid dg)
		{
			dg_zone.CaptionText = "Ê÷⁄Ì  :   ";
			dg_agreementtype.CaptionText = "Ê÷⁄Ì  :   ";
			dg_landtype.CaptionText = "Ê÷⁄Ì  :   ";
			dg_documentstatus.CaptionText = "Ê÷⁄Ì  :   ";
			dg_facing.CaptionText = "Ê÷⁄Ì  :   ";
			dg_geographysituation.CaptionText = "Ê÷⁄Ì  :   ";
			dg_kitchentype.CaptionText = "Ê÷⁄Ì  :   ";
			dg_warmsystem.CaptionText = "Ê÷⁄Ì  :   ";
			dg_coldsystem.CaptionText = "Ê÷⁄Ì  :   ";
			
			dg_zone.Enabled = false;
			dg_agreementtype.Enabled = false;
			dg_landtype.Enabled = false;
			dg_documentstatus.Enabled = false;
			dg_facing.Enabled = false;
			dg_geographysituation.Enabled = false;
			dg_kitchentype.Enabled = false;
			dg_warmsystem.Enabled = false;
			dg_coldsystem.Enabled = false;

			dg.CaptionText ="Ê÷⁄Ì  :   «‰ Œ«»";
			dg.Enabled = true;
		}

		void ReNameColumn(DataSet ds, string e_args)
		{
			string table = String.Concat("bd_", e_args.Trim());
			switch (e_args.Trim())
			{
				case "zone":
					if (ds.Tables[table].Columns[0].ColumnName == e_args)
						ds.Tables[table].Columns[0].ColumnName = "„‰ÿﬁÂ";
					else
						ds.Tables[table].Columns[0].ColumnName = e_args;
					break;
				case "agreementtype":
					if (ds.Tables[table].Columns[0].ColumnName == e_args)
						ds.Tables[table].Columns[0].ColumnName = "‰Ê⁄ ﬁ—«—œ«œ";
					else
						ds.Tables[table].Columns[0].ColumnName = e_args;
					break;
				case "landtype":
					if (ds.Tables[table].Columns[0].ColumnName == e_args)
						ds.Tables[table].Columns[0].ColumnName = "‰Ê⁄ „·ﬂ";
					else
						ds.Tables[table].Columns[0].ColumnName = e_args;
					break;
				case "documentstatus":
					if (ds.Tables[table].Columns[0].ColumnName == e_args)
						ds.Tables[table].Columns[0].ColumnName = "Ê÷⁄Ì  ”‰œ";
					else
						ds.Tables[table].Columns[0].ColumnName = e_args;
					break;
				case "facing":
					if (ds.Tables[table].Columns[0].ColumnName == e_args)
						ds.Tables[table].Columns[0].ColumnName = "‰„«";
					else
						ds.Tables[table].Columns[0].ColumnName = e_args;
					break;
				case "geographysituation":
					if (ds.Tables[table].Columns[0].ColumnName == e_args)
						ds.Tables[table].Columns[0].ColumnName = "„Êﬁ⁄Ì  Ã€—«›Ì«∆Ì";
					else
						ds.Tables[table].Columns[0].ColumnName = e_args;
					break;
				case "kitchentype":
					if (ds.Tables[table].Columns[0].ColumnName == e_args)
						ds.Tables[table].Columns[0].ColumnName = "‰Ê⁄ ¬‘Å“Œ«‰Â";
					else
						ds.Tables[table].Columns[0].ColumnName = e_args;
					break;
				case "warmsystem":
					if (ds.Tables[table].Columns[0].ColumnName == e_args)
						ds.Tables[table].Columns[0].ColumnName = "”Ì” „ ê—„«∆Ì";
					else
						ds.Tables[table].Columns[0].ColumnName = e_args;
					break;
				case "coldsystem":
					if (ds.Tables[table].Columns[0].ColumnName == e_args)
						ds.Tables[table].Columns[0].ColumnName = "”Ì” „ ”—„«∆Ì";
					else
						ds.Tables[table].Columns[0].ColumnName = e_args;
					break;
				default:
					break;
			}
		}

		void insert(DataGrid dg)
		{
			dg.Enabled = false;
			dg.CaptionText = "Ê÷⁄Ì  :   «ÌÃ«œ —ﬂÊ—œ ÃœÌœ";
		}

		void edit(string e_args, DataGrid dg, DataSet ds)
		{
			string table = String.Concat("bd_", e_args.Trim());
			dg.Enabled = false;
			gui_basedata.SetVariable("_root.txt_parameters.text", ds.Tables[table].Rows[dg.CurrentCell.RowNumber][ds.Tables[table].Columns[dg.CurrentCell.ColumnNumber]].ToString());
			dg.CaptionText = "Ê÷⁄Ì  :   ÊÌ—«Ì‘ —ﬂÊ—œ";
		}

		void erase(string e_args, DataGrid dg, DataSet ds, OleDbDataAdapter oda)
		{
			string table = String.Concat("bd_", e_args.Trim());
			dg.CaptionText = "Ê÷⁄Ì  :   Õ–› —ﬂÊ—œ";
			DialogResult result = MessageBox.Show("¬Ì« „«Ì· »Â Õ–› ê“Ì‰Â „Ê—œ ‰Ÿ— «“ ·Ì”  „Ì »«‘Ìœ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			switch (result)
			{
				case DialogResult.OK:
					ReNameColumn(ds, e_args.Trim());
					ds.Tables[table].Rows[dg.CurrentCell.RowNumber].Delete();
					OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
					ocb.QuotePrefix = "[";
					ocb.QuoteSuffix = "]";
					oda.DeleteCommand = ocb.GetDeleteCommand();
					if (oda.Update(ds, table) == 1)
						ds.AcceptChanges();
					else
						ds.RejectChanges();
					ReNameColumn(ds, e_args.Trim());
					break;
				case DialogResult.Cancel:
					break;
				default:
					break;
			}
			ReStatusGrids(dg);
		}

		void save_insert(string e_args,DataGrid dg, DataSet ds, OleDbDataAdapter oda)
		{
			string table = String.Concat("bd_", e_args.Trim());
			ReNameColumn(ds, e_args.Trim());
			OleDbCommand cmd = new OleDbCommand(String.Concat("SELECT * FROM [", table, "] WHERE (([", e_args.Trim(), "]='", gui_basedata.GetVariable("_root.txt_parameters.text").Trim(), "'))"), cnn);
			OleDbDataReader drr = cmd.ExecuteReader();
			bool found = false;
			while (drr.Read())
			{
				MessageBox.Show("—ﬂÊ—œ „Ê—œ ‰Ÿ— ‘„« ﬁ»·« «ÌÃ«œ ‘œÂ «” ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Error);
				gui_basedata.SetVariable("_root.txt_parameters.text", "");
				found = true;
				break;
			}
			if (found == false)
			{
				DataRow dr;
				dr = ds.Tables[table].NewRow();
				dr[e_args.Trim()] = gui_basedata.GetVariable("_root.txt_parameters.text").Trim();
				ds.Tables[table].Rows.Add(dr);
				gui_basedata.SetVariable("_root.txt_parameters.text", "");
				OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
				ocb.QuotePrefix = "[";
				ocb.QuoteSuffix = "]";
				oda.InsertCommand = ocb.GetInsertCommand();
				if (oda.Update(ds, table) == 1)
					ds.AcceptChanges();
				else
					ds.RejectChanges();
			}
			ReNameColumn(ds, e_args.Trim());
			ReStatusGrids(dg);
			drr.Close();
			drr =null;
		}

		void save_edit(string e_args, DataGrid dg, DataSet ds, OleDbDataAdapter oda)
		{
			string table = String.Concat("bd_", e_args);
			ReNameColumn(ds, e_args.Trim());
			OleDbCommand cmd = new OleDbCommand(String.Concat("SELECT * FROM [", table, "] WHERE (([", e_args.Trim(), "]='", gui_basedata.GetVariable("_root.txt_parameters.text").Trim(), "'))"), cnn);
			OleDbDataReader drr = cmd.ExecuteReader();
			bool found = false;
			while (drr.Read())
			{
				MessageBox.Show("—ﬂÊ—œ „Ê—œ ‰Ÿ— ‘„« ﬁ»·« «ÌÃ«œ ‘œÂ «” ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Error);
				gui_basedata.SetVariable("_root.txt_parameters.text", "");
				found = true;
				break;
			}
			if (found == false)
			{
				DataRow dr;
				dr = ds.Tables[table].Rows[dg.CurrentCell.RowNumber];
				dr.BeginEdit();
					dr[e_args.Trim()] = gui_basedata.GetVariable("_root.txt_parameters.text").Trim();
				dr.EndEdit();
				gui_basedata.SetVariable("_root.txt_parameters.text", "");
				OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
				ocb.QuotePrefix = "[";
				ocb.QuoteSuffix = "]";
				oda.UpdateCommand = ocb.GetUpdateCommand();
				if (oda.Update(ds, table) == 1)
					ds.AcceptChanges();
				else
					ds.RejectChanges();
			}
			ReNameColumn(ds, e_args.Trim());
			ReStatusGrids(dg);
			drr.Close();
			drr =null;
		}

		void cancel(DataGrid dg)
		{
			ReStatusGrids(dg);
			dg.Enabled = true;
		}

		private void frm_basedata_Load(object sender, System.EventArgs e)
		{
			gui_basedata.Movie = String.Concat(Environment.CurrentDirectory, "\\guibd.mnu");
			pw_sh("basedata");

			cnn.Open();

			oda_zone.Fill(ds_zone, "bd_zone");
			oda_agreementtype.Fill(ds_agreementtype, "bd_agreementtype");
			oda_landtype.Fill(ds_landtype, "bd_landtype");
			oda_documentstatus.Fill(ds_documentstatus, "bd_documentstatus");
			oda_facing.Fill(ds_facing, "bd_facing");
			oda_geographysituation.Fill(ds_geographysituation, "bd_geographysituation");
			oda_kitchentype.Fill(ds_kitchentype, "bd_kitchentype");
			oda_warmsystem.Fill(ds_warmsystem, "bd_warmsystem");
			oda_coldsystem.Fill(ds_coldsystem, "bd_coldsystem");

			dg_zone.DataSource = ds_zone.Tables["bd_zone"];
			dg_agreementtype.DataSource = ds_agreementtype.Tables["bd_agreementtype"];
			dg_landtype.DataSource = ds_landtype.Tables["bd_landtype"];
			dg_documentstatus.DataSource = ds_documentstatus.Tables["bd_documentstatus"];
			dg_facing.DataSource = ds_facing.Tables["bd_facing"];
			dg_geographysituation.DataSource = ds_geographysituation.Tables["bd_geographysituation"];
			dg_kitchentype.DataSource = ds_kitchentype.Tables["bd_kitchentype"];
			dg_warmsystem.DataSource = ds_warmsystem.Tables["bd_warmsystem"];
			dg_coldsystem.DataSource = ds_coldsystem.Tables["bd_coldsystem"];

			ds_zone.Tables["bd_zone"].Columns["zone"].ColumnName = "„‰ÿﬁÂ";
			ds_agreementtype.Tables["bd_agreementtype"].Columns["agreementtype"].ColumnName = "‰Ê⁄ ﬁ—«—œ«œ";
			ds_landtype.Tables["bd_landtype"].Columns["landtype"].ColumnName = "‰Ê⁄ „·ﬂ";
			ds_documentstatus.Tables["bd_documentstatus"].Columns["documentstatus"].ColumnName = "Ê÷⁄Ì  ”‰œ";
			ds_facing.Tables["bd_facing"].Columns["facing"].ColumnName = "‰„«";
			ds_geographysituation.Tables["bd_geographysituation"].Columns["geographysituation"].ColumnName = "„Êﬁ⁄Ì  Ã€—«›Ì«∆Ì";
			ds_kitchentype.Tables["bd_kitchentype"].Columns["kitchentype"].ColumnName = "‰Ê⁄ ¬‘Å“Œ«‰Â";
			ds_warmsystem.Tables["bd_warmsystem"].Columns["warmsystem"].ColumnName = "”Ì” „ ê—„«∆Ì";
			ds_coldsystem.Tables["bd_coldsystem"].Columns["coldsystem"].ColumnName = "”Ì” „ ”—„«∆Ì";

			ReStatusGrids(dg_zone);
		}

		private void gui_basedata_FSCommand(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent e)
		{
			switch (e.command.Trim())
			{
				case "cmb_parameters":
					switch (e.args.Trim())
					{
						case "open":
                            dg_zone.Height = 413;
							dg_zone.Top = 305;
							break;
						case "close":
                            dg_zone.Top = 105;
                            dg_zone.Height = 613;
                            break;
						case "zone":
							ReStatusGrids(dg_zone);
							break;
						case "agreementtype":
							ReStatusGrids(dg_agreementtype);
							break;
						case "landtype":
							ReStatusGrids(dg_landtype);
							break;
						case "documentstatus":
							ReStatusGrids(dg_documentstatus);
							break;
						case "facing":
							ReStatusGrids(dg_facing);
							break;
						case "geographysituation":
							ReStatusGrids(dg_geographysituation);
							break;
						case "kitchentype":
							ReStatusGrids(dg_kitchentype);
							break;
						case "warmsystem":
							ReStatusGrids(dg_warmsystem);
							break;
						case "coldsystem":
							ReStatusGrids(dg_coldsystem);
							break;
						default:
							break;
					}
					break;
				case "btn_insert":
					switch (e.args.Trim())
					{
						case "zone":
							insert(dg_zone);
							break;
						case "agreementtype":
							insert(dg_agreementtype);
							break;
						case "landtype":
							insert(dg_landtype);
							break;
						case "documentstatus":
							insert(dg_documentstatus);
							break;
						case "facing":
							insert(dg_facing);
							break;
						case "geographysituation":
							insert(dg_geographysituation);
							break;
						case "kitchentype":
							insert(dg_kitchentype);
							break;
						case "warmsystem":
							insert(dg_warmsystem);
							break;
						case "coldsystem":
							insert(dg_coldsystem);
							break;
						default:
							break;
					}
					action = "insert";
					break;
				case "btn_edit":
					switch (e.args.Trim())
					{
						case "zone":
							edit(e.args, dg_zone, ds_zone);
							break;
						case "agreementtype":
							edit(e.args, dg_agreementtype, ds_agreementtype);
							break;
						case "landtype":
							edit(e.args, dg_landtype, ds_landtype);
							break;
						case "documentstatus":
							edit(e.args, dg_documentstatus, ds_documentstatus);
							break;
						case "facing":
							edit(e.args, dg_facing, ds_facing);
							break;
						case "geographysituation":
							edit(e.args, dg_geographysituation, ds_geographysituation);
							break;
						case "kitchentype":
							edit(e.args, dg_kitchentype, ds_kitchentype);
							break;
						case "warmsystem":
							edit(e.args, dg_warmsystem, ds_warmsystem);
							break;
						case "coldsystem":
							edit(e.args, dg_coldsystem, ds_coldsystem);
							break;
						default:
							break;
					}
					action = "edit";
					break;
				case "btn_erase":
					switch (e.args.Trim())
					{
						case "zone":
							erase(e.args, dg_zone, ds_zone, oda_zone);
							break;
						case "agreementtype":
							erase(e.args, dg_agreementtype, ds_agreementtype, oda_agreementtype);
							break;
						case "landtype":
							erase(e.args, dg_landtype, ds_landtype, oda_landtype);
							break;
						case "documentstatus":
							erase(e.args, dg_documentstatus, ds_documentstatus, oda_documentstatus);
							break;
						case "facing":
							erase(e.args, dg_facing, ds_facing, oda_facing);
							break;
						case "geographysituation":
							erase(e.args, dg_geographysituation, ds_geographysituation, oda_geographysituation);
							break;
						case "kitchentype":
							erase(e.args, dg_kitchentype, ds_kitchentype, oda_kitchentype);
							break;
						case "warmsystem":
							erase(e.args, dg_warmsystem, ds_warmsystem, oda_warmsystem);
							break;
						case "coldsystem":
							erase(e.args, dg_coldsystem, ds_coldsystem, oda_coldsystem);
							break;
						default:
							break;
					}
					break;
				case "btn_save":
					switch (action)
					{
						case "insert":
							switch (e.args.Trim())
							{
								case "zone":
									save_insert(e.args, dg_zone, ds_zone, oda_zone);
									break;
								case "agreementtype":
									save_insert(e.args, dg_agreementtype, ds_agreementtype, oda_agreementtype);
									break;
								case "landtype":
									save_insert(e.args, dg_landtype, ds_landtype, oda_landtype);
									break;
								case "documentstatus":
									save_insert(e.args, dg_documentstatus, ds_documentstatus, oda_documentstatus);
									break;
								case "facing":
									save_insert(e.args, dg_facing, ds_facing, oda_facing);
									break;
								case "geographysituation":
									save_insert(e.args, dg_geographysituation, ds_geographysituation, oda_geographysituation);
									break;
								case "kitchentype":
									save_insert(e.args, dg_kitchentype, ds_kitchentype, oda_kitchentype);
									break;
								case "warmsystem":
									save_insert(e.args, dg_warmsystem, ds_warmsystem, oda_warmsystem);
									break;
								case "coldsystem":
									save_insert(e.args, dg_coldsystem, ds_coldsystem, oda_coldsystem);
									break;
								default:
									break;
							}
							break;
						case "edit":
							switch (e.args.Trim())
							{
								case "zone":
									save_edit(e.args, dg_zone, ds_zone, oda_zone);
									break;
								case "agreementtype":
									save_edit(e.args, dg_agreementtype, ds_agreementtype, oda_agreementtype);
									break;
								case "landtype":
									save_edit(e.args, dg_landtype, ds_landtype, oda_landtype);
									break;
								case "documentstatus":
									save_edit(e.args, dg_documentstatus, ds_documentstatus, oda_documentstatus);
									break;
								case "facing":
									save_edit(e.args, dg_facing, ds_facing, oda_facing);
									break;
								case "geographysituation":
									save_edit(e.args, dg_geographysituation, ds_geographysituation, oda_geographysituation);
									break;
								case "kitchentype":
									save_edit(e.args, dg_kitchentype, ds_kitchentype, oda_kitchentype);
									break;
								case "warmsystem":
									save_edit(e.args, dg_warmsystem, ds_warmsystem, oda_warmsystem);
									break;
								case "coldsystem":
									save_edit(e.args, dg_coldsystem, ds_coldsystem, oda_coldsystem);
									break;
								default:
									break;
							}
							break;
						default:
							break;
					}
					dg_zone.Enabled = true;
					break;
				case "btn_cancel":
					switch (e.args.Trim())
					{
						case "zone":
							cancel(dg_zone);
							break;
						case "agreementtype":
							cancel(dg_agreementtype);
							break;
						case "landtype":
							cancel(dg_landtype);
							break;
						case "documentstatus":
							cancel(dg_documentstatus);
							break;
						case "facing":
							cancel(dg_facing);
							break;
						case "geographysituation":
							cancel(dg_geographysituation);
							break;
						case "kitchentype":
							cancel(dg_kitchentype);
							break;
						case "warmsystem":
							cancel(dg_warmsystem);
							break;
						case "coldsystem":
							cancel(dg_coldsystem);
							break;
						default:
							break;
					}
					break;
				case "protect":
					frm_pw Form_PW = new frm_pw();
					this.Hide();
					Form_PW.Show();
					break;;
				case "return":
					frm_main Form_Main = new frm_main();
					Form_Main.Show();
					this.Hide();
					break;
				case "systemtray":
					this.Hide();
					Notify.Visible = true;
					Notify.Text = "»—«Ì ‰„«Ì‘ „Ãœœ œ«»· ﬂ·Ìﬂ ﬂ‰Ìœ";
					break;
				default:
					break;
			}
		}

		private void Notify_DoubleClick(object sender, System.EventArgs e)
		{
			Notify.Visible = false;
			this.Show();
		}

		private void ctx_Exit_Click(object sender, System.EventArgs e)
		{
			Notify.Visible = false;
			pw_sh("");
			Application.Exit();
		}

		private void ctx_return_Click(object sender, System.EventArgs e)
		{
			Notify.Visible = false;
			this.Show();
		}

		private void ctx_CurrentTimeZone_Click(object sender, System.EventArgs e)
		{
			if (TimeZone.CurrentTimeZone.IsDaylightSavingTime(DateTime.Now)) 
				MessageBox.Show(String.Concat(TimeZone.CurrentTimeZone.DaylightName, " :„‰ÿﬁÂ “„«‰Ì ›⁄·Ì ”Ì” „"), "„‰ÿﬁÂ “„«‰Ì", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else 
				MessageBox.Show(String.Concat(TimeZone.CurrentTimeZone.StandardName, " :„‰ÿﬁÂ “„«‰Ì ›⁄·Ì ”Ì” „"), "„‰ÿﬁÂ “„«‰Ì", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ctx_TimeSinceReboot_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(String.Concat("ÕœÊœ« ", ((Int32)((Environment.TickCount / 1000) / 60)).ToString(), " œﬁÌﬁÂ «“ “„«‰ »Ê  ÊÌ‰œÊ“ „Ì ê–—œ"), "¬Œ—Ì‰ »Ê ", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ctx_FrameworkVersion_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(String.Concat("Framework Version: ", Environment.Version.ToString()), ".NET Framework Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ctx_CurrentOSVersion_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(String.Concat("OS Version: ", Environment.OSVersion.ToString()), "Operating System", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void ctx_CurrentDate_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(String.Concat(DateTime.Now.ToLongDateString(), "   ", DateTime.Now.ToLongTimeString(), "       ", msbg_sd1.msbg_ShamsiDate(), " : «—ÌŒ ‘„”Ì"), " «—ÌŒ Ê ”«⁄ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void frm_basedata_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			pw_sh("");
			cnn.Close();
			Application.Exit();
		}

		private void tmr_sh_date_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			gui_basedata.SetVariable("_root.Time_SH", msbg_sd1.msbg_ShamsiDate());
		}
	}
}