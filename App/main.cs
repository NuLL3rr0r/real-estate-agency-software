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
	/// Summary description for Form1.
	/// </summary>
	public class frm_main : System.Windows.Forms.Form
	{
		private AxShockwaveFlashObjects.AxShockwaveFlash gui_main;
		private System.Windows.Forms.NotifyIcon Notify;
		private System.Windows.Forms.ContextMenu mnu_ctx_notify;
		private ShamsiDate.msbg_sd msbg_sd1;
		private System.Windows.Forms.MenuItem ctx_return;
		private System.Windows.Forms.MenuItem ctx_TimeSinceReboot;
		private System.Windows.Forms.MenuItem ctx_CurrentOSVersion;
		private System.Windows.Forms.MenuItem ctx_FrameworkVersion;
		private System.Windows.Forms.MenuItem ctx_CurrentTimeZone;
		private System.Windows.Forms.MenuItem ctx_CurrentDate;
		private System.Windows.Forms.MenuItem ctx_Exit;
		private System.Windows.Forms.MenuItem ctx_space_first;
		private System.Windows.Forms.MenuItem ctx_space_second;
		private System.Timers.Timer tmr_sh_date;
		private System.ComponentModel.IContainer components;

		public frm_main()
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_main));
			this.gui_main = new AxShockwaveFlashObjects.AxShockwaveFlash();
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
			this.tmr_sh_date = new System.Timers.Timer();
			((System.ComponentModel.ISupportInitialize)(this.gui_main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tmr_sh_date)).BeginInit();
			this.SuspendLayout();
			// 
			// gui_main
			// 
			this.gui_main.Enabled = true;
			this.gui_main.Location = new System.Drawing.Point(0, 0);
			this.gui_main.Name = "gui_main";
			this.gui_main.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gui_main.OcxState")));
			this.gui_main.Size = new System.Drawing.Size(1024, 768);
			this.gui_main.TabIndex = 0;
			this.gui_main.FSCommand += new AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEventHandler(this.gui_main_FSCommand);
			// 
			// Notify
			// 
			this.Notify.ContextMenu = this.mnu_ctx_notify;
			this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
			this.Notify.Text = "";
			this.Notify.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
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
			// tmr_sh_date
			// 
			this.tmr_sh_date.Enabled = true;
			this.tmr_sh_date.SynchronizingObject = this;
			this.tmr_sh_date.Elapsed += new System.Timers.ElapsedEventHandler(this.tmr_sh_date_Elapsed);
			// 
			// frm_main
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1024, 768);
			this.ContextMenu = this.mnu_ctx_notify;
			this.ControlBox = false;
			this.Controls.Add(this.gui_main);
			this.Controls.Add(this.msbg_sd1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_main";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "this";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.frm_main_Closing);
			this.Load += new System.EventHandler(this.frm_main_Load);
			((System.ComponentModel.ISupportInitialize)(this.gui_main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tmr_sh_date)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

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
		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		[STAThread]
		static void Main() 
		{
			Application.Run(new frm_pw());
		}

		private void frm_main_Load(object sender, System.EventArgs e)
		{
            gui_main.Movie = String.Concat(Environment.CurrentDirectory, "\\gui.mnu");
			pw_sh("main");
		}

		private void gui_main_FSCommand(object sender, AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent e)
		{
			switch (e.command)
			{
				case "land":
					frm_land Form_Land = new frm_land();
					Form_Land.Show();
					this.Hide();
					break;
				case "basedata":
					frm_basedata Form_BaseData = new frm_basedata();
					Form_BaseData.Show();
					this.Hide();
					break;
				case "uptodate":
					frm_uptodate Form_UpToDate = new frm_uptodate();
					this.Hide();
					Form_UpToDate.Show();
					break;
				case "backup":
					frm_backup Form_BackUp = new frm_backup();
					this.Hide();
					Form_BackUp.Show();
					break;
				case "password":
					frm_password_change Form_Password_Change = new frm_password_change();
					this.Hide();
					Form_Password_Change.Show();
					break;
				case "protect":
					this.Text = "this";
					frm_pw Form_PW = new frm_pw();
					this.Hide();
					Form_PW.Show();
					break;;
				case "systemtray":
					this.Hide();
					Notify.Visible = true;
					Notify.Text = "»—«Ì ‰„«Ì‘ „Ãœœ œ«»· ﬂ·Ìﬂ ﬂ‰Ìœ";
					break;
				case "quit":
					pw_sh("");
					Application.Exit();
					break;
				default:
					break;
			}
		}

		private void notifyIcon1_DoubleClick(object sender, System.EventArgs e)
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

		private void tmr_sh_date_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			gui_main.SetVariable("_root.Time_SH", msbg_sd1.msbg_ShamsiDate());
		}

		private void frm_main_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			pw_sh("");
		}
	}
}