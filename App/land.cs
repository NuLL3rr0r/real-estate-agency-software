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
	/// Summary description for land.
	/// </summary>
	public class frm_land : System.Windows.Forms.Form
	{
		private AxShockwaveFlashObjects.AxShockwaveFlash gui_land;
		private ShamsiDate.msbg_sd msbg_sd1;
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
		private System.Windows.Forms.ComboBox cmb_facing;
		private System.Windows.Forms.ComboBox cmb_geographysituation;
		private System.Windows.Forms.ComboBox cmb_kitchentype;
		private System.Windows.Forms.ComboBox cmb_warmsystem;
		private System.Windows.Forms.ComboBox cmb_coldsystem;
		private System.Windows.Forms.ComboBox cmb_zone;
		private System.Windows.Forms.ComboBox cmb_agreementtype;
		private System.Windows.Forms.ComboBox cmb_landtype;
		private System.Windows.Forms.ComboBox cmb_documentstatus;
		private System.Windows.Forms.TextBox txt_LandLord;
		private System.Windows.Forms.TextBox txt_Tel;
		private System.Windows.Forms.TextBox txt_Mobile;
		private System.Windows.Forms.TextBox txt_Introducer;
		private System.Windows.Forms.TextBox txt_Address;
		private System.Windows.Forms.TextBox txt_Date;
		private System.Windows.Forms.TextBox txt_ID;
		private System.Windows.Forms.DataGrid dg_Master;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Button btn_erase;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_exchange;
		private System.Windows.Forms.Button btn_activate;
		private System.Windows.Forms.Button btn_find;
		private System.Windows.Forms.Button btn_find_ID;
		private System.Windows.Forms.TextBox txt_Introducer_Tel;
		private System.Timers.Timer tmr_sh_date;
		private System.Windows.Forms.ContextMenu mnu_ctx_sh_date;
		private System.Windows.Forms.MenuItem ctx_sh_date;
		private System.Windows.Forms.NumericUpDown txt_Age_of_Builder;
		private System.Windows.Forms.NumericUpDown txt_Quantity_of_Floors;
		private System.Windows.Forms.NumericUpDown txt_Quantity_of_Units;
		private System.Windows.Forms.NumericUpDown txt_Quantity_of_BedRoom;
		private System.Windows.Forms.NumericUpDown txt_Quantity_of_PhoneLine;
		private System.Windows.Forms.NumericUpDown txt_Area_Builder_Base;
		private System.Windows.Forms.NumericUpDown txt_Width_Away;
		private System.Windows.Forms.NumericUpDown txt_Depot_Meter;
		private System.Windows.Forms.NumericUpDown txt_Area_Total;
		private System.Windows.Forms.NumericUpDown txt_Amount_of_Sale;
		private System.Windows.Forms.NumericUpDown txt_Amount_of_Mortgage;
		private System.Windows.Forms.NumericUpDown txt_Amount_of_Rent;
		private System.Windows.Forms.NumericUpDown numericUpDown8;
		private System.Windows.Forms.NumericUpDown txt_to_Area_Total;
		private System.Windows.Forms.NumericUpDown txt_from_Area_Total;
		private System.Windows.Forms.NumericUpDown txt_to_Area_Builder_Base;
		private System.Windows.Forms.NumericUpDown txt_to_Width_Away;
		private System.Windows.Forms.NumericUpDown txt_to_Depot_Meter;
		private System.Windows.Forms.NumericUpDown txt_from_Area_Builder_Base;
		private System.Windows.Forms.NumericUpDown txt_from_Width_Away;
		private System.Windows.Forms.NumericUpDown txt_from_Depot_Meter;
		private System.Windows.Forms.NumericUpDown txt_to_Amount_of_Sale;
		private System.Windows.Forms.NumericUpDown txt_from_Amount_of_Sale;
		private System.Windows.Forms.NumericUpDown txt_to_Amount_of_Mortgage;
		private System.Windows.Forms.NumericUpDown txt_from_Amount_of_Mortgage;
		private System.Windows.Forms.NumericUpDown txt_to_Amount_of_Rent;
		private System.Windows.Forms.NumericUpDown txt_from_Amount_of_Rent;
		private System.Windows.Forms.NumericUpDown txt_to_Quantity_of_BedRoom;
		private System.Windows.Forms.NumericUpDown txt_from_Quantity_of_BedRoom;
		private System.Windows.Forms.NumericUpDown txt_to_Age_of_Builder;
		private System.Windows.Forms.NumericUpDown txt_from_Age_of_Builder;
		private System.Windows.Forms.NumericUpDown txt_to_Quantity_of_Floors;
		private System.Windows.Forms.NumericUpDown txt_to_Quantity_of_Units;
		private System.Windows.Forms.NumericUpDown txt_from_Quantity_of_Floors;
		private System.Windows.Forms.NumericUpDown txt_from_Quantity_of_Units;
		private System.Windows.Forms.Button btn_ClearPage;
		private System.ComponentModel.IContainer components;

		public frm_land()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_land));
			this.gui_land = new AxShockwaveFlashObjects.AxShockwaveFlash();
			this.msbg_sd1 = new ShamsiDate.msbg_sd();
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
			this.txt_LandLord = new System.Windows.Forms.TextBox();
			this.txt_Introducer_Tel = new System.Windows.Forms.TextBox();
			this.txt_Tel = new System.Windows.Forms.TextBox();
			this.txt_Mobile = new System.Windows.Forms.TextBox();
			this.txt_Introducer = new System.Windows.Forms.TextBox();
			this.txt_Address = new System.Windows.Forms.TextBox();
			this.txt_Date = new System.Windows.Forms.TextBox();
			this.mnu_ctx_sh_date = new System.Windows.Forms.ContextMenu();
			this.ctx_sh_date = new System.Windows.Forms.MenuItem();
			this.cmb_facing = new System.Windows.Forms.ComboBox();
			this.cmb_geographysituation = new System.Windows.Forms.ComboBox();
			this.cmb_kitchentype = new System.Windows.Forms.ComboBox();
			this.cmb_warmsystem = new System.Windows.Forms.ComboBox();
			this.cmb_coldsystem = new System.Windows.Forms.ComboBox();
			this.dg_Master = new System.Windows.Forms.DataGrid();
			this.cmb_zone = new System.Windows.Forms.ComboBox();
			this.cmb_agreementtype = new System.Windows.Forms.ComboBox();
			this.cmb_landtype = new System.Windows.Forms.ComboBox();
			this.cmb_documentstatus = new System.Windows.Forms.ComboBox();
			this.txt_ID = new System.Windows.Forms.TextBox();
			this.btn_insert = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_erase = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_find = new System.Windows.Forms.Button();
			this.btn_exchange = new System.Windows.Forms.Button();
			this.btn_activate = new System.Windows.Forms.Button();
			this.btn_find_ID = new System.Windows.Forms.Button();
			this.tmr_sh_date = new System.Timers.Timer();
			this.txt_Age_of_Builder = new System.Windows.Forms.NumericUpDown();
			this.txt_Quantity_of_Floors = new System.Windows.Forms.NumericUpDown();
			this.txt_Quantity_of_Units = new System.Windows.Forms.NumericUpDown();
			this.txt_Quantity_of_BedRoom = new System.Windows.Forms.NumericUpDown();
			this.txt_Quantity_of_PhoneLine = new System.Windows.Forms.NumericUpDown();
			this.txt_Area_Builder_Base = new System.Windows.Forms.NumericUpDown();
			this.txt_Width_Away = new System.Windows.Forms.NumericUpDown();
			this.txt_Depot_Meter = new System.Windows.Forms.NumericUpDown();
			this.txt_Area_Total = new System.Windows.Forms.NumericUpDown();
			this.txt_Amount_of_Sale = new System.Windows.Forms.NumericUpDown();
			this.txt_Amount_of_Mortgage = new System.Windows.Forms.NumericUpDown();
			this.txt_Amount_of_Rent = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Area_Total = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Area_Builder_Base = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Width_Away = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Depot_Meter = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Area_Total = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Area_Builder_Base = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Width_Away = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Depot_Meter = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Amount_of_Sale = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Amount_of_Sale = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Amount_of_Mortgage = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Amount_of_Mortgage = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Amount_of_Rent = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Amount_of_Rent = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Age_of_Builder = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Age_of_Builder = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Quantity_of_Floors = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Quantity_of_Units = new System.Windows.Forms.NumericUpDown();
			this.txt_to_Quantity_of_BedRoom = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Quantity_of_Floors = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Quantity_of_Units = new System.Windows.Forms.NumericUpDown();
			this.txt_from_Quantity_of_BedRoom = new System.Windows.Forms.NumericUpDown();
			this.btn_ClearPage = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gui_land)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_Master)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tmr_sh_date)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Age_of_Builder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Quantity_of_Floors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Quantity_of_Units)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Quantity_of_BedRoom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Quantity_of_PhoneLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Area_Builder_Base)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Width_Away)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Depot_Meter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Area_Total)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Amount_of_Sale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Amount_of_Mortgage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Amount_of_Rent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Area_Total)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Area_Builder_Base)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Width_Away)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Depot_Meter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Area_Total)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Area_Builder_Base)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Width_Away)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Depot_Meter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Amount_of_Sale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Amount_of_Sale)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Amount_of_Mortgage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Amount_of_Mortgage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Amount_of_Rent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Amount_of_Rent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Age_of_Builder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Age_of_Builder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Quantity_of_Floors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Quantity_of_Units)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Quantity_of_BedRoom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Quantity_of_Floors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Quantity_of_Units)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Quantity_of_BedRoom)).BeginInit();
			this.SuspendLayout();
			// 
			// gui_land
			// 
			this.gui_land.Enabled = true;
			this.gui_land.Location = new System.Drawing.Point(0, 0);
			this.gui_land.Name = "gui_land";
			this.gui_land.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gui_land.OcxState")));
			this.gui_land.Size = new System.Drawing.Size(1024, 768);
			this.gui_land.TabIndex = 42;
			this.gui_land.FSCommand += new AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEventHandler(this.gui_land_FSCommand);
			// 
			// msbg_sd1
			// 
			this.msbg_sd1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.msbg_sd1.Location = new System.Drawing.Point(0, 0);
			this.msbg_sd1.Name = "msbg_sd1";
			this.msbg_sd1.Size = new System.Drawing.Size(16, 16);
			this.msbg_sd1.TabIndex = 63;
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
			// txt_LandLord
			// 
			this.txt_LandLord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LandLord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_LandLord.Location = new System.Drawing.Point(763, 66);
			this.txt_LandLord.MaxLength = 35;
			this.txt_LandLord.Name = "txt_LandLord";
			this.txt_LandLord.Size = new System.Drawing.Size(135, 21);
			this.txt_LandLord.TabIndex = 0;
			this.txt_LandLord.Text = "";
			this.txt_LandLord.Enter += new System.EventHandler(this.txt_LandLord_Enter);
			// 
			// txt_Introducer_Tel
			// 
			this.txt_Introducer_Tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Introducer_Tel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Introducer_Tel.Location = new System.Drawing.Point(67, 66);
			this.txt_Introducer_Tel.MaxLength = 11;
			this.txt_Introducer_Tel.Name = "txt_Introducer_Tel";
			this.txt_Introducer_Tel.Size = new System.Drawing.Size(90, 21);
			this.txt_Introducer_Tel.TabIndex = 4;
			this.txt_Introducer_Tel.Text = "";
			this.txt_Introducer_Tel.Enter += new System.EventHandler(this.txt_Introducer_Tel_Enter);
			// 
			// txt_Tel
			// 
			this.txt_Tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Tel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Tel.Location = new System.Drawing.Point(618, 66);
			this.txt_Tel.MaxLength = 11;
			this.txt_Tel.Name = "txt_Tel";
			this.txt_Tel.Size = new System.Drawing.Size(90, 21);
			this.txt_Tel.TabIndex = 1;
			this.txt_Tel.Text = "";
			this.txt_Tel.Enter += new System.EventHandler(this.txt_Tel_Enter);
			// 
			// txt_Mobile
			// 
			this.txt_Mobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mobile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Mobile.Location = new System.Drawing.Point(463, 66);
			this.txt_Mobile.MaxLength = 11;
			this.txt_Mobile.Name = "txt_Mobile";
			this.txt_Mobile.Size = new System.Drawing.Size(90, 21);
			this.txt_Mobile.TabIndex = 2;
			this.txt_Mobile.Text = "";
			this.txt_Mobile.Enter += new System.EventHandler(this.txt_Mobile_Enter);
			// 
			// txt_Introducer
			// 
			this.txt_Introducer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Introducer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Introducer.Location = new System.Drawing.Point(248, 66);
			this.txt_Introducer.MaxLength = 35;
			this.txt_Introducer.Name = "txt_Introducer";
			this.txt_Introducer.Size = new System.Drawing.Size(135, 21);
			this.txt_Introducer.TabIndex = 3;
			this.txt_Introducer.Text = "";
			this.txt_Introducer.Enter += new System.EventHandler(this.txt_Introducer_Enter);
			// 
			// txt_Address
			// 
			this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Address.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Address.Location = new System.Drawing.Point(215, 97);
			this.txt_Address.MaxLength = 100;
			this.txt_Address.Name = "txt_Address";
			this.txt_Address.Size = new System.Drawing.Size(689, 21);
			this.txt_Address.TabIndex = 5;
			this.txt_Address.Text = "";
			this.txt_Address.Enter += new System.EventHandler(this.txt_Address_Enter);
			// 
			// txt_Date
			// 
			this.txt_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Date.ContextMenu = this.mnu_ctx_sh_date;
			this.txt_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Date.Location = new System.Drawing.Point(67, 97);
			this.txt_Date.MaxLength = 10;
			this.txt_Date.Name = "txt_Date";
			this.txt_Date.Size = new System.Drawing.Size(90, 21);
			this.txt_Date.TabIndex = 6;
			this.txt_Date.Text = "";
			this.txt_Date.Enter += new System.EventHandler(this.txt_Date_Enter);
			// 
			// mnu_ctx_sh_date
			// 
			this.mnu_ctx_sh_date.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.ctx_sh_date});
			// 
			// ctx_sh_date
			// 
			this.ctx_sh_date.Index = 0;
			this.ctx_sh_date.Shortcut = System.Windows.Forms.Shortcut.F12;
			this.ctx_sh_date.Text = "œ—Ã ŒÊœﬂ«—  «—ÌŒ «„—Ê“ »Â ’Ê—  ‘„”Ì       F12";
			this.ctx_sh_date.Click += new System.EventHandler(this.ctx_sh_date_Click);
			// 
			// cmb_facing
			// 
			this.cmb_facing.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmb_facing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_facing.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmb_facing.Location = new System.Drawing.Point(67, 176);
			this.cmb_facing.MaxDropDownItems = 17;
			this.cmb_facing.MaxLength = 20;
			this.cmb_facing.Name = "cmb_facing";
			this.cmb_facing.Size = new System.Drawing.Size(111, 21);
			this.cmb_facing.TabIndex = 36;
			// 
			// cmb_geographysituation
			// 
			this.cmb_geographysituation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmb_geographysituation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_geographysituation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmb_geographysituation.Location = new System.Drawing.Point(67, 213);
			this.cmb_geographysituation.MaxDropDownItems = 17;
			this.cmb_geographysituation.MaxLength = 20;
			this.cmb_geographysituation.Name = "cmb_geographysituation";
			this.cmb_geographysituation.Size = new System.Drawing.Size(111, 21);
			this.cmb_geographysituation.TabIndex = 37;
			// 
			// cmb_kitchentype
			// 
			this.cmb_kitchentype.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmb_kitchentype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_kitchentype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmb_kitchentype.Location = new System.Drawing.Point(67, 287);
			this.cmb_kitchentype.MaxDropDownItems = 17;
			this.cmb_kitchentype.MaxLength = 20;
			this.cmb_kitchentype.Name = "cmb_kitchentype";
			this.cmb_kitchentype.Size = new System.Drawing.Size(111, 21);
			this.cmb_kitchentype.TabIndex = 39;
			// 
			// cmb_warmsystem
			// 
			this.cmb_warmsystem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmb_warmsystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_warmsystem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmb_warmsystem.Location = new System.Drawing.Point(67, 325);
			this.cmb_warmsystem.MaxDropDownItems = 17;
			this.cmb_warmsystem.MaxLength = 20;
			this.cmb_warmsystem.Name = "cmb_warmsystem";
			this.cmb_warmsystem.Size = new System.Drawing.Size(111, 21);
			this.cmb_warmsystem.TabIndex = 40;
			// 
			// cmb_coldsystem
			// 
			this.cmb_coldsystem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmb_coldsystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_coldsystem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmb_coldsystem.Location = new System.Drawing.Point(67, 361);
			this.cmb_coldsystem.MaxDropDownItems = 17;
			this.cmb_coldsystem.MaxLength = 20;
			this.cmb_coldsystem.Name = "cmb_coldsystem";
			this.cmb_coldsystem.Size = new System.Drawing.Size(111, 21);
			this.cmb_coldsystem.TabIndex = 41;
			// 
			// dg_Master
			// 
			this.dg_Master.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_Master.CaptionVisible = false;
			this.dg_Master.DataMember = "";
			this.dg_Master.Enabled = false;
			this.dg_Master.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.dg_Master.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_Master.Location = new System.Drawing.Point(40, 616);
			this.dg_Master.Name = "dg_Master";
			this.dg_Master.PreferredColumnWidth = 98;
			this.dg_Master.ReadOnly = true;
			this.dg_Master.Size = new System.Drawing.Size(944, 112);
			this.dg_Master.TabIndex = 62;
			this.dg_Master.CurrentCellChanged += new System.EventHandler(this.dg_Master_CurrentCellChanged);
			// 
			// cmb_zone
			// 
			this.cmb_zone.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmb_zone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_zone.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmb_zone.Location = new System.Drawing.Point(765, 223);
			this.cmb_zone.MaxDropDownItems = 17;
			this.cmb_zone.MaxLength = 20;
			this.cmb_zone.Name = "cmb_zone";
			this.cmb_zone.Size = new System.Drawing.Size(110, 21);
			this.cmb_zone.TabIndex = 8;
			// 
			// cmb_agreementtype
			// 
			this.cmb_agreementtype.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmb_agreementtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_agreementtype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmb_agreementtype.Location = new System.Drawing.Point(765, 269);
			this.cmb_agreementtype.MaxDropDownItems = 17;
			this.cmb_agreementtype.MaxLength = 20;
			this.cmb_agreementtype.Name = "cmb_agreementtype";
			this.cmb_agreementtype.Size = new System.Drawing.Size(110, 21);
			this.cmb_agreementtype.TabIndex = 9;
			// 
			// cmb_landtype
			// 
			this.cmb_landtype.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmb_landtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_landtype.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmb_landtype.Location = new System.Drawing.Point(765, 314);
			this.cmb_landtype.MaxDropDownItems = 17;
			this.cmb_landtype.MaxLength = 20;
			this.cmb_landtype.Name = "cmb_landtype";
			this.cmb_landtype.Size = new System.Drawing.Size(110, 21);
			this.cmb_landtype.TabIndex = 10;
			// 
			// cmb_documentstatus
			// 
			this.cmb_documentstatus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmb_documentstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_documentstatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.cmb_documentstatus.Location = new System.Drawing.Point(765, 360);
			this.cmb_documentstatus.MaxDropDownItems = 17;
			this.cmb_documentstatus.MaxLength = 20;
			this.cmb_documentstatus.Name = "cmb_documentstatus";
			this.cmb_documentstatus.Size = new System.Drawing.Size(110, 21);
			this.cmb_documentstatus.TabIndex = 11;
			// 
			// txt_ID
			// 
			this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_ID.Location = new System.Drawing.Point(765, 176);
			this.txt_ID.MaxLength = 9;
			this.txt_ID.Name = "txt_ID";
			this.txt_ID.Size = new System.Drawing.Size(110, 21);
			this.txt_ID.TabIndex = 7;
			this.txt_ID.Text = "";
			this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
			this.txt_ID.Enter += new System.EventHandler(this.txt_ID_Enter);
			// 
			// btn_insert
			// 
			this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_insert.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_insert.Location = new System.Drawing.Point(909, 592);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.TabIndex = 52;
			this.btn_insert.Text = "ÃœÌœ";
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_edit.Enabled = false;
			this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_edit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_edit.Location = new System.Drawing.Point(634, 592);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.TabIndex = 55;
			this.btn_edit.Text = "ÊÌ—«Ì‘";
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_erase
			// 
			this.btn_erase.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_erase.Enabled = false;
			this.btn_erase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_erase.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_erase.Location = new System.Drawing.Point(554, 592);
			this.btn_erase.Name = "btn_erase";
			this.btn_erase.TabIndex = 56;
			this.btn_erase.Text = "Õ–›";
			this.btn_erase.Click += new System.EventHandler(this.btn_erase_Click);
			// 
			// btn_save
			// 
			this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_save.Enabled = false;
			this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_save.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_save.Location = new System.Drawing.Point(829, 592);
			this.btn_save.Name = "btn_save";
			this.btn_save.TabIndex = 53;
			this.btn_save.Text = "–ŒÌ—Â";
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_cancel.Enabled = false;
			this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_cancel.Location = new System.Drawing.Point(749, 592);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.TabIndex = 54;
			this.btn_cancel.Text = "·€Ê";
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_find
			// 
			this.btn_find.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_find.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_find.Location = new System.Drawing.Point(170, 592);
			this.btn_find.Name = "btn_find";
			this.btn_find.TabIndex = 60;
			this.btn_find.Text = "Ã” ÃÊ";
			this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
			// 
			// btn_exchange
			// 
			this.btn_exchange.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_exchange.Enabled = false;
			this.btn_exchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_exchange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_exchange.Location = new System.Drawing.Point(450, 592);
			this.btn_exchange.Name = "btn_exchange";
			this.btn_exchange.TabIndex = 57;
			this.btn_exchange.Text = "„⁄«„·Â";
			this.btn_exchange.Click += new System.EventHandler(this.btn_exchange_Click);
			// 
			// btn_activate
			// 
			this.btn_activate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_activate.Enabled = false;
			this.btn_activate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_activate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_activate.Location = new System.Drawing.Point(370, 592);
			this.btn_activate.Name = "btn_activate";
			this.btn_activate.TabIndex = 58;
			this.btn_activate.Text = "›⁄«· ”«“Ì";
			this.btn_activate.Click += new System.EventHandler(this.btn_activate_Click);
			// 
			// btn_find_ID
			// 
			this.btn_find_ID.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_find_ID.Enabled = false;
			this.btn_find_ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_find_ID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_find_ID.Location = new System.Drawing.Point(40, 592);
			this.btn_find_ID.Name = "btn_find_ID";
			this.btn_find_ID.Size = new System.Drawing.Size(125, 23);
			this.btn_find_ID.TabIndex = 61;
			this.btn_find_ID.Text = "Ã” ÃÊ (‘„«—Â „·ﬂ)";
			this.btn_find_ID.Click += new System.EventHandler(this.btn_find_ID_Click);
			// 
			// tmr_sh_date
			// 
			this.tmr_sh_date.Enabled = true;
			this.tmr_sh_date.SynchronizingObject = this;
			this.tmr_sh_date.Elapsed += new System.Timers.ElapsedEventHandler(this.tmr_sh_date_Elapsed);
			// 
			// txt_Age_of_Builder
			// 
			this.txt_Age_of_Builder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Age_of_Builder.Enabled = false;
			this.txt_Age_of_Builder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Age_of_Builder.Increment = new System.Decimal(new int[] {
																				 3,
																				 0,
																				 0,
																				 0});
			this.txt_Age_of_Builder.Location = new System.Drawing.Point(310, 176);
			this.txt_Age_of_Builder.Maximum = new System.Decimal(new int[] {
																			   255,
																			   0,
																			   0,
																			   0});
			this.txt_Age_of_Builder.Name = "txt_Age_of_Builder";
			this.txt_Age_of_Builder.Size = new System.Drawing.Size(98, 21);
			this.txt_Age_of_Builder.TabIndex = 24;
			this.txt_Age_of_Builder.Enter += new System.EventHandler(this.txt_Age_of_Builder_Enter);
			this.txt_Age_of_Builder.Leave += new System.EventHandler(this.txt_Age_of_Builder_Leave);
			// 
			// txt_Quantity_of_Floors
			// 
			this.txt_Quantity_of_Floors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Quantity_of_Floors.Enabled = false;
			this.txt_Quantity_of_Floors.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Quantity_of_Floors.Location = new System.Drawing.Point(310, 230);
			this.txt_Quantity_of_Floors.Maximum = new System.Decimal(new int[] {
																				   255,
																				   0,
																				   0,
																				   0});
			this.txt_Quantity_of_Floors.Name = "txt_Quantity_of_Floors";
			this.txt_Quantity_of_Floors.Size = new System.Drawing.Size(98, 21);
			this.txt_Quantity_of_Floors.TabIndex = 27;
			this.txt_Quantity_of_Floors.Enter += new System.EventHandler(this.txt_Quantity_of_Floors_Enter);
			this.txt_Quantity_of_Floors.Leave += new System.EventHandler(this.txt_Quantity_of_Floors_Leave);
			// 
			// txt_Quantity_of_Units
			// 
			this.txt_Quantity_of_Units.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Quantity_of_Units.Enabled = false;
			this.txt_Quantity_of_Units.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Quantity_of_Units.Location = new System.Drawing.Point(310, 284);
			this.txt_Quantity_of_Units.Maximum = new System.Decimal(new int[] {
																				  255,
																				  0,
																				  0,
																				  0});
			this.txt_Quantity_of_Units.Name = "txt_Quantity_of_Units";
			this.txt_Quantity_of_Units.Size = new System.Drawing.Size(98, 21);
			this.txt_Quantity_of_Units.TabIndex = 30;
			this.txt_Quantity_of_Units.Enter += new System.EventHandler(this.txt_Quantity_of_Units_Enter);
			this.txt_Quantity_of_Units.Leave += new System.EventHandler(this.txt_Quantity_of_Units_Leave);
			// 
			// txt_Quantity_of_BedRoom
			// 
			this.txt_Quantity_of_BedRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Quantity_of_BedRoom.Enabled = false;
			this.txt_Quantity_of_BedRoom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Quantity_of_BedRoom.Location = new System.Drawing.Point(310, 338);
			this.txt_Quantity_of_BedRoom.Maximum = new System.Decimal(new int[] {
																					255,
																					0,
																					0,
																					0});
			this.txt_Quantity_of_BedRoom.Name = "txt_Quantity_of_BedRoom";
			this.txt_Quantity_of_BedRoom.Size = new System.Drawing.Size(98, 21);
			this.txt_Quantity_of_BedRoom.TabIndex = 33;
			this.txt_Quantity_of_BedRoom.Enter += new System.EventHandler(this.txt_Quantity_of_BedRoom_Enter);
			this.txt_Quantity_of_BedRoom.Leave += new System.EventHandler(this.txt_Quantity_of_BedRoom_Leave);
			// 
			// txt_Quantity_of_PhoneLine
			// 
			this.txt_Quantity_of_PhoneLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Quantity_of_PhoneLine.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Quantity_of_PhoneLine.Location = new System.Drawing.Point(67, 250);
			this.txt_Quantity_of_PhoneLine.Maximum = new System.Decimal(new int[] {
																					  255,
																					  0,
																					  0,
																					  0});
			this.txt_Quantity_of_PhoneLine.Name = "txt_Quantity_of_PhoneLine";
			this.txt_Quantity_of_PhoneLine.Size = new System.Drawing.Size(111, 21);
			this.txt_Quantity_of_PhoneLine.TabIndex = 38;
			this.txt_Quantity_of_PhoneLine.Enter += new System.EventHandler(this.txt_Quantity_of_PhoneLine_Enter);
			this.txt_Quantity_of_PhoneLine.Leave += new System.EventHandler(this.txt_Quantity_of_PhoneLine_Leave);
			// 
			// txt_Area_Builder_Base
			// 
			this.txt_Area_Builder_Base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Area_Builder_Base.Enabled = false;
			this.txt_Area_Builder_Base.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Area_Builder_Base.Increment = new System.Decimal(new int[] {
																					100,
																					0,
																					0,
																					0});
			this.txt_Area_Builder_Base.Location = new System.Drawing.Point(502, 230);
			this.txt_Area_Builder_Base.Maximum = new System.Decimal(new int[] {
																				  2147483647,
																				  0,
																				  0,
																				  0});
			this.txt_Area_Builder_Base.Name = "txt_Area_Builder_Base";
			this.txt_Area_Builder_Base.Size = new System.Drawing.Size(96, 21);
			this.txt_Area_Builder_Base.TabIndex = 15;
			this.txt_Area_Builder_Base.Enter += new System.EventHandler(this.txt_Area_Builder_Base_Enter);
			this.txt_Area_Builder_Base.Leave += new System.EventHandler(this.txt_Area_Builder_Base_Leave);
			// 
			// txt_Width_Away
			// 
			this.txt_Width_Away.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Width_Away.Enabled = false;
			this.txt_Width_Away.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Width_Away.Increment = new System.Decimal(new int[] {
																			 10,
																			 0,
																			 0,
																			 0});
			this.txt_Width_Away.Location = new System.Drawing.Point(502, 284);
			this.txt_Width_Away.Maximum = new System.Decimal(new int[] {
																		   32767,
																		   0,
																		   0,
																		   0});
			this.txt_Width_Away.Name = "txt_Width_Away";
			this.txt_Width_Away.Size = new System.Drawing.Size(96, 21);
			this.txt_Width_Away.TabIndex = 18;
			this.txt_Width_Away.Enter += new System.EventHandler(this.txt_Width_Away_Enter);
			this.txt_Width_Away.Leave += new System.EventHandler(this.txt_Width_Away_Leave);
			// 
			// txt_Depot_Meter
			// 
			this.txt_Depot_Meter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Depot_Meter.Enabled = false;
			this.txt_Depot_Meter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Depot_Meter.Increment = new System.Decimal(new int[] {
																			  10,
																			  0,
																			  0,
																			  0});
			this.txt_Depot_Meter.Location = new System.Drawing.Point(502, 338);
			this.txt_Depot_Meter.Maximum = new System.Decimal(new int[] {
																			32767,
																			0,
																			0,
																			0});
			this.txt_Depot_Meter.Name = "txt_Depot_Meter";
			this.txt_Depot_Meter.Size = new System.Drawing.Size(96, 21);
			this.txt_Depot_Meter.TabIndex = 21;
			this.txt_Depot_Meter.Enter += new System.EventHandler(this.txt_Depot_Meter_Enter);
			this.txt_Depot_Meter.Leave += new System.EventHandler(this.txt_Depot_Meter_Leave);
			// 
			// txt_Area_Total
			// 
			this.txt_Area_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Area_Total.Enabled = false;
			this.txt_Area_Total.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Area_Total.Increment = new System.Decimal(new int[] {
																			 100,
																			 0,
																			 0,
																			 0});
			this.txt_Area_Total.Location = new System.Drawing.Point(502, 176);
			this.txt_Area_Total.Maximum = new System.Decimal(new int[] {
																		   2147483647,
																		   0,
																		   0,
																		   0});
			this.txt_Area_Total.Name = "txt_Area_Total";
			this.txt_Area_Total.Size = new System.Drawing.Size(96, 21);
			this.txt_Area_Total.TabIndex = 12;
			this.txt_Area_Total.Enter += new System.EventHandler(this.txt_Area_Total_Enter);
			this.txt_Area_Total.Leave += new System.EventHandler(this.txt_Area_Total_Leave);
			// 
			// txt_Amount_of_Sale
			// 
			this.txt_Amount_of_Sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Amount_of_Sale.Enabled = false;
			this.txt_Amount_of_Sale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Amount_of_Sale.Increment = new System.Decimal(new int[] {
																				 10000000,
																				 0,
																				 0,
																				 0});
			this.txt_Amount_of_Sale.Location = new System.Drawing.Point(681, 515);
			this.txt_Amount_of_Sale.Maximum = new System.Decimal(new int[] {
																			   -1,
																			   -1,
																			   -1,
																			   0});
			this.txt_Amount_of_Sale.Name = "txt_Amount_of_Sale";
			this.txt_Amount_of_Sale.Size = new System.Drawing.Size(200, 21);
			this.txt_Amount_of_Sale.TabIndex = 43;
			this.txt_Amount_of_Sale.Enter += new System.EventHandler(this.txt_Amount_of_Sale_Enter);
			this.txt_Amount_of_Sale.Leave += new System.EventHandler(this.txt_Amount_of_Sale_Leave);
			// 
			// txt_Amount_of_Mortgage
			// 
			this.txt_Amount_of_Mortgage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Amount_of_Mortgage.Enabled = false;
			this.txt_Amount_of_Mortgage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Amount_of_Mortgage.Increment = new System.Decimal(new int[] {
																					 1000000,
																					 0,
																					 0,
																					 0});
			this.txt_Amount_of_Mortgage.Location = new System.Drawing.Point(375, 515);
			this.txt_Amount_of_Mortgage.Maximum = new System.Decimal(new int[] {
																				   2147483647,
																				   0,
																				   0,
																				   0});
			this.txt_Amount_of_Mortgage.Name = "txt_Amount_of_Mortgage";
			this.txt_Amount_of_Mortgage.Size = new System.Drawing.Size(200, 21);
			this.txt_Amount_of_Mortgage.TabIndex = 44;
			this.txt_Amount_of_Mortgage.Enter += new System.EventHandler(this.txt_Amount_of_Mortgage_Enter);
			this.txt_Amount_of_Mortgage.Leave += new System.EventHandler(this.txt_Amount_of_Mortgage_Leave);
			// 
			// txt_Amount_of_Rent
			// 
			this.txt_Amount_of_Rent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Amount_of_Rent.Enabled = false;
			this.txt_Amount_of_Rent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_Amount_of_Rent.Increment = new System.Decimal(new int[] {
																				 100000,
																				 0,
																				 0,
																				 0});
			this.txt_Amount_of_Rent.Location = new System.Drawing.Point(67, 515);
			this.txt_Amount_of_Rent.Maximum = new System.Decimal(new int[] {
																			   2147483647,
																			   0,
																			   0,
																			   0});
			this.txt_Amount_of_Rent.Name = "txt_Amount_of_Rent";
			this.txt_Amount_of_Rent.Size = new System.Drawing.Size(200, 21);
			this.txt_Amount_of_Rent.TabIndex = 45;
			this.txt_Amount_of_Rent.Enter += new System.EventHandler(this.txt_Amount_of_Rent_Enter);
			this.txt_Amount_of_Rent.Leave += new System.EventHandler(this.txt_Amount_of_Rent_Leave);
			// 
			// txt_to_Area_Total
			// 
			this.txt_to_Area_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Area_Total.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Area_Total.Increment = new System.Decimal(new int[] {
																				100,
																				0,
																				0,
																				0});
			this.txt_to_Area_Total.Location = new System.Drawing.Point(502, 200);
			this.txt_to_Area_Total.Maximum = new System.Decimal(new int[] {
																			  2147483647,
																			  0,
																			  0,
																			  0});
			this.txt_to_Area_Total.Name = "txt_to_Area_Total";
			this.txt_to_Area_Total.Size = new System.Drawing.Size(100, 21);
			this.txt_to_Area_Total.TabIndex = 14;
			this.txt_to_Area_Total.Enter += new System.EventHandler(this.txt_to_Area_Total_Enter);
			this.txt_to_Area_Total.ValueChanged += new System.EventHandler(this.txt_to_Area_Total_ValueChanged);
			this.txt_to_Area_Total.Leave += new System.EventHandler(this.txt_to_Area_Total_Leave);
			// 
			// txt_to_Area_Builder_Base
			// 
			this.txt_to_Area_Builder_Base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Area_Builder_Base.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Area_Builder_Base.Increment = new System.Decimal(new int[] {
																					   100,
																					   0,
																					   0,
																					   0});
			this.txt_to_Area_Builder_Base.Location = new System.Drawing.Point(502, 254);
			this.txt_to_Area_Builder_Base.Maximum = new System.Decimal(new int[] {
																					 2147483647,
																					 0,
																					 0,
																					 0});
			this.txt_to_Area_Builder_Base.Name = "txt_to_Area_Builder_Base";
			this.txt_to_Area_Builder_Base.Size = new System.Drawing.Size(100, 21);
			this.txt_to_Area_Builder_Base.TabIndex = 17;
			this.txt_to_Area_Builder_Base.Enter += new System.EventHandler(this.txt_to_Area_Builder_Base_Enter);
			this.txt_to_Area_Builder_Base.ValueChanged += new System.EventHandler(this.txt_to_Area_Builder_Base_ValueChanged);
			this.txt_to_Area_Builder_Base.Leave += new System.EventHandler(this.txt_to_Area_Builder_Base_Leave);
			// 
			// txt_to_Width_Away
			// 
			this.txt_to_Width_Away.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Width_Away.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Width_Away.Increment = new System.Decimal(new int[] {
																				10,
																				0,
																				0,
																				0});
			this.txt_to_Width_Away.Location = new System.Drawing.Point(502, 308);
			this.txt_to_Width_Away.Maximum = new System.Decimal(new int[] {
																			  32767,
																			  0,
																			  0,
																			  0});
			this.txt_to_Width_Away.Name = "txt_to_Width_Away";
			this.txt_to_Width_Away.Size = new System.Drawing.Size(100, 21);
			this.txt_to_Width_Away.TabIndex = 20;
			this.txt_to_Width_Away.Enter += new System.EventHandler(this.txt_to_Width_Away_Enter);
			this.txt_to_Width_Away.ValueChanged += new System.EventHandler(this.txt_to_Width_Away_ValueChanged);
			this.txt_to_Width_Away.Leave += new System.EventHandler(this.txt_to_Width_Away_Leave);
			// 
			// txt_to_Depot_Meter
			// 
			this.txt_to_Depot_Meter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Depot_Meter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Depot_Meter.Increment = new System.Decimal(new int[] {
																				 10,
																				 0,
																				 0,
																				 0});
			this.txt_to_Depot_Meter.Location = new System.Drawing.Point(502, 362);
			this.txt_to_Depot_Meter.Maximum = new System.Decimal(new int[] {
																			   32767,
																			   0,
																			   0,
																			   0});
			this.txt_to_Depot_Meter.Name = "txt_to_Depot_Meter";
			this.txt_to_Depot_Meter.Size = new System.Drawing.Size(100, 21);
			this.txt_to_Depot_Meter.TabIndex = 23;
			this.txt_to_Depot_Meter.Enter += new System.EventHandler(this.txt_to_Depot_Meter_Enter);
			this.txt_to_Depot_Meter.ValueChanged += new System.EventHandler(this.txt_to_Depot_Meter_ValueChanged);
			this.txt_to_Depot_Meter.Leave += new System.EventHandler(this.txt_to_Depot_Meter_Leave);
			// 
			// txt_from_Area_Total
			// 
			this.txt_from_Area_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Area_Total.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Area_Total.Increment = new System.Decimal(new int[] {
																				  100,
																				  0,
																				  0,
																				  0});
			this.txt_from_Area_Total.Location = new System.Drawing.Point(629, 200);
			this.txt_from_Area_Total.Maximum = new System.Decimal(new int[] {
																				2147483646,
																				0,
																				0,
																				0});
			this.txt_from_Area_Total.Name = "txt_from_Area_Total";
			this.txt_from_Area_Total.Size = new System.Drawing.Size(100, 21);
			this.txt_from_Area_Total.TabIndex = 13;
			this.txt_from_Area_Total.Enter += new System.EventHandler(this.txt_from_Area_Total_Enter);
			this.txt_from_Area_Total.ValueChanged += new System.EventHandler(this.txt_from_Area_Total_ValueChanged);
			this.txt_from_Area_Total.Leave += new System.EventHandler(this.txt_from_Area_Total_Leave);
			// 
			// txt_from_Area_Builder_Base
			// 
			this.txt_from_Area_Builder_Base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Area_Builder_Base.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Area_Builder_Base.Increment = new System.Decimal(new int[] {
																						 100,
																						 0,
																						 0,
																						 0});
			this.txt_from_Area_Builder_Base.Location = new System.Drawing.Point(629, 254);
			this.txt_from_Area_Builder_Base.Maximum = new System.Decimal(new int[] {
																					   2147483646,
																					   0,
																					   0,
																					   0});
			this.txt_from_Area_Builder_Base.Name = "txt_from_Area_Builder_Base";
			this.txt_from_Area_Builder_Base.Size = new System.Drawing.Size(100, 21);
			this.txt_from_Area_Builder_Base.TabIndex = 16;
			this.txt_from_Area_Builder_Base.Enter += new System.EventHandler(this.txt_from_Area_Builder_Base_Enter);
			this.txt_from_Area_Builder_Base.ValueChanged += new System.EventHandler(this.txt_from_Area_Builder_Base_ValueChanged);
			this.txt_from_Area_Builder_Base.Leave += new System.EventHandler(this.txt_from_Area_Builder_Base_Leave);
			// 
			// txt_from_Width_Away
			// 
			this.txt_from_Width_Away.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Width_Away.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Width_Away.Increment = new System.Decimal(new int[] {
																				  10,
																				  0,
																				  0,
																				  0});
			this.txt_from_Width_Away.Location = new System.Drawing.Point(629, 308);
			this.txt_from_Width_Away.Maximum = new System.Decimal(new int[] {
																				32766,
																				0,
																				0,
																				0});
			this.txt_from_Width_Away.Name = "txt_from_Width_Away";
			this.txt_from_Width_Away.Size = new System.Drawing.Size(100, 21);
			this.txt_from_Width_Away.TabIndex = 19;
			this.txt_from_Width_Away.Enter += new System.EventHandler(this.txt_from_Width_Away_Enter);
			this.txt_from_Width_Away.ValueChanged += new System.EventHandler(this.txt_from_Width_Away_ValueChanged);
			this.txt_from_Width_Away.Leave += new System.EventHandler(this.txt_from_Width_Away_Leave);
			// 
			// numericUpDown8
			// 
			this.numericUpDown8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown8.Increment = new System.Decimal(new int[] {
																			 100,
																			 0,
																			 0,
																			 0});
			this.numericUpDown8.Location = new System.Drawing.Point(632, 480);
			this.numericUpDown8.Maximum = new System.Decimal(new int[] {
																		   2147483647,
																		   0,
																		   0,
																		   0});
			this.numericUpDown8.Name = "numericUpDown8";
			this.numericUpDown8.Size = new System.Drawing.Size(100, 20);
			this.numericUpDown8.TabIndex = 88;
			// 
			// txt_from_Depot_Meter
			// 
			this.txt_from_Depot_Meter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Depot_Meter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Depot_Meter.Increment = new System.Decimal(new int[] {
																				   10,
																				   0,
																				   0,
																				   0});
			this.txt_from_Depot_Meter.Location = new System.Drawing.Point(629, 362);
			this.txt_from_Depot_Meter.Maximum = new System.Decimal(new int[] {
																				 32766,
																				 0,
																				 0,
																				 0});
			this.txt_from_Depot_Meter.Name = "txt_from_Depot_Meter";
			this.txt_from_Depot_Meter.Size = new System.Drawing.Size(100, 21);
			this.txt_from_Depot_Meter.TabIndex = 22;
			this.txt_from_Depot_Meter.Enter += new System.EventHandler(this.txt_from_Depot_Meter_Enter);
			this.txt_from_Depot_Meter.ValueChanged += new System.EventHandler(this.txt_from_Depot_Meter_ValueChanged);
			this.txt_from_Depot_Meter.Leave += new System.EventHandler(this.txt_from_Depot_Meter_Leave);
			// 
			// txt_to_Amount_of_Sale
			// 
			this.txt_to_Amount_of_Sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Amount_of_Sale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Amount_of_Sale.Increment = new System.Decimal(new int[] {
																					10000000,
																					0,
																					0,
																					0});
			this.txt_to_Amount_of_Sale.Location = new System.Drawing.Point(681, 539);
			this.txt_to_Amount_of_Sale.Maximum = new System.Decimal(new int[] {
																				  -1,
																				  -1,
																				  -1,
																				  0});
			this.txt_to_Amount_of_Sale.Name = "txt_to_Amount_of_Sale";
			this.txt_to_Amount_of_Sale.Size = new System.Drawing.Size(115, 21);
			this.txt_to_Amount_of_Sale.TabIndex = 47;
			this.txt_to_Amount_of_Sale.Enter += new System.EventHandler(this.txt_to_Amount_of_Sale_Enter);
			this.txt_to_Amount_of_Sale.ValueChanged += new System.EventHandler(this.txt_to_Amount_of_Sale_ValueChanged);
			this.txt_to_Amount_of_Sale.Leave += new System.EventHandler(this.txt_to_Amount_of_Sale_Leave);
			// 
			// txt_from_Amount_of_Sale
			// 
			this.txt_from_Amount_of_Sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Amount_of_Sale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Amount_of_Sale.Increment = new System.Decimal(new int[] {
																					  10000000,
																					  0,
																					  0,
																					  0});
			this.txt_from_Amount_of_Sale.Location = new System.Drawing.Point(823, 539);
			this.txt_from_Amount_of_Sale.Maximum = new System.Decimal(new int[] {
																					-2,
																					-1,
																					-1,
																					0});
			this.txt_from_Amount_of_Sale.Name = "txt_from_Amount_of_Sale";
			this.txt_from_Amount_of_Sale.Size = new System.Drawing.Size(115, 21);
			this.txt_from_Amount_of_Sale.TabIndex = 46;
			this.txt_from_Amount_of_Sale.Enter += new System.EventHandler(this.txt_from_Amount_of_Sale_Enter);
			this.txt_from_Amount_of_Sale.ValueChanged += new System.EventHandler(this.txt_from_Amount_of_Sale_ValueChanged);
			this.txt_from_Amount_of_Sale.Leave += new System.EventHandler(this.txt_from_Amount_of_Sale_Leave);
			// 
			// txt_to_Amount_of_Mortgage
			// 
			this.txt_to_Amount_of_Mortgage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Amount_of_Mortgage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Amount_of_Mortgage.Increment = new System.Decimal(new int[] {
																						1000000,
																						0,
																						0,
																						0});
			this.txt_to_Amount_of_Mortgage.Location = new System.Drawing.Point(375, 539);
			this.txt_to_Amount_of_Mortgage.Maximum = new System.Decimal(new int[] {
																					  2147483647,
																					  0,
																					  0,
																					  0});
			this.txt_to_Amount_of_Mortgage.Name = "txt_to_Amount_of_Mortgage";
			this.txt_to_Amount_of_Mortgage.Size = new System.Drawing.Size(115, 21);
			this.txt_to_Amount_of_Mortgage.TabIndex = 49;
			this.txt_to_Amount_of_Mortgage.Enter += new System.EventHandler(this.txt_to_Amount_of_Mortgage_Enter);
			this.txt_to_Amount_of_Mortgage.ValueChanged += new System.EventHandler(this.txt_to_Amount_of_Mortgage_ValueChanged);
			this.txt_to_Amount_of_Mortgage.Leave += new System.EventHandler(this.txt_to_Amount_of_Mortgage_Leave);
			// 
			// txt_from_Amount_of_Mortgage
			// 
			this.txt_from_Amount_of_Mortgage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Amount_of_Mortgage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Amount_of_Mortgage.Increment = new System.Decimal(new int[] {
																						  1000000,
																						  0,
																						  0,
																						  0});
			this.txt_from_Amount_of_Mortgage.Location = new System.Drawing.Point(512, 539);
			this.txt_from_Amount_of_Mortgage.Maximum = new System.Decimal(new int[] {
																						2147483646,
																						0,
																						0,
																						0});
			this.txt_from_Amount_of_Mortgage.Name = "txt_from_Amount_of_Mortgage";
			this.txt_from_Amount_of_Mortgage.Size = new System.Drawing.Size(115, 21);
			this.txt_from_Amount_of_Mortgage.TabIndex = 48;
			this.txt_from_Amount_of_Mortgage.Enter += new System.EventHandler(this.txt_from_Amount_of_Mortgage_Enter);
			this.txt_from_Amount_of_Mortgage.ValueChanged += new System.EventHandler(this.txt_from_Amount_of_Mortgage_ValueChanged);
			this.txt_from_Amount_of_Mortgage.Leave += new System.EventHandler(this.txt_from_Amount_of_Mortgage_Leave);
			// 
			// txt_to_Amount_of_Rent
			// 
			this.txt_to_Amount_of_Rent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Amount_of_Rent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Amount_of_Rent.Increment = new System.Decimal(new int[] {
																					100000,
																					0,
																					0,
																					0});
			this.txt_to_Amount_of_Rent.Location = new System.Drawing.Point(67, 539);
			this.txt_to_Amount_of_Rent.Maximum = new System.Decimal(new int[] {
																				  2147483647,
																				  0,
																				  0,
																				  0});
			this.txt_to_Amount_of_Rent.Name = "txt_to_Amount_of_Rent";
			this.txt_to_Amount_of_Rent.Size = new System.Drawing.Size(115, 21);
			this.txt_to_Amount_of_Rent.TabIndex = 51;
			this.txt_to_Amount_of_Rent.Enter += new System.EventHandler(this.txt_to_Amount_of_Rent_Enter);
			this.txt_to_Amount_of_Rent.ValueChanged += new System.EventHandler(this.txt_to_Amount_of_Rent_ValueChanged);
			this.txt_to_Amount_of_Rent.Leave += new System.EventHandler(this.txt_to_Amount_of_Rent_Leave);
			// 
			// txt_from_Amount_of_Rent
			// 
			this.txt_from_Amount_of_Rent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Amount_of_Rent.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Amount_of_Rent.Increment = new System.Decimal(new int[] {
																					  100000,
																					  0,
																					  0,
																					  0});
			this.txt_from_Amount_of_Rent.Location = new System.Drawing.Point(205, 539);
			this.txt_from_Amount_of_Rent.Maximum = new System.Decimal(new int[] {
																					2147483646,
																					0,
																					0,
																					0});
			this.txt_from_Amount_of_Rent.Name = "txt_from_Amount_of_Rent";
			this.txt_from_Amount_of_Rent.Size = new System.Drawing.Size(115, 21);
			this.txt_from_Amount_of_Rent.TabIndex = 50;
			this.txt_from_Amount_of_Rent.Enter += new System.EventHandler(this.txt_from_Amount_of_Rent_Enter);
			this.txt_from_Amount_of_Rent.ValueChanged += new System.EventHandler(this.txt_from_Amount_of_Rent_ValueChanged);
			this.txt_from_Amount_of_Rent.Leave += new System.EventHandler(this.txt_from_Amount_of_Rent_Leave);
			// 
			// txt_to_Age_of_Builder
			// 
			this.txt_to_Age_of_Builder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Age_of_Builder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Age_of_Builder.Increment = new System.Decimal(new int[] {
																					3,
																					0,
																					0,
																					0});
			this.txt_to_Age_of_Builder.Location = new System.Drawing.Point(310, 200);
			this.txt_to_Age_of_Builder.Maximum = new System.Decimal(new int[] {
																				  255,
																				  0,
																				  0,
																				  0});
			this.txt_to_Age_of_Builder.Name = "txt_to_Age_of_Builder";
			this.txt_to_Age_of_Builder.Size = new System.Drawing.Size(65, 21);
			this.txt_to_Age_of_Builder.TabIndex = 26;
			this.txt_to_Age_of_Builder.Enter += new System.EventHandler(this.txt_to_Age_of_Builder_Enter);
			this.txt_to_Age_of_Builder.ValueChanged += new System.EventHandler(this.txt_to_Age_of_Builder_ValueChanged);
			this.txt_to_Age_of_Builder.Leave += new System.EventHandler(this.txt_to_Age_of_Builder_Leave);
			// 
			// txt_from_Age_of_Builder
			// 
			this.txt_from_Age_of_Builder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Age_of_Builder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Age_of_Builder.Increment = new System.Decimal(new int[] {
																					  3,
																					  0,
																					  0,
																					  0});
			this.txt_from_Age_of_Builder.Location = new System.Drawing.Point(401, 200);
			this.txt_from_Age_of_Builder.Maximum = new System.Decimal(new int[] {
																					254,
																					0,
																					0,
																					0});
			this.txt_from_Age_of_Builder.Name = "txt_from_Age_of_Builder";
			this.txt_from_Age_of_Builder.Size = new System.Drawing.Size(65, 21);
			this.txt_from_Age_of_Builder.TabIndex = 25;
			this.txt_from_Age_of_Builder.Enter += new System.EventHandler(this.txt_from_Age_of_Builder_Enter);
			this.txt_from_Age_of_Builder.ValueChanged += new System.EventHandler(this.txt_from_Age_of_Builder_ValueChanged);
			this.txt_from_Age_of_Builder.Leave += new System.EventHandler(this.txt_from_Age_of_Builder_Leave);
			// 
			// txt_to_Quantity_of_Floors
			// 
			this.txt_to_Quantity_of_Floors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Quantity_of_Floors.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Quantity_of_Floors.Location = new System.Drawing.Point(310, 254);
			this.txt_to_Quantity_of_Floors.Maximum = new System.Decimal(new int[] {
																					  255,
																					  0,
																					  0,
																					  0});
			this.txt_to_Quantity_of_Floors.Name = "txt_to_Quantity_of_Floors";
			this.txt_to_Quantity_of_Floors.Size = new System.Drawing.Size(65, 21);
			this.txt_to_Quantity_of_Floors.TabIndex = 29;
			this.txt_to_Quantity_of_Floors.Enter += new System.EventHandler(this.txt_to_Quantity_of_Floors_Enter);
			this.txt_to_Quantity_of_Floors.ValueChanged += new System.EventHandler(this.txt_to_Quantity_of_Floors_ValueChanged);
			this.txt_to_Quantity_of_Floors.Leave += new System.EventHandler(this.txt_to_Quantity_of_Floors_Leave);
			// 
			// txt_to_Quantity_of_Units
			// 
			this.txt_to_Quantity_of_Units.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Quantity_of_Units.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Quantity_of_Units.Location = new System.Drawing.Point(310, 308);
			this.txt_to_Quantity_of_Units.Maximum = new System.Decimal(new int[] {
																					 255,
																					 0,
																					 0,
																					 0});
			this.txt_to_Quantity_of_Units.Name = "txt_to_Quantity_of_Units";
			this.txt_to_Quantity_of_Units.Size = new System.Drawing.Size(65, 21);
			this.txt_to_Quantity_of_Units.TabIndex = 32;
			this.txt_to_Quantity_of_Units.Enter += new System.EventHandler(this.txt_to_Quantity_of_Units_Enter);
			this.txt_to_Quantity_of_Units.ValueChanged += new System.EventHandler(this.txt_to_Quantity_of_Units_ValueChanged);
			this.txt_to_Quantity_of_Units.Leave += new System.EventHandler(this.txt_to_Quantity_of_Units_Leave);
			// 
			// txt_to_Quantity_of_BedRoom
			// 
			this.txt_to_Quantity_of_BedRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_to_Quantity_of_BedRoom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_to_Quantity_of_BedRoom.Location = new System.Drawing.Point(310, 362);
			this.txt_to_Quantity_of_BedRoom.Maximum = new System.Decimal(new int[] {
																					   255,
																					   0,
																					   0,
																					   0});
			this.txt_to_Quantity_of_BedRoom.Name = "txt_to_Quantity_of_BedRoom";
			this.txt_to_Quantity_of_BedRoom.Size = new System.Drawing.Size(65, 21);
			this.txt_to_Quantity_of_BedRoom.TabIndex = 35;
			this.txt_to_Quantity_of_BedRoom.Enter += new System.EventHandler(this.txt_to_Quantity_of_BedRoom_Enter);
			this.txt_to_Quantity_of_BedRoom.ValueChanged += new System.EventHandler(this.txt_to_Quantity_of_BedRoom_ValueChanged);
			this.txt_to_Quantity_of_BedRoom.Leave += new System.EventHandler(this.txt_to_Quantity_of_BedRoom_Leave);
			// 
			// txt_from_Quantity_of_Floors
			// 
			this.txt_from_Quantity_of_Floors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Quantity_of_Floors.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Quantity_of_Floors.Location = new System.Drawing.Point(401, 254);
			this.txt_from_Quantity_of_Floors.Maximum = new System.Decimal(new int[] {
																						254,
																						0,
																						0,
																						0});
			this.txt_from_Quantity_of_Floors.Name = "txt_from_Quantity_of_Floors";
			this.txt_from_Quantity_of_Floors.Size = new System.Drawing.Size(65, 21);
			this.txt_from_Quantity_of_Floors.TabIndex = 28;
			this.txt_from_Quantity_of_Floors.Enter += new System.EventHandler(this.txt_from_Quantity_of_Floors_Enter);
			this.txt_from_Quantity_of_Floors.ValueChanged += new System.EventHandler(this.txt_from_Quantity_of_Floors_ValueChanged);
			this.txt_from_Quantity_of_Floors.Leave += new System.EventHandler(this.txt_from_Quantity_of_Floors_Leave);
			// 
			// txt_from_Quantity_of_Units
			// 
			this.txt_from_Quantity_of_Units.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Quantity_of_Units.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Quantity_of_Units.Location = new System.Drawing.Point(401, 308);
			this.txt_from_Quantity_of_Units.Maximum = new System.Decimal(new int[] {
																					   254,
																					   0,
																					   0,
																					   0});
			this.txt_from_Quantity_of_Units.Name = "txt_from_Quantity_of_Units";
			this.txt_from_Quantity_of_Units.Size = new System.Drawing.Size(65, 21);
			this.txt_from_Quantity_of_Units.TabIndex = 31;
			this.txt_from_Quantity_of_Units.Enter += new System.EventHandler(this.txt_from_Quantity_of_Units_Enter);
			this.txt_from_Quantity_of_Units.ValueChanged += new System.EventHandler(this.txt_from_Quantity_of_Units_ValueChanged);
			this.txt_from_Quantity_of_Units.Leave += new System.EventHandler(this.txt_from_Quantity_of_Units_Leave);
			// 
			// txt_from_Quantity_of_BedRoom
			// 
			this.txt_from_Quantity_of_BedRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_from_Quantity_of_BedRoom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.txt_from_Quantity_of_BedRoom.Location = new System.Drawing.Point(401, 362);
			this.txt_from_Quantity_of_BedRoom.Maximum = new System.Decimal(new int[] {
																						 254,
																						 0,
																						 0,
																						 0});
			this.txt_from_Quantity_of_BedRoom.Name = "txt_from_Quantity_of_BedRoom";
			this.txt_from_Quantity_of_BedRoom.Size = new System.Drawing.Size(65, 21);
			this.txt_from_Quantity_of_BedRoom.TabIndex = 34;
			this.txt_from_Quantity_of_BedRoom.Enter += new System.EventHandler(this.txt_from_Quantity_of_BedRoom_Enter);
			this.txt_from_Quantity_of_BedRoom.ValueChanged += new System.EventHandler(this.txt_from_Quantity_of_BedRoom_ValueChanged);
			this.txt_from_Quantity_of_BedRoom.Leave += new System.EventHandler(this.txt_from_Quantity_of_BedRoom_Leave);
			// 
			// btn_ClearPage
			// 
			this.btn_ClearPage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_ClearPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_ClearPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_ClearPage.Location = new System.Drawing.Point(250, 592);
			this.btn_ClearPage.Name = "btn_ClearPage";
			this.btn_ClearPage.TabIndex = 59;
			this.btn_ClearPage.Text = "’›ÕÂ Œ«·Ì";
			this.btn_ClearPage.Click += new System.EventHandler(this.btn_ClearPage_Click);
			// 
			// frm_land
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.ContextMenu = this.mnu_ctx_notify;
			this.ControlBox = false;
			this.Controls.Add(this.btn_ClearPage);
			this.Controls.Add(this.txt_from_Quantity_of_BedRoom);
			this.Controls.Add(this.txt_from_Quantity_of_Units);
			this.Controls.Add(this.txt_from_Quantity_of_Floors);
			this.Controls.Add(this.txt_to_Quantity_of_BedRoom);
			this.Controls.Add(this.txt_to_Quantity_of_Units);
			this.Controls.Add(this.txt_to_Quantity_of_Floors);
			this.Controls.Add(this.txt_from_Age_of_Builder);
			this.Controls.Add(this.txt_to_Age_of_Builder);
			this.Controls.Add(this.txt_from_Amount_of_Rent);
			this.Controls.Add(this.txt_to_Amount_of_Rent);
			this.Controls.Add(this.txt_from_Amount_of_Mortgage);
			this.Controls.Add(this.txt_to_Amount_of_Mortgage);
			this.Controls.Add(this.txt_from_Amount_of_Sale);
			this.Controls.Add(this.txt_to_Amount_of_Sale);
			this.Controls.Add(this.txt_from_Depot_Meter);
			this.Controls.Add(this.txt_from_Width_Away);
			this.Controls.Add(this.txt_from_Area_Builder_Base);
			this.Controls.Add(this.txt_from_Area_Total);
			this.Controls.Add(this.txt_to_Depot_Meter);
			this.Controls.Add(this.txt_to_Width_Away);
			this.Controls.Add(this.txt_to_Area_Builder_Base);
			this.Controls.Add(this.txt_to_Area_Total);
			this.Controls.Add(this.txt_Amount_of_Rent);
			this.Controls.Add(this.txt_Amount_of_Mortgage);
			this.Controls.Add(this.txt_Amount_of_Sale);
			this.Controls.Add(this.txt_Area_Total);
			this.Controls.Add(this.txt_Depot_Meter);
			this.Controls.Add(this.txt_Width_Away);
			this.Controls.Add(this.txt_Area_Builder_Base);
			this.Controls.Add(this.txt_Quantity_of_PhoneLine);
			this.Controls.Add(this.txt_Quantity_of_BedRoom);
			this.Controls.Add(this.txt_Quantity_of_Units);
			this.Controls.Add(this.txt_Quantity_of_Floors);
			this.Controls.Add(this.txt_Age_of_Builder);
			this.Controls.Add(this.btn_find_ID);
			this.Controls.Add(this.btn_activate);
			this.Controls.Add(this.btn_exchange);
			this.Controls.Add(this.btn_find);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_erase);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.txt_ID);
			this.Controls.Add(this.txt_Date);
			this.Controls.Add(this.txt_Address);
			this.Controls.Add(this.txt_Introducer);
			this.Controls.Add(this.txt_Mobile);
			this.Controls.Add(this.txt_Tel);
			this.Controls.Add(this.txt_Introducer_Tel);
			this.Controls.Add(this.txt_LandLord);
			this.Controls.Add(this.cmb_documentstatus);
			this.Controls.Add(this.cmb_landtype);
			this.Controls.Add(this.cmb_agreementtype);
			this.Controls.Add(this.cmb_zone);
			this.Controls.Add(this.dg_Master);
			this.Controls.Add(this.cmb_coldsystem);
			this.Controls.Add(this.cmb_warmsystem);
			this.Controls.Add(this.cmb_kitchentype);
			this.Controls.Add(this.cmb_geographysituation);
			this.Controls.Add(this.cmb_facing);
			this.Controls.Add(this.gui_land);
			this.Controls.Add(this.msbg_sd1);
			this.Controls.Add(this.numericUpDown8);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_land";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frm_land_Closing);
			this.Load += new System.EventHandler(this.frm_land_Load);
			((System.ComponentModel.ISupportInitialize)(this.gui_land)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg_Master)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tmr_sh_date)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Age_of_Builder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Quantity_of_Floors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Quantity_of_Units)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Quantity_of_BedRoom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Quantity_of_PhoneLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Area_Builder_Base)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Width_Away)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Depot_Meter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Area_Total)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Amount_of_Sale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Amount_of_Mortgage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_Amount_of_Rent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Area_Total)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Area_Builder_Base)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Width_Away)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Depot_Meter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Area_Total)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Area_Builder_Base)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Width_Away)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Depot_Meter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Amount_of_Sale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Amount_of_Sale)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Amount_of_Mortgage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Amount_of_Mortgage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Amount_of_Rent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Amount_of_Rent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Age_of_Builder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Age_of_Builder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Quantity_of_Floors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Quantity_of_Units)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_to_Quantity_of_BedRoom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Quantity_of_Floors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Quantity_of_Units)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txt_from_Quantity_of_BedRoom)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public OleDbConnection cnn = new OleDbConnection(String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM master", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public DataSet ds = new DataSet();
		public DataTable dt = new DataTable();
		public string Real_ID;

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

		void drr_cmbs(ComboBox cmb_f_cs, string parm, OleDbConnection cnn_f_cs)
		{
			OleDbCommand cmd_f_cs = new OleDbCommand(String.Concat("SELECT * FROM bd_", parm), cnn_f_cs);
			OleDbDataReader drr_f_cs = cmd_f_cs.ExecuteReader();
			while (drr_f_cs.Read())
			{
				cmb_f_cs.Items.Add(drr_f_cs[parm]);
			}
			cmd_f_cs.Dispose();
			cmd_f_cs = null;
			drr_f_cs.Close();
			drr_f_cs = null;
		}

		void fill_cmbs()
		{
			OleDbConnection cnn_f_cs = new OleDbConnection(String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda_zone = new OleDbDataAdapter("SELECT * FROM bd_zone", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda_agreementtype = new OleDbDataAdapter("SELECT * FROM bd_agreementtype", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda_landtype = new OleDbDataAdapter("SELECT * FROM bd_landtype", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda_documentstatus = new OleDbDataAdapter("SELECT * FROM bd_documentstatus", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda_facing = new OleDbDataAdapter("SELECT * FROM bd_facing", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda_geographysituation = new OleDbDataAdapter("SELECT * FROM bd_geographysituation", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda_kitchentype = new OleDbDataAdapter("SELECT * FROM bd_kitchentype", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda_warmsystem = new OleDbDataAdapter("SELECT * FROM bd_warmsystem", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			OleDbDataAdapter oda_coldsystem = new OleDbDataAdapter("SELECT * FROM bd_coldsystem", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			DataSet ds_zone = new DataSet();
			DataSet ds_agreementtype = new DataSet();
			DataSet ds_landtype = new DataSet();
			DataSet ds_documentstatus = new DataSet();
			DataSet ds_facing = new DataSet();
			DataSet ds_geographysituation = new DataSet();
			DataSet ds_kitchentype = new DataSet();
			DataSet ds_warmsystem = new DataSet();
			DataSet ds_coldsystem = new DataSet();

			cnn_f_cs.Open();

			drr_cmbs(cmb_zone ,"zone", cnn_f_cs);
			drr_cmbs(cmb_agreementtype ,"agreementtype", cnn_f_cs);
			drr_cmbs(cmb_landtype ,"landtype", cnn_f_cs);
			drr_cmbs(cmb_documentstatus ,"documentstatus", cnn_f_cs);
			drr_cmbs(cmb_facing ,"facing", cnn_f_cs);
			drr_cmbs(cmb_geographysituation ,"geographysituation", cnn_f_cs);
			drr_cmbs(cmb_kitchentype ,"kitchentype", cnn_f_cs);
			drr_cmbs(cmb_warmsystem ,"warmsystem", cnn_f_cs);
			drr_cmbs(cmb_coldsystem ,"coldsystem", cnn_f_cs);

			cnn_f_cs.Close();
			cnn_f_cs.Dispose();
			cnn_f_cs = null;
		}

		void chk_unchk_chk(string chk_status)
		{
			gui_land.SetVariable("_root.bool_crane.selected", chk_status);
			gui_land.SetVariable("_root.bool_exchange.selected", chk_status);
			gui_land.SetVariable("_root.bool_gas.selected", chk_status);
			gui_land.SetVariable("_root.bool_parking.selected", chk_status);
			gui_land.SetVariable("_root.bool_depot.selected", chk_status);
			gui_land.SetVariable("_root.bool_cabinet.selected", chk_status);
			gui_land.SetVariable("_root.bool_basement.selected", chk_status);
			gui_land.SetVariable("_root.bool_back-yard.selected", chk_status);
			gui_land.SetVariable("_root.bool_elevator.selected", chk_status);
			gui_land.SetVariable("_root.bool_Mocket.selected", chk_status);
			gui_land.SetVariable("_root.bool_v_i_phone.selected", chk_status);
			gui_land.SetVariable("_root.bool_central_anthena.selected", chk_status);
			gui_land.SetVariable("_root.bool_screen.selected", chk_status);
			gui_land.SetVariable("_root.bool_lustre.selected", chk_status);
		}
		
		void Clear_Values()
		{
			chk_unchk_chk("");

			cmb_zone.SelectedIndex = -1;
			cmb_agreementtype.SelectedIndex = -1;
			cmb_landtype.SelectedIndex = -1;
			cmb_documentstatus.SelectedIndex = -1;
			cmb_facing.SelectedIndex = -1;
			cmb_geographysituation.SelectedIndex = -1;
			cmb_kitchentype.SelectedIndex = -1;
			cmb_warmsystem.SelectedIndex = -1;
			cmb_coldsystem.SelectedIndex = -1;
		
			txt_LandLord.Clear();
			txt_Tel.Clear();
			txt_Mobile.Clear();
			txt_Introducer.Clear();
			txt_Introducer_Tel.Clear();
			txt_Address.Clear();
			txt_Date.Clear();
			txt_ID.Clear();
			txt_Area_Total.Value = 0;
			txt_from_Area_Total.Value = 0;
			txt_to_Area_Total.Value = 0;
			txt_Area_Builder_Base.Value = 0;
			txt_from_Area_Builder_Base.Value = 0;
			txt_to_Area_Builder_Base.Value = 0;
			txt_Width_Away.Value = 0;
			txt_from_Width_Away.Value = 0;
			txt_to_Width_Away.Value = 0;
			txt_Depot_Meter.Value = 0;
			txt_from_Depot_Meter.Value = 0;
			txt_to_Depot_Meter.Value = 0;
			txt_Age_of_Builder.Value = 0;
			txt_from_Age_of_Builder.Value = 0;
			txt_to_Age_of_Builder.Value = 0;
			txt_Quantity_of_Floors.Value = 0;
			txt_from_Quantity_of_Floors.Value = 0;
			txt_to_Quantity_of_Floors.Value = 0;
			txt_Quantity_of_Units.Value = 0;
			txt_from_Quantity_of_Units.Value = 0;
			txt_to_Quantity_of_Units.Value = 0;
			txt_Quantity_of_BedRoom.Value = 0;
			txt_from_Quantity_of_BedRoom.Value = 0;
			txt_to_Quantity_of_BedRoom.Value = 0;
			txt_Quantity_of_PhoneLine.Value = 0;
			txt_Amount_of_Sale.Value = 0;
			txt_from_Amount_of_Sale.Value = 0;
			txt_to_Amount_of_Sale.Value = 0;
			txt_Amount_of_Mortgage.Value = 0;
			txt_from_Amount_of_Mortgage.Value = 0;
			txt_to_Amount_of_Mortgage.Value = 0;
			txt_Amount_of_Rent.Value = 0;
			txt_from_Amount_of_Rent.Value = 0;
			txt_to_Amount_of_Rent.Value = 0;
		}

		void en_dis(bool status)
		{
			bool status2 = status == true ? false : true;
			txt_Area_Total.Enabled = status;
			txt_from_Area_Total.Enabled = status2;
			txt_to_Area_Total.Enabled = status2;
			txt_Area_Builder_Base.Enabled = status;
			txt_from_Area_Builder_Base.Enabled = status2;
			txt_to_Area_Builder_Base.Enabled = status2;
			txt_Width_Away.Enabled = status;
			txt_from_Width_Away.Enabled = status2;
			txt_to_Width_Away.Enabled = status2;
			txt_Depot_Meter.Enabled = status;
			txt_from_Depot_Meter.Enabled = status2;
			txt_to_Depot_Meter.Enabled = status2;
			txt_Age_of_Builder.Enabled = status;
			txt_from_Age_of_Builder.Enabled = status2;
			txt_to_Age_of_Builder.Enabled = status2;
			txt_Quantity_of_Floors.Enabled = status;
			txt_from_Quantity_of_Floors.Enabled = status2;
			txt_to_Quantity_of_Floors.Enabled = status2;
			txt_Quantity_of_Units.Enabled = status;
			txt_from_Quantity_of_Units.Enabled = status2;
			txt_to_Quantity_of_Units.Enabled = status2;
			txt_Quantity_of_BedRoom.Enabled = status;
			txt_from_Quantity_of_BedRoom.Enabled = status2;
			txt_to_Quantity_of_BedRoom.Enabled = status2;
			txt_Amount_of_Sale.Enabled = status;
			txt_from_Amount_of_Sale.Enabled = status2;
			txt_to_Amount_of_Sale.Enabled = status2;
			txt_Amount_of_Mortgage.Enabled = status;
			txt_from_Amount_of_Mortgage.Enabled = status2;
			txt_to_Amount_of_Mortgage.Enabled = status2;
			txt_Amount_of_Rent.Enabled = status;
			txt_from_Amount_of_Rent.Enabled = status2;
			txt_to_Amount_of_Rent.Enabled = status2;
		}

		void save(DataRow dr)
		{
			dr["LandLord"] = txt_LandLord.Text.Trim();
			dr["Tel"] = txt_Tel.Text.Trim();
			dr["Mobile"] = txt_Mobile.Text.Trim();
			dr["Introducer"] = txt_Introducer.Text.Trim();
			dr["Introducer_Tel"] = txt_Introducer_Tel.Text.Trim();
			dr["Address"] = txt_Address.Text.Trim();
			dr["Date"] = txt_Date.Text.Trim();
			dr["Zone"] = cmb_zone.Text.Trim();
			dr["AgreementType"] = cmb_agreementtype.Text.Trim();
			dr["LandType"] = cmb_landtype.Text.Trim();
			dr["DocumentStatus"] = cmb_documentstatus.Text.Trim();
			dr["Area_Total"] = Convert.ToInt32(txt_Area_Total.Value);
			dr["Area_Builder_Base"] = Convert.ToInt32(txt_Area_Builder_Base.Value);
			dr["Width_Away"] = Convert.ToInt16(txt_Width_Away.Value);
			dr["Depot_Meter"] = Convert.ToInt16(txt_Depot_Meter.Value);
			dr["Age_of_Builder"] = Convert.ToByte(txt_Age_of_Builder.Value);
			dr["Quantity_of_Floors"] = Convert.ToByte(txt_Quantity_of_Floors.Value);
			dr["Quantity_of_Units"] = Convert.ToByte(txt_Quantity_of_Units.Value);
			dr["Quantity_of_BedRoom"] = Convert.ToByte(txt_Quantity_of_BedRoom.Value);
			dr["Facing"] = cmb_facing.Text.Trim();
			dr["geographysituation"] = cmb_geographysituation.Text.Trim();
			dr["Quantity_of_PhoneLine"] = Convert.ToByte(txt_Quantity_of_PhoneLine.Value);
			dr["kitchentype"] = cmb_kitchentype.Text.Trim();
			dr["warmsystem"] = cmb_warmsystem.Text.Trim();
			dr["coldsystem"] = cmb_coldsystem.Text.Trim();
			dr["bool_crane"] = gui_land.GetVariable("_root.bool_crane.selected") == "true" ? true : false;
			dr["bool_exchange"] = gui_land.GetVariable("_root.bool_exchange.selected") == "true" ? true : false;
			dr["bool_gas"] = gui_land.GetVariable("_root.bool_gas.selected") == "true" ? true : false;
			dr["bool_parking"] = gui_land.GetVariable("_root.bool_parking.selected") == "true" ? true : false;
			dr["bool_depot"] = gui_land.GetVariable("_root.bool_depot.selected") == "true" ? true : false;
			dr["bool_cabinet"] = gui_land.GetVariable("_root.bool_cabinet.selected") == "true" ? true : false;
			dr["bool_basement"] = gui_land.GetVariable("_root.bool_basement.selected") == "true" ? true : false;
			dr["bool_back-yard"] = gui_land.GetVariable("_root.bool_back-yard.selected") == "true" ? true : false;
			dr["bool_elevator"] = gui_land.GetVariable("_root.bool_elevator.selected") == "true" ? true : false;
			dr["bool_Mocket"] = gui_land.GetVariable("_root.bool_Mocket.selected") == "true" ? true : false;
			dr["bool_v_i_phone"] = gui_land.GetVariable("_root.bool_v_i_phone.selected") == "true" ? true : false;
			dr["bool_central_anthena"] = gui_land.GetVariable("_root.bool_central_anthena.selected") == "true" ? true : false;
			dr["bool_screen"] = gui_land.GetVariable("_root.bool_screen.selected") == "true" ? true : false;
			dr["bool_lustre"] = gui_land.GetVariable("_root.bool_lustre.selected") == "true" ? true : false;
			dr["Amount_of_Sale"] = Convert.ToDecimal(txt_Amount_of_Sale.Value);
			dr["Amount_of_Mortgage"] = Convert.ToInt32(txt_Amount_of_Mortgage.Value);
			dr["Amount_of_Rent"] = Convert.ToInt32(txt_Amount_of_Rent.Value);
			dr["Update_to_Site"] = false;
		}

		private void frm_land_Load(object sender, System.EventArgs e)
		{
			gui_land.Movie = String.Concat(Environment.CurrentDirectory, "\\guiland.mnu");
			pw_sh("land");

			fill_cmbs();

			cnn.Open();
			oda.Fill(ds, "master");
			cnn.Close();

			dt.Columns.Add("‘„«—Â „·ﬂ");
			dt.Columns.Add("„‰ÿﬁÂ");
			dt.Columns.Add("‰Ê⁄ ﬁ—«—œ«œ");
			dt.Columns.Add("„”«Õ  ﬂ·");
			dt.Columns.Add("„”«Õ  “Ì— »‰«");
			dt.Columns.Add("„»·€ ›—Ê‘");
			dt.Columns.Add("„»·€ —Â‰");
			dt.Columns.Add("„»·€ «Ã«—Â");
			dt.Columns.Add("„⁄«„·Â ‘œÂ");
		}

		private void gui_land_FSCommand(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent e)
		{
			switch (e.command)
			{
				case "f_chk_out":
					if (txt_Amount_of_Sale.Enabled == true)
						txt_Amount_of_Sale.Focus();
					else
						txt_from_Amount_of_Sale.Focus();
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

		private void frm_land_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			pw_sh("land");
			cnn.Close();
			Application.Exit();
		}

		private void txt_ID_TextChanged(object sender, System.EventArgs e)
		{
			if (txt_ID.Text.Trim() == "")
				btn_find_ID.Enabled = false;
			else
				btn_find_ID.Enabled = true;
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{
			cnn.Open();

			Clear_Values();
			en_dis(true);
			txt_LandLord.Focus();

			OleDbCommand cmd = new OleDbCommand(String.Concat("SELECT * FROM master"), cnn);
			OleDbDataReader drr = cmd.ExecuteReader();

			int Virtual_ID = ds.Tables["master"].Rows.Count + 1;

			while (drr.Read())
			{
				if (Virtual_ID < Convert.ToInt32(drr["ID"]) + 1)
					Virtual_ID = Convert.ToInt32(drr["ID"]) + 1;
			}

			txt_ID.Text = Virtual_ID.ToString();
			txt_ID.ReadOnly = true;
			txt_Date.Text = msbg_sd1.msbg_ShamsiDate();

			btn_ClearPage.Enabled = false;
			btn_insert.Enabled = false;
			btn_edit.Enabled = false;
			btn_erase.Enabled = false;
			btn_exchange.Enabled = false;
			btn_activate.Enabled = false;
			btn_find.Enabled = false;
			btn_find_ID.Enabled = false;
			btn_save.Enabled = true;
			btn_cancel.Enabled = true;

			cnn.Close();
			drr.Close();
			drr = null;
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			btn_save.Enabled = false;
			btn_cancel.Enabled = false;
			btn_insert.Enabled = true;
			btn_ClearPage.Enabled = true;
			btn_find.Enabled = true;

			Clear_Values();
			en_dis(false);
			txt_ID.Focus();
			txt_ID.ReadOnly = false;
		}

		private void tmr_sh_date_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			gui_land.SetVariable("_root.Time_SH", msbg_sd1.msbg_ShamsiDate());
		}

		private void ctx_sh_date_Click(object sender, System.EventArgs e)
		{
			txt_Date.Text = msbg_sd1.msbg_ShamsiDate();
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			cnn.Open();
			DataRow	dr = ds.Tables["master"].NewRow();
			dr["ID"] = txt_ID.Text.Trim();
				save(dr);
			dr["Active"] = true;
			ds.Tables["master"].Rows.Add(dr);

			OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
			ocb.QuotePrefix = "[";
			ocb.QuoteSuffix = "]";
			oda.InsertCommand = ocb.GetInsertCommand();
			if (oda.Update(ds, "master") == 1)
				ds.AcceptChanges();
			else
				ds.RejectChanges();
			cnn.Close();

			btn_save.Enabled = false;
			btn_cancel.Enabled = false;
			btn_insert.Enabled = true;
			btn_ClearPage.Enabled = true;
			btn_find.Enabled = true;

			Clear_Values();
			en_dis(false);
			txt_ID.Focus();
			txt_ID.ReadOnly = false;
		}

		void find()
		{
			cnn.Open();
			OleDbCommand cmd = new OleDbCommand(String.Concat("SELECT * FROM [master] WHERE (([ID]='", txt_ID.Text.Trim(), "'))"), cnn);
			OleDbDataReader drr = cmd.ExecuteReader();
			bool found = false;
			while (drr.Read())
			{
				Real_ID = drr["ID"].ToString();
				found = true;
				break;
			}
			if (found == true)
			{
				txt_ID.Text = drr["ID"].ToString();
				txt_LandLord.Text = drr["LandLord"].ToString();
				txt_Tel.Text = drr["Tel"].ToString();
				txt_Mobile.Text = drr["Mobile"].ToString();
				txt_Introducer.Text = drr["Introducer"].ToString();
				txt_Introducer_Tel.Text = drr["Introducer_Tel"].ToString();
				txt_Address.Text = drr["Address"].ToString();
				txt_Date.Text = drr["Date"].ToString();
				cmb_zone.Text = drr["zone"].ToString();
				cmb_agreementtype.Text = drr["agreementtype"].ToString();
				cmb_landtype.Text = drr["landtype"].ToString();
				cmb_documentstatus.Text = drr["documentstatus"].ToString();
				txt_Area_Total.Value = Convert.ToInt32(drr["Area_Total"]);
				txt_Area_Builder_Base.Value = Convert.ToInt32(drr["Area_Builder_Base"]);
				txt_Width_Away.Value = Convert.ToInt16(drr["Width_Away"]);
				txt_Depot_Meter.Value = Convert.ToInt16(drr["Depot_Meter"]);
				txt_Age_of_Builder.Value = Convert.ToByte(drr["Age_of_Builder"]);
				txt_Quantity_of_Floors.Value = Convert.ToByte(drr["Quantity_of_Floors"]);
				txt_Quantity_of_Units.Value = Convert.ToByte(drr["Quantity_of_Units"]);
				txt_Quantity_of_BedRoom.Value = Convert.ToByte(drr["Quantity_of_BedRoom"]);
				cmb_facing.Text = drr["facing"].ToString();
				cmb_geographysituation.Text = drr["geographysituation"].ToString();
				txt_Quantity_of_PhoneLine.Value = Convert.ToByte(drr["Quantity_of_PhoneLine"].ToString());
				cmb_kitchentype.Text = drr["kitchentype"].ToString();
				cmb_warmsystem.Text = drr["warmsystem"].ToString();
				cmb_coldsystem.Text = drr["coldsystem"].ToString();
				gui_land.SetVariable("_root.bool_crane.selected", Convert.ToBoolean(drr["bool_crane"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_exchange.selected", Convert.ToBoolean(drr["bool_exchange"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_gas.selected", Convert.ToBoolean(drr["bool_gas"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_parking.selected", Convert.ToBoolean(drr["bool_parking"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_depot.selected", Convert.ToBoolean(drr["bool_depot"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_cabinet.selected", Convert.ToBoolean(drr["bool_cabinet"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_basement.selected", Convert.ToBoolean(drr["bool_basement"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_back-yard.selected", Convert.ToBoolean(drr["bool_back-yard"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_elevator.selected", Convert.ToBoolean(drr["bool_elevator"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_Mocket.selected", Convert.ToBoolean(drr["bool_Mocket"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_v_i_phone.selected", Convert.ToBoolean(drr["bool_v_i_phone"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_central_anthena.selected", Convert.ToBoolean(drr["bool_central_anthena"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_screen.selected", Convert.ToBoolean(drr["bool_screen"]) == true ? "true" : "");
				gui_land.SetVariable("_root.bool_lustre.selected", Convert.ToBoolean(drr["bool_lustre"]) == true ? "true" : "");
				txt_Amount_of_Sale.Value = Convert.ToDecimal(drr["Amount_of_Sale"]);
				txt_Amount_of_Mortgage.Value = Convert.ToInt32(drr["Amount_of_Mortgage"]);
				txt_Amount_of_Rent.Value = Convert.ToInt32(drr["Amount_of_Rent"]);
				if (Convert.ToBoolean(drr["Active"]) == true)
				{
					btn_exchange.Enabled = true;
					btn_activate.Enabled = false;
				}
				else
				{
					btn_exchange.Enabled = false;
					btn_activate.Enabled = true;
				}

				btn_insert.Enabled = false;
				btn_find.Enabled = false;
				btn_find_ID.Enabled = false;
				btn_edit.Enabled = true;
				btn_erase.Enabled = true;
				txt_ID.ReadOnly = true;

				en_dis(true);
			}
			else
			{
				MessageBox.Show("„·ﬂÌ »« ‘„«—Â Ì „Ê—œ ‰Ÿ— Ì«›  ‰‘œ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			txt_ID.Focus();
			txt_ID.SelectAll();

			cnn.Close();
			drr.Close();
			drr =null;
		}


		private void btn_find_ID_Click(object sender, System.EventArgs e)
		{
			find();
		}

		private void btn_erase_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("¬Ì« „«Ì· »Â Õ–› ›Ì“ÌﬂÌ „·ﬂ „Ê—œ ‰Ÿ— „Ì »«‘Ìœ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			switch (result)
			{
				case DialogResult.OK:
					cnn.Open();
					OleDbCommand cmd = new OleDbCommand(String.Concat("SELECT * FROM master"), cnn);
					OleDbDataReader drr = cmd.ExecuteReader();
					int counter = 0;
					while (drr.Read())
					{
						if (drr["ID"].ToString() == Real_ID)
						{
							ds.Tables["master"].Rows[counter].Delete();
							OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
							ocb.QuotePrefix = "[";
							ocb.QuoteSuffix = "]";
							oda.DeleteCommand = ocb.GetDeleteCommand();
							if (oda.Update(ds, "master") == 1)
								ds.AcceptChanges();
							else
								ds.RejectChanges();

							btn_edit.Enabled = false;
							btn_erase.Enabled = false;
							btn_exchange.Enabled = false;
							btn_activate.Enabled = false;
							btn_find_ID.Enabled = false;
							btn_find.Enabled = true;
							btn_insert.Enabled = true;

							Clear_Values();
							en_dis(false);
							txt_ID.ReadOnly = false;
							break;
						}
						counter++;
					}
					cnn.Close();
					drr.Close();
					drr =null;
					dt.Clear();
					dg_Master.DataSource = null;
					break;
				case DialogResult.Cancel:
					break;
				default:
					break;
			}
			txt_ID.Focus();
		}

		private void btn_exchange_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("¬Ì« „«Ì· »Â „⁄«„·Â „·ﬂ „Ê—œ ‰Ÿ— „Ì »«‘Ìœ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			switch (result)
			{
				case DialogResult.OK:
					cnn.Open();
					OleDbCommand cmd = new OleDbCommand(String.Concat("SELECT * FROM master"), cnn);
					OleDbDataReader drr = cmd.ExecuteReader();
					int counter = 0;
					while (drr.Read())
					{
						if (drr["ID"].ToString() == Real_ID)
						{
							DataRow dr;
							dr = ds.Tables["master"].Rows[counter];
							dr.BeginEdit();
								dr["Active"] = false;
							dr.EndEdit();
							OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
							ocb.QuotePrefix = "[";
							ocb.QuoteSuffix = "]";
							oda.UpdateCommand = ocb.GetUpdateCommand();
							if (oda.Update(ds, "master") == 1)
								ds.AcceptChanges();
							else
								ds.RejectChanges();

							btn_edit.Enabled = false;
							btn_erase.Enabled = false;
							btn_exchange.Enabled = false;
							btn_activate.Enabled = false;
							btn_find_ID.Enabled = false;
							btn_find.Enabled = true;
							btn_insert.Enabled = true;

							Clear_Values();
							en_dis(false);
							txt_ID.ReadOnly = false;
							break;
						}
						counter++;
					}
					cnn.Close();
					drr.Close();
					drr =null;
					dt.Clear();
					dg_Master.DataSource = null;
					break;
				case DialogResult.Cancel:
					break;
				default:
					break;
			}
			txt_ID.Focus();
		}

		private void btn_activate_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("¬Ì« „«Ì· »Â „⁄—÷ „⁄«„·Â ê–«‘ ‰ „Ãœœ „·ﬂ „Ê—œ ‰Ÿ— „Ì »«‘Ìœ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			switch (result)
			{
				case DialogResult.OK:
					cnn.Open();
					OleDbCommand cmd = new OleDbCommand(String.Concat("SELECT * FROM master"), cnn);
					OleDbDataReader drr = cmd.ExecuteReader();
					int counter = 0;
					while (drr.Read())
					{
						if (drr["ID"].ToString() == Real_ID)
						{
							DataRow dr;
							dr = ds.Tables["master"].Rows[counter];
							dr.BeginEdit();
								dr["Active"] = true;
							dr.EndEdit();
							OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
							ocb.QuotePrefix = "[";
							ocb.QuoteSuffix = "]";
							oda.UpdateCommand = ocb.GetUpdateCommand();
							if (oda.Update(ds, "master") == 1)
								ds.AcceptChanges();
							else
								ds.RejectChanges();

							btn_edit.Enabled = false;
							btn_erase.Enabled = false;
							btn_exchange.Enabled = false;
							btn_activate.Enabled = false;
							btn_find_ID.Enabled = false;
							btn_find.Enabled = true;
							btn_insert.Enabled = true;

							Clear_Values();
							en_dis(false);
							txt_ID.ReadOnly = false;
							break;
						}
						counter++;
					}
					cnn.Close();
					drr.Close();
					drr =null;
					dt.Clear();
					dg_Master.DataSource = null;
					break;
				case DialogResult.Cancel:
					break;
				default:
					break;
			}
			txt_ID.Focus();
		}

		private void btn_edit_Click(object sender, System.EventArgs e)
		{
			DialogResult result = MessageBox.Show("¬Ì« „«Ì· »Â «⁄„«·  €ÌÌ—«  „Ê—œ ‰Ÿ— „Ì »«‘Ìœ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			switch (result)
			{
				case DialogResult.OK:
					cnn.Open();
					OleDbCommand cmd = new OleDbCommand(String.Concat("SELECT * FROM master"), cnn);
					OleDbDataReader drr = cmd.ExecuteReader();
					int counter = 0;
					while (drr.Read())
					{
						if (drr["ID"].ToString() == Real_ID)
						{
							DataRow dr;
							dr = ds.Tables["master"].Rows[counter];

							dr.BeginEdit();
								save(dr);
							dr.EndEdit();

							OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
							ocb.QuotePrefix = "[";
							ocb.QuoteSuffix = "]";
							oda.UpdateCommand = ocb.GetUpdateCommand();
							if (oda.Update(ds, "master") == 1)
								ds.AcceptChanges();
							else
								ds.RejectChanges();

							btn_edit.Enabled = false;
							btn_erase.Enabled = false;
							btn_exchange.Enabled = false;
							btn_activate.Enabled = false;
							btn_find_ID.Enabled = false;
							btn_find.Enabled = true;
							btn_insert.Enabled = true;

							Clear_Values();
							en_dis(false);
							txt_ID.ReadOnly = false;
							break;
						}
						counter++;
					}
					cnn.Close();
					drr.Close();
					drr =null;
					dt.Clear();
					dg_Master.DataSource = null;
					break;
				case DialogResult.Cancel:
					break;
				default:
					break;
			}
			txt_ID.Focus();
		}

		private void btn_ClearPage_Click(object sender, System.EventArgs e)
		{
			btn_edit.Enabled = false;
			btn_erase.Enabled = false;
			btn_exchange.Enabled = false;
			btn_activate.Enabled = false;
			btn_insert.Enabled = true;
			btn_find.Enabled = true;

			Clear_Values();
			en_dis(false);
			txt_ID.Focus();
			txt_ID.ReadOnly = false;

			dt.Clear();
			dg_Master.DataSource = null;
		}

		public string Str_Select = "SELECT * FROM [master]";

		void Select_Str_Chooser(string field, TextBox text)
		{
			if (text.Text.Trim() != "")
			{
				if (Str_Select.Length == 22)
					Str_Select += " WHERE";
				else
					Str_Select += " AND";
				Str_Select += " (([" + field + "]='" + text.Text + "'))";
			}
		}

		void Select_Str_Chooser(string field, ComboBox text)
		{
			if (text.Text.Trim() != "")
			{
				if (Str_Select.Length == 22)
					Str_Select += " WHERE";
				else
					Str_Select += " AND";
				Str_Select += " (([" + field + "]='" + text.Text + "'))";
			}
		}

		void Select_Str_Chooser(string field, NumericUpDown text, string comp_type)
		{
			switch (comp_type)
			{
				case ">":
					if (text.Value != 0)
					{
						if (Str_Select.Length == 22)
							Str_Select += " WHERE";
						else
							Str_Select += " AND";
						Str_Select += " (([" + field + "]>=" + text.Value + "))";
					}
					break;
				case "<":
					if (text.Value != 0)
					{
						if (Str_Select.Length == 22)
							Str_Select += " WHERE";
						else
							Str_Select += " AND";
						Str_Select += " (([" + field + "]<=" + text.Value + "))";
					}
					break;
				case "=":
					if (text.Value != 0)
					{
						if (Str_Select.Length == 22)
							Str_Select += " WHERE";
						else
							Str_Select += " AND";
						Str_Select += " (([" + field + "]=" + text.Value + "))";
					}
					break;
				default:
					break;
			}
		}

		void Select_Str_Chooser(string field)
		{
			if (gui_land.GetVariable(String.Concat("_root.", field, ".selected")) == "true")
			{
				if (Str_Select.Length == 22)
					Str_Select += " WHERE";
				else
					Str_Select += " AND";
				Str_Select += String.Concat(" (([" + field + "]=", gui_land.GetVariable(String.Concat("_root.", field, ".selected")) == "" ? "FALSE" : "TRUE", "))");
			}
		}

		string Select_Str_Builder()
		{
			Select_Str_Chooser("LandLord", txt_LandLord);
			Select_Str_Chooser("Tel", txt_Tel);
			Select_Str_Chooser("Mobile", txt_Mobile);
			Select_Str_Chooser("Introducer", txt_Introducer);
			Select_Str_Chooser("Introducer", txt_Introducer_Tel);
			Select_Str_Chooser("Address", txt_Address);
			Select_Str_Chooser("Date", txt_Date);
			Select_Str_Chooser("zone", cmb_zone);
			Select_Str_Chooser("agreementtype", cmb_agreementtype);
			Select_Str_Chooser("landtype", cmb_landtype);
			Select_Str_Chooser("documentstatus", cmb_documentstatus);
			Select_Str_Chooser("Area_Total", txt_from_Area_Total, ">");
			Select_Str_Chooser("Area_Total", txt_to_Area_Total, "<");
			Select_Str_Chooser("Area_Builder_Base", txt_from_Area_Builder_Base, ">");
			Select_Str_Chooser("Area_Builder_Base", txt_to_Area_Builder_Base, "<");
			Select_Str_Chooser("Width_Away", txt_from_Width_Away, ">");
			Select_Str_Chooser("Width_Away", txt_to_Width_Away, "<");
			Select_Str_Chooser("Depot_Meter", txt_from_Depot_Meter, ">");
			Select_Str_Chooser("Depot_Meter", txt_to_Depot_Meter, "<");
			Select_Str_Chooser("Age_of_Builder", txt_from_Age_of_Builder, ">");
			Select_Str_Chooser("Age_of_Builder", txt_to_Age_of_Builder, "<");
			Select_Str_Chooser("Quantity_of_Floors", txt_from_Quantity_of_Floors, ">");
			Select_Str_Chooser("Quantity_of_Floors", txt_to_Quantity_of_Floors, "<");
			Select_Str_Chooser("Quantity_of_Units", txt_from_Quantity_of_Units, ">");
			Select_Str_Chooser("Quantity_of_Units", txt_to_Quantity_of_Units, "<");
			Select_Str_Chooser("Quantity_of_BedRoom", txt_from_Quantity_of_BedRoom, ">");
			Select_Str_Chooser("Quantity_of_BedRoom", txt_to_Quantity_of_BedRoom, "<");
			Select_Str_Chooser("facing", cmb_facing);
			Select_Str_Chooser("geographysituation", cmb_geographysituation);
			Select_Str_Chooser("Quantity_of_PhoneLine", txt_Quantity_of_PhoneLine, "=");
			Select_Str_Chooser("kitchentype", cmb_kitchentype);
			Select_Str_Chooser("warmsystem", cmb_warmsystem);
			Select_Str_Chooser("coldsystem", cmb_coldsystem);

			Select_Str_Chooser("bool_crane");
			Select_Str_Chooser("bool_exchange");
			Select_Str_Chooser("bool_gas");
			Select_Str_Chooser("bool_parking");
			Select_Str_Chooser("bool_depot");
			Select_Str_Chooser("bool_cabinet");
			Select_Str_Chooser("bool_basement");
			Select_Str_Chooser("bool_back-yard");
			Select_Str_Chooser("bool_elevator");
			Select_Str_Chooser("bool_Mocket");
			Select_Str_Chooser("bool_v_i_phone");
			Select_Str_Chooser("bool_central_anthena");
			Select_Str_Chooser("bool_screen");
			Select_Str_Chooser("bool_lustre");
			
			Select_Str_Chooser("Amount_of_Sale", txt_from_Amount_of_Sale, ">");
			Select_Str_Chooser("Amount_of_Sale", txt_to_Amount_of_Sale, "<");
			Select_Str_Chooser("Amount_of_Mortgage", txt_from_Amount_of_Mortgage, ">");
			Select_Str_Chooser("Amount_of_Mortgage", txt_to_Amount_of_Mortgage, "<");
			Select_Str_Chooser("Amount_of_Rent", txt_from_Amount_of_Rent, ">");
			Select_Str_Chooser("Amount_of_Rent", txt_to_Amount_of_Rent, "<");

			return Str_Select;
		}

		private void btn_find_Click(object sender, System.EventArgs e)
		{
			cnn.Open();

			OleDbCommand cmd = new OleDbCommand(Select_Str_Builder(), cnn);
			OleDbDataReader drr = cmd.ExecuteReader();

			bool found = false;
			dt.Clear();
			DataRow dr;
			while (drr.Read())
			{
				dr = dt.NewRow();
					dr[0] = drr["ID"].ToString();
					dr[1] = drr["zone"].ToString();
					dr[2] = drr["agreementtype"].ToString();
					dr[3] = Convert.ToInt32(drr["Area_Total"]);
					dr[4] = Convert.ToInt32(drr["Area_Builder_Base"]);
					dr[5] = Convert.ToDecimal(drr["Amount_of_Sale"]);
					dr[6] = Convert.ToInt32(drr["Amount_of_Mortgage"]);
					dr[7] = Convert.ToInt32(drr["Amount_of_Rent"]);
					dr[8] = Convert.ToBoolean(drr["Active"]) == false ? "»·Â" : "ŒÌ—";
				dt.Rows.Add(dr);
				found = true;
			}
			if (found == true)
			{
				txt_ID.ReadOnly = true;
				btn_insert.Enabled = false;
				btn_find.Enabled = false;
				dg_Master.Enabled = true;
				dg_Master.DataSource = dt;
				Clear_Values();
				dg_Master.Focus();
			}
			else
			{
				MessageBox.Show("„·ﬂÌ »« „‘Œ’«  „Ê—œ ‰Ÿ— ‘„« Ì«›  ‰‘œ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txt_ID.Focus();
			}

			Str_Select = "SELECT * FROM [master]";

			cnn.Close();
			drr.Close();
			drr =null;

		}

		void Compare_Num(NumericUpDown from, NumericUpDown to)
		{
			if (from.Value > from.Maximum)
				from.Value = from.Maximum;
			if (to.Value > to.Maximum)
				to.Value = to.Maximum;
			if (from.Value >= to.Value)
				if (from.Value * 2 <= to.Maximum)
					to.Value = from.Value * 2;
				else
					to.Value = to.Maximum;
		}
		private void txt_from_Area_Total_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Area_Total, txt_to_Area_Total);
		}

		private void txt_to_Area_Total_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Area_Total, txt_to_Area_Total);
		}

		private void txt_from_Area_Total_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Area_Total, txt_to_Area_Total);
		}

		private void txt_to_Area_Total_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Area_Total, txt_to_Area_Total);
		}

		private void txt_from_Area_Builder_Base_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Area_Builder_Base, txt_to_Area_Builder_Base);
		}

		private void txt_to_Area_Builder_Base_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Area_Builder_Base, txt_to_Area_Builder_Base);
		}

		private void txt_from_Area_Builder_Base_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Area_Builder_Base, txt_to_Area_Builder_Base);
		}

		private void txt_to_Area_Builder_Base_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Area_Builder_Base, txt_to_Area_Builder_Base);
		}

		private void txt_from_Width_Away_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Width_Away, txt_to_Width_Away);
		}

		private void txt_to_Width_Away_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Width_Away, txt_to_Width_Away);
		}

		private void txt_from_Width_Away_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Width_Away, txt_to_Width_Away);
		}

		private void txt_to_Width_Away_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Width_Away, txt_to_Width_Away);
		}

		private void txt_from_Depot_Meter_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Depot_Meter, txt_to_Depot_Meter);
		}

		private void txt_to_Depot_Meter_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Depot_Meter, txt_to_Depot_Meter);
		}

		private void txt_from_Depot_Meter_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Depot_Meter, txt_to_Depot_Meter);
		}

		private void txt_to_Depot_Meter_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Depot_Meter, txt_to_Depot_Meter);
		}

		private void txt_from_Age_of_Builder_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Age_of_Builder, txt_to_Age_of_Builder);
		}

		private void txt_to_Age_of_Builder_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Age_of_Builder, txt_to_Age_of_Builder);
		}

		private void txt_from_Age_of_Builder_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Age_of_Builder, txt_to_Age_of_Builder);
		}

		private void txt_to_Age_of_Builder_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Age_of_Builder, txt_to_Age_of_Builder);
		}

		private void txt_from_Quantity_of_Floors_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_Floors, txt_to_Quantity_of_Floors);
		}

		private void txt_to_Quantity_of_Floors_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_Floors, txt_to_Quantity_of_Floors);
		}

		private void txt_from_Quantity_of_Floors_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_Floors, txt_to_Quantity_of_Floors);
		}

		private void txt_to_Quantity_of_Floors_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_Floors, txt_to_Quantity_of_Floors);
		}

		private void txt_from_Quantity_of_Units_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_Units, txt_to_Quantity_of_Units);
		}

		private void txt_to_Quantity_of_Units_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_Units, txt_to_Quantity_of_Units);
		}

		private void txt_from_Quantity_of_Units_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_Units, txt_to_Quantity_of_Units);
		}

		private void txt_to_Quantity_of_Units_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_Units, txt_to_Quantity_of_Units);
		}

		private void txt_from_Quantity_of_BedRoom_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_BedRoom, txt_to_Quantity_of_BedRoom);
		}

		private void txt_to_Quantity_of_BedRoom_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_BedRoom, txt_to_Quantity_of_BedRoom);
		}

		private void txt_from_Quantity_of_BedRoom_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_BedRoom, txt_to_Quantity_of_BedRoom);
		}

		private void txt_to_Quantity_of_BedRoom_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Quantity_of_BedRoom, txt_to_Quantity_of_BedRoom);
		}

		private void txt_from_Amount_of_Sale_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Sale, txt_to_Amount_of_Sale);
		}

		private void txt_to_Amount_of_Sale_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Sale, txt_to_Amount_of_Sale);
		}

		private void txt_from_Amount_of_Sale_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Sale, txt_to_Amount_of_Sale);
		}

		private void txt_to_Amount_of_Sale_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Sale, txt_to_Amount_of_Sale);
		}

		private void txt_from_Amount_of_Mortgage_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Mortgage, txt_to_Amount_of_Mortgage);
		}

		private void txt_to_Amount_of_Mortgage_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Mortgage, txt_to_Amount_of_Mortgage);
		}

		private void txt_from_Amount_of_Mortgage_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Mortgage, txt_to_Amount_of_Mortgage);
		}

		private void txt_to_Amount_of_Mortgage_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Mortgage, txt_to_Amount_of_Mortgage);
		}

		private void txt_from_Amount_of_Rent_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Rent, txt_to_Amount_of_Rent);
		}

		private void txt_to_Amount_of_Rent_ValueChanged(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Rent, txt_to_Amount_of_Rent);
		}

		private void txt_from_Amount_of_Rent_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Rent, txt_to_Amount_of_Rent);
		}

		private void txt_to_Amount_of_Rent_Leave(object sender, System.EventArgs e)
		{
			Compare_Num(txt_from_Amount_of_Rent, txt_to_Amount_of_Rent);
		}

		private void dg_Master_CurrentCellChanged(object sender, System.EventArgs e)
		{
			txt_ID.Text = dt.Rows[dg_Master.CurrentRowIndex][0].ToString();
			find();
		}

		private void txt_LandLord_Enter(object sender, System.EventArgs e)
		{
			txt_LandLord.SelectAll();
		}

		private void txt_Tel_Enter(object sender, System.EventArgs e)
		{
			 txt_Tel.SelectAll();
		}

		private void txt_Mobile_Enter(object sender, System.EventArgs e)
		{
			txt_Mobile.SelectAll();
		}

		private void txt_Introducer_Enter(object sender, System.EventArgs e)
		{
			txt_Introducer.SelectAll();
		}

		private void txt_Introducer_Tel_Enter(object sender, System.EventArgs e)
		{
			txt_Introducer_Tel.SelectAll();
		}

		private void txt_Address_Enter(object sender, System.EventArgs e)
		{
			txt_Address.SelectAll();
		}

		private void txt_Date_Enter(object sender, System.EventArgs e)
		{
			txt_Date.SelectAll();
		}

		private void txt_ID_Enter(object sender, System.EventArgs e)
		{
			txt_ID.SelectAll();
		}

		private void txt_Area_Total_Leave(object sender, System.EventArgs e)
		{
			if (txt_Area_Total.Value > txt_Area_Total.Maximum)
				txt_Area_Total.Value = txt_Area_Total.Maximum;
		}

		private void txt_Area_Builder_Base_Leave(object sender, System.EventArgs e)
		{
			if (txt_Area_Builder_Base.Value > txt_Area_Builder_Base.Maximum)
				txt_Area_Builder_Base.Value = txt_Area_Builder_Base.Maximum;
		}

		private void txt_Width_Away_Leave(object sender, System.EventArgs e)
		{
			if (txt_Width_Away.Value > txt_Width_Away.Maximum)
				txt_Width_Away.Value = txt_Width_Away.Maximum;
		}

		private void txt_Depot_Meter_Leave(object sender, System.EventArgs e)
		{
			if (txt_Depot_Meter.Value > txt_Depot_Meter.Maximum)
				txt_Depot_Meter.Value = txt_Depot_Meter.Maximum;
		}

		private void txt_Age_of_Builder_Leave(object sender, System.EventArgs e)
		{
			if (txt_Age_of_Builder.Value > txt_Age_of_Builder.Maximum)
				txt_Age_of_Builder.Value = txt_Age_of_Builder.Maximum;
		}

		private void txt_Quantity_of_Floors_Leave(object sender, System.EventArgs e)
		{
			if (txt_Quantity_of_Floors.Value > txt_Quantity_of_Floors.Maximum)
				txt_Quantity_of_Floors.Value = txt_Quantity_of_Floors.Maximum;
		}

		private void txt_Quantity_of_Units_Leave(object sender, System.EventArgs e)
		{
			if (txt_Quantity_of_Units.Value > txt_Quantity_of_Units.Maximum)
				txt_Quantity_of_Units.Value = txt_Quantity_of_Units.Maximum;
		}

		private void txt_Quantity_of_BedRoom_Leave(object sender, System.EventArgs e)
		{
			if (txt_Quantity_of_BedRoom.Value > txt_Quantity_of_BedRoom.Maximum)
				txt_Quantity_of_BedRoom.Value = txt_Quantity_of_BedRoom.Maximum;
		}

		private void txt_Quantity_of_PhoneLine_Leave(object sender, System.EventArgs e)
		{
			if (txt_Quantity_of_PhoneLine.Value > txt_Quantity_of_PhoneLine.Maximum)
				txt_Quantity_of_PhoneLine.Value = txt_Quantity_of_PhoneLine.Maximum;
		}

		private void txt_Amount_of_Sale_Leave(object sender, System.EventArgs e)
		{
			if (txt_Amount_of_Sale.Value > txt_Amount_of_Sale.Maximum)
				txt_Amount_of_Sale.Value = txt_Amount_of_Sale.Maximum;
		}

		private void txt_Amount_of_Mortgage_Leave(object sender, System.EventArgs e)
		{
			if (txt_Amount_of_Mortgage.Value > txt_Amount_of_Mortgage.Maximum)
				txt_Amount_of_Mortgage.Value = txt_Amount_of_Mortgage.Maximum;
		}

		private void txt_Amount_of_Rent_Leave(object sender, System.EventArgs e)
		{
			if (txt_Amount_of_Rent.Value > txt_Amount_of_Rent.Maximum)
				txt_Amount_of_Rent.Value = txt_Amount_of_Rent.Maximum;
		}

		private void txt_Area_Total_Enter(object sender, System.EventArgs e)
		{
			txt_Area_Total.Select(0, txt_Area_Total.Maximum.ToString().Length);
		}

		private void txt_from_Area_Total_Enter(object sender, System.EventArgs e)
		{
			txt_from_Area_Total.Select(0, txt_from_Area_Total.Maximum.ToString().Length);
		}

		private void txt_to_Area_Total_Enter(object sender, System.EventArgs e)
		{
			txt_to_Area_Total.Select(0, txt_to_Area_Total.Maximum.ToString().Length);
		}

		private void txt_Area_Builder_Base_Enter(object sender, System.EventArgs e)
		{
			txt_Area_Builder_Base.Select(0, txt_Area_Builder_Base.Maximum.ToString().Length);
		}

		private void txt_from_Area_Builder_Base_Enter(object sender, System.EventArgs e)
		{
			txt_from_Area_Builder_Base.Select(0, txt_from_Area_Builder_Base.Maximum.ToString().Length);
		}

		private void txt_to_Area_Builder_Base_Enter(object sender, System.EventArgs e)
		{
			txt_to_Area_Builder_Base.Select(0, txt_to_Area_Builder_Base.Maximum.ToString().Length);
		}

		private void txt_Width_Away_Enter(object sender, System.EventArgs e)
		{
			txt_Width_Away.Select(0, txt_Width_Away.Maximum.ToString().Length);
		}

		private void txt_from_Width_Away_Enter(object sender, System.EventArgs e)
		{
			txt_from_Width_Away.Select(0, txt_from_Width_Away.Maximum.ToString().Length);
		}

		private void txt_to_Width_Away_Enter(object sender, System.EventArgs e)
		{
			txt_to_Width_Away.Select(0,txt_to_Width_Away .Maximum.ToString().Length);
		}

		private void txt_Depot_Meter_Enter(object sender, System.EventArgs e)
		{
			 txt_Depot_Meter.Select(0,  txt_Depot_Meter.Maximum.ToString().Length);
		}

		private void txt_from_Depot_Meter_Enter(object sender, System.EventArgs e)
		{
			txt_from_Depot_Meter.Select(0, txt_from_Depot_Meter.Maximum.ToString().Length);
		}

		private void txt_to_Depot_Meter_Enter(object sender, System.EventArgs e)
		{
			txt_to_Depot_Meter.Select(0, txt_to_Depot_Meter.Maximum.ToString().Length);
		}

		private void txt_Age_of_Builder_Enter(object sender, System.EventArgs e)
		{
			txt_Age_of_Builder.Select(0, txt_Age_of_Builder.Maximum.ToString().Length);
		}

		private void txt_from_Age_of_Builder_Enter(object sender, System.EventArgs e)
		{
			txt_from_Age_of_Builder.Select(0, txt_from_Age_of_Builder.Maximum.ToString().Length);
		}

		private void txt_to_Age_of_Builder_Enter(object sender, System.EventArgs e)
		{
			txt_to_Age_of_Builder.Select(0, txt_to_Age_of_Builder.Maximum.ToString().Length);
		}

		private void txt_Quantity_of_Floors_Enter(object sender, System.EventArgs e)
		{
			txt_Quantity_of_Floors.Select(0, txt_Quantity_of_Floors.Maximum.ToString().Length);
		}

		private void txt_from_Quantity_of_Floors_Enter(object sender, System.EventArgs e)
		{
			txt_from_Quantity_of_Floors.Select(0, txt_from_Quantity_of_Floors.Maximum.ToString().Length);
		}

		private void txt_to_Quantity_of_Floors_Enter(object sender, System.EventArgs e)
		{
			txt_to_Quantity_of_Floors.Select(0, txt_to_Quantity_of_Floors.Maximum.ToString().Length);
		}

		private void txt_Quantity_of_Units_Enter(object sender, System.EventArgs e)
		{
			txt_Quantity_of_Units.Select(0, txt_Quantity_of_Units.Maximum.ToString().Length);
		}

		private void txt_from_Quantity_of_Units_Enter(object sender, System.EventArgs e)
		{
			txt_from_Quantity_of_Units.Select(0, txt_from_Quantity_of_Units.Maximum.ToString().Length);
		}

		private void txt_to_Quantity_of_Units_Enter(object sender, System.EventArgs e)
		{
			txt_to_Quantity_of_Units.Select(0, txt_to_Quantity_of_Units.Maximum.ToString().Length);
		}

		private void txt_Quantity_of_BedRoom_Enter(object sender, System.EventArgs e)
		{
			txt_Quantity_of_BedRoom.Select(0, txt_Quantity_of_BedRoom.Maximum.ToString().Length);
		}

		private void txt_from_Quantity_of_BedRoom_Enter(object sender, System.EventArgs e)
		{
			txt_from_Quantity_of_BedRoom.Select(0, txt_from_Quantity_of_BedRoom.Maximum.ToString().Length);
		}

		private void txt_to_Quantity_of_BedRoom_Enter(object sender, System.EventArgs e)
		{
			txt_to_Quantity_of_BedRoom.Select(0, txt_to_Quantity_of_BedRoom.Maximum.ToString().Length);
		}

		private void txt_Quantity_of_PhoneLine_Enter(object sender, System.EventArgs e)
		{
			txt_Quantity_of_PhoneLine.Select(0, txt_Quantity_of_PhoneLine.Maximum.ToString().Length);
		}

		private void txt_Amount_of_Sale_Enter(object sender, System.EventArgs e)
		{
			txt_Amount_of_Sale.Select(0, txt_Amount_of_Sale.Maximum.ToString().Length);
		}

		private void txt_Amount_of_Mortgage_Enter(object sender, System.EventArgs e)
		{
			txt_Amount_of_Mortgage.Select(0, txt_Amount_of_Mortgage.Maximum.ToString().Length);
		}

		private void txt_Amount_of_Rent_Enter(object sender, System.EventArgs e)
		{
			txt_Amount_of_Rent.Select(0, txt_Amount_of_Rent.Maximum.ToString().Length);
		}

		private void txt_from_Amount_of_Sale_Enter(object sender, System.EventArgs e)
		{
			txt_from_Amount_of_Sale.Select(0, txt_from_Amount_of_Sale.Maximum.ToString().Length);
		}

		private void txt_to_Amount_of_Sale_Enter(object sender, System.EventArgs e)
		{
			txt_to_Amount_of_Sale.Select(0, txt_to_Amount_of_Sale.Maximum.ToString().Length);
		}

		private void txt_from_Amount_of_Mortgage_Enter(object sender, System.EventArgs e)
		{
			txt_from_Amount_of_Mortgage.Select(0, txt_from_Amount_of_Mortgage.Maximum.ToString().Length);
		}

		private void txt_to_Amount_of_Mortgage_Enter(object sender, System.EventArgs e)
		{
			txt_to_Amount_of_Mortgage.Select(0, txt_to_Amount_of_Mortgage.Maximum.ToString().Length);
		}

		private void txt_from_Amount_of_Rent_Enter(object sender, System.EventArgs e)
		{
			txt_from_Amount_of_Rent.Select(0, txt_from_Amount_of_Rent.Maximum.ToString().Length);
		}

		private void txt_to_Amount_of_Rent_Enter(object sender, System.EventArgs e)
		{
			txt_to_Amount_of_Rent.Select(0, txt_to_Amount_of_Rent.Maximum.ToString().Length);
		}
	}
}