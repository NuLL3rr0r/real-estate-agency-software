using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace pabk.prog
{
	/// <summary>
	/// Summary description for backup.
	/// </summary>
	public class frm_backup : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btn_backup;
		private System.Windows.Forms.Button btn_restore;
		private System.Windows.Forms.FolderBrowserDialog fbd_backup;
		private System.Windows.Forms.FolderBrowserDialog fbd_restore;
		private System.Windows.Forms.TextBox txt_path_backup;
		private System.Windows.Forms.TextBox txt_path_restore;
		private System.Windows.Forms.Label lbl_path_backup;
		private System.Windows.Forms.Label lbl_path_restore;
		private System.Windows.Forms.Label lbl_last_backup;
		private System.Windows.Forms.Label lbl_last_restore;
		private System.Windows.Forms.GroupBox gb_backup;
		private System.Windows.Forms.TextBox txt_date_last_backup;
		private System.Windows.Forms.TextBox txt_time_last_backup;
		private ShamsiDate.msbg_sd msbg_sd1;
		private System.Windows.Forms.TextBox txt_time_last_restore;
		private System.Windows.Forms.TextBox txt_date_last_restore;
		private System.Windows.Forms.GroupBox gb_restore;
		private System.Windows.Forms.Button btn_cancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_backup()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_backup));
			this.txt_path_backup = new System.Windows.Forms.TextBox();
			this.lbl_path_backup = new System.Windows.Forms.Label();
			this.lbl_path_restore = new System.Windows.Forms.Label();
			this.txt_path_restore = new System.Windows.Forms.TextBox();
			this.btn_backup = new System.Windows.Forms.Button();
			this.btn_restore = new System.Windows.Forms.Button();
			this.fbd_backup = new System.Windows.Forms.FolderBrowserDialog();
			this.fbd_restore = new System.Windows.Forms.FolderBrowserDialog();
			this.txt_date_last_backup = new System.Windows.Forms.TextBox();
			this.lbl_last_backup = new System.Windows.Forms.Label();
			this.txt_time_last_restore = new System.Windows.Forms.TextBox();
			this.lbl_last_restore = new System.Windows.Forms.Label();
			this.gb_backup = new System.Windows.Forms.GroupBox();
			this.txt_time_last_backup = new System.Windows.Forms.TextBox();
			this.msbg_sd1 = new ShamsiDate.msbg_sd();
			this.gb_restore = new System.Windows.Forms.GroupBox();
			this.txt_date_last_restore = new System.Windows.Forms.TextBox();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.gb_backup.SuspendLayout();
			this.gb_restore.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_path_backup
			// 
			this.txt_path_backup.Location = new System.Drawing.Point(24, 88);
			this.txt_path_backup.Name = "txt_path_backup";
			this.txt_path_backup.ReadOnly = true;
			this.txt_path_backup.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_path_backup.Size = new System.Drawing.Size(472, 21);
			this.txt_path_backup.TabIndex = 2;
			this.txt_path_backup.Text = "";
			// 
			// lbl_path_backup
			// 
			this.lbl_path_backup.Location = new System.Drawing.Point(384, 64);
			this.lbl_path_backup.Name = "lbl_path_backup";
			this.lbl_path_backup.Size = new System.Drawing.Size(112, 24);
			this.lbl_path_backup.TabIndex = 1;
			this.lbl_path_backup.Text = "„”Ì— ¬Œ—Ì‰  ÂÌÂ";
			// 
			// lbl_path_restore
			// 
			this.lbl_path_restore.Location = new System.Drawing.Point(368, 232);
			this.lbl_path_restore.Name = "lbl_path_restore";
			this.lbl_path_restore.Size = new System.Drawing.Size(140, 23);
			this.lbl_path_restore.TabIndex = 2;
			this.lbl_path_restore.Text = "„”Ì— ¬Œ—Ì‰ »«“Ì«»Ì";
			// 
			// txt_path_restore
			// 
			this.txt_path_restore.Location = new System.Drawing.Point(24, 88);
			this.txt_path_restore.Name = "txt_path_restore";
			this.txt_path_restore.ReadOnly = true;
			this.txt_path_restore.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_path_restore.Size = new System.Drawing.Size(472, 21);
			this.txt_path_restore.TabIndex = 6;
			this.txt_path_restore.Text = "";
			// 
			// btn_backup
			// 
			this.btn_backup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_backup.Location = new System.Drawing.Point(8, 120);
			this.btn_backup.Name = "btn_backup";
			this.btn_backup.TabIndex = 3;
			this.btn_backup.Text = " ÂÌÂ";
			this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
			// 
			// btn_restore
			// 
			this.btn_restore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_restore.Location = new System.Drawing.Point(8, 120);
			this.btn_restore.Name = "btn_restore";
			this.btn_restore.TabIndex = 7;
			this.btn_restore.Text = "»«“Ì«»Ì";
			this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
			// 
			// txt_date_last_backup
			// 
			this.txt_date_last_backup.Location = new System.Drawing.Point(192, 32);
			this.txt_date_last_backup.Name = "txt_date_last_backup";
			this.txt_date_last_backup.ReadOnly = true;
			this.txt_date_last_backup.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_date_last_backup.Size = new System.Drawing.Size(160, 21);
			this.txt_date_last_backup.TabIndex = 0;
			this.txt_date_last_backup.Text = "";
			// 
			// lbl_last_backup
			// 
			this.lbl_last_backup.Location = new System.Drawing.Point(360, 32);
			this.lbl_last_backup.Name = "lbl_last_backup";
			this.lbl_last_backup.Size = new System.Drawing.Size(136, 24);
			this.lbl_last_backup.TabIndex = 8;
			this.lbl_last_backup.Text = " «—ÌŒ Ê ”«⁄  ¬Œ—Ì‰  ÂÌÂ";
			// 
			// txt_time_last_restore
			// 
			this.txt_time_last_restore.Location = new System.Drawing.Point(24, 32);
			this.txt_time_last_restore.Name = "txt_time_last_restore";
			this.txt_time_last_restore.ReadOnly = true;
			this.txt_time_last_restore.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_time_last_restore.Size = new System.Drawing.Size(160, 21);
			this.txt_time_last_restore.TabIndex = 5;
			this.txt_time_last_restore.Text = "";
			// 
			// lbl_last_restore
			// 
			this.lbl_last_restore.Location = new System.Drawing.Point(360, 32);
			this.lbl_last_restore.Name = "lbl_last_restore";
			this.lbl_last_restore.Size = new System.Drawing.Size(140, 23);
			this.lbl_last_restore.TabIndex = 10;
			this.lbl_last_restore.Text = " «—ÌŒ Ê ”«⁄  ¬Œ—Ì‰ »«“Ì«»Ì";
			// 
			// gb_backup
			// 
			this.gb_backup.Controls.Add(this.txt_time_last_backup);
			this.gb_backup.Controls.Add(this.btn_backup);
			this.gb_backup.Controls.Add(this.txt_path_backup);
			this.gb_backup.Controls.Add(this.txt_date_last_backup);
			this.gb_backup.Controls.Add(this.lbl_path_backup);
			this.gb_backup.Controls.Add(this.lbl_last_backup);
			this.gb_backup.Location = new System.Drawing.Point(10, 8);
			this.gb_backup.Name = "gb_backup";
			this.gb_backup.Size = new System.Drawing.Size(520, 150);
			this.gb_backup.TabIndex = 11;
			this.gb_backup.TabStop = false;
			this.gb_backup.Text = " ÂÌÂ ‰”ŒÂ Ì Å‘ Ì»«‰";
			// 
			// txt_time_last_backup
			// 
			this.txt_time_last_backup.Location = new System.Drawing.Point(24, 32);
			this.txt_time_last_backup.Name = "txt_time_last_backup";
			this.txt_time_last_backup.ReadOnly = true;
			this.txt_time_last_backup.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_time_last_backup.Size = new System.Drawing.Size(160, 21);
			this.txt_time_last_backup.TabIndex = 1;
			this.txt_time_last_backup.Text = "";
			// 
			// msbg_sd1
			// 
			this.msbg_sd1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.msbg_sd1.Location = new System.Drawing.Point(520, 352);
			this.msbg_sd1.Name = "msbg_sd1";
			this.msbg_sd1.Size = new System.Drawing.Size(16, 16);
			this.msbg_sd1.TabIndex = 10;
			this.msbg_sd1.Visible = false;
			// 
			// gb_restore
			// 
			this.gb_restore.Controls.Add(this.txt_date_last_restore);
			this.gb_restore.Controls.Add(this.txt_path_restore);
			this.gb_restore.Controls.Add(this.lbl_last_restore);
			this.gb_restore.Controls.Add(this.btn_restore);
			this.gb_restore.Controls.Add(this.txt_time_last_restore);
			this.gb_restore.Location = new System.Drawing.Point(10, 168);
			this.gb_restore.Name = "gb_restore";
			this.gb_restore.Size = new System.Drawing.Size(520, 150);
			this.gb_restore.TabIndex = 12;
			this.gb_restore.TabStop = false;
			this.gb_restore.Text = "»«“Ì«»Ì ‰”ŒÂ Ì Å‘ Ì»«‰";
			// 
			// txt_date_last_restore
			// 
			this.txt_date_last_restore.Location = new System.Drawing.Point(192, 32);
			this.txt_date_last_restore.Name = "txt_date_last_restore";
			this.txt_date_last_restore.ReadOnly = true;
			this.txt_date_last_restore.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_date_last_restore.Size = new System.Drawing.Size(160, 21);
			this.txt_date_last_restore.TabIndex = 4;
			this.txt_date_last_restore.Text = "";
			// 
			// btn_cancel
			// 
			this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_cancel.Location = new System.Drawing.Point(16, 328);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btn_cancel.TabIndex = 8;
			this.btn_cancel.Text = "·€Ê";
			this.btn_cancel.Click += new System.EventHandler(this.button3_Click);
			// 
			// frm_backup
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(544, 394);
			this.ControlBox = false;
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.lbl_path_restore);
			this.Controls.Add(this.gb_backup);
			this.Controls.Add(this.msbg_sd1);
			this.Controls.Add(this.gb_restore);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(550, 400);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 400);
			this.Name = "frm_backup";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ÂÌÂ / »«“Ì«»Ì Å‘ Ì»«‰";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.frm_backup_Load);
			this.gb_backup.ResumeLayout(false);
			this.gb_restore.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public OleDbConnection cnn = new OleDbConnection(String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda_options = new OleDbDataAdapter("SELECT * FROM options", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public DataSet ds_options = new DataSet();

		void backup(string table, string path, string tablename)
		{
			string file_xml = String.Concat(path, table, ".bak");
			string file_xsd = String.Concat(path, table, ".bk");

			if (File.Exists(file_xml))
				File.Delete(file_xml);
			if (File.Exists(file_xsd))
				File.Delete(file_xsd);

			cnn.Open();
			OleDbDataAdapter oda = new OleDbDataAdapter(String.Concat("SELECT * FROM ", table), String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			DataSet ds = new DataSet();

			oda.Fill(ds, table);
			
			System.IO.Directory.CreateDirectory(path);
			ds.WriteXmlSchema(file_xsd);
			ds.WriteXml(file_xml);
			cnn.Close();
			MessageBox.Show(String.Concat("«“ ÃœÊ· ", tablename, " ‰”ŒÂ Å‘ Ì»«‰  ÂÌÂ ‘œ"), "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void restore(string table, string path, string tablename)
		{
			if ((System.IO.File.Exists(String.Concat(path, table, ".bak"))) & (System.IO.File.Exists(String.Concat(path, table, ".bk"))))
			{
				cnn.Open();
				OleDbDataAdapter oda = new OleDbDataAdapter(String.Concat("SELECT * FROM ", table), String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
				DataSet ds = new DataSet();

				oda.Fill(ds, table);

				OleDbCommand cmd = new OleDbCommand(String.Concat("SELECT * FROM ", table), cnn);
				OleDbDataReader drr = cmd.ExecuteReader();

				int counter = 0;

				while (drr.Read())
				{
					ds.Tables[table].Rows[counter].Delete();
					counter++;
				}

				OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
				ocb.QuotePrefix = "[";
				ocb.QuoteSuffix = "]";
				oda.DeleteCommand = ocb.GetDeleteCommand();
				if (oda.Update(ds, table) == 1)
					ds.AcceptChanges();
				else
					ds.RejectChanges();

				ds.ReadXmlSchema(String.Concat(path, table, ".bk"));
				ds.ReadXml(String.Concat(path, table, ".bak"));
				if (oda.Update(ds, table) == 1)
					ds.AcceptChanges();
				else
					ds.RejectChanges();

				cnn.Close();
				drr.Close();
				drr =null;
				MessageBox.Show(String.Concat( "ÃœÊ· ", tablename, " »« „Ê›ﬁÌ  »«“Ì«»Ì ‘œ"), "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
				MessageBox.Show(String.Concat("›«Ì· Â«Ì Å‘ Ì»«‰ ÃœÊ· ", tablename, " œ— œ” —” ‰„Ì »«‘œ"), "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			frm_main Form_Main = new frm_main();
			Form_Main.Show();
			this.Hide();
		}

		private void btn_backup_Click(object sender, System.EventArgs e)
		{
			fbd_backup.SelectedPath = txt_path_backup.Text;
			DialogResult result = fbd_backup.ShowDialog();
			switch (result)
			{
				case DialogResult.OK:
					txt_date_last_backup.Text = msbg_sd1.msbg_ShamsiDate().Trim();
					txt_time_last_backup.Text = String.Concat(DateTime.Now.Hour.ToString(), ":", DateTime.Now.Minute.ToString(), ":", DateTime.Now.Second.ToString()).Trim();
					txt_path_backup.Text =  String.Concat(fbd_backup.SelectedPath.Trim(), "\\", txt_date_last_backup.Text.Replace("/", "_"), " # ", txt_time_last_backup.Text.Replace(":", "_"), "\\");
					cnn.Open();
					OleDbCommand cmd = new OleDbCommand("SELECT * FROM [options] WHERE (([PassWord]=[PassWord]))", cnn);
					OleDbDataReader drr = cmd.ExecuteReader();
					while (drr.Read())
					{
						DataRow dr = ds_options.Tables["options"].Rows[0];

						dr.BeginEdit();
							dr["Path_BackUp"] = txt_path_backup.Text;
							dr["Date_Last_BackUp"] = txt_date_last_backup.Text;
							dr["Time_Last_BackUp"] = txt_time_last_backup.Text;
						dr.EndEdit();

						OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda_options);
						ocb.QuotePrefix = "[";
						ocb.QuoteSuffix = "]";
						oda_options.UpdateCommand = ocb.GetUpdateCommand();
						if (oda_options.Update(ds_options, "options") == 1)
							ds_options.AcceptChanges();
						else
							ds_options.RejectChanges();
						break;
					}
					cnn.Close();
					drr.Close();
					drr =null;
					backup("master", txt_path_backup.Text, "'«„·«ﬂ'");
					backup("bd_agreementtype", txt_path_backup.Text, "'‰Ê⁄ ﬁ—«—œ«œ'");
					backup("bd_coldsystem", txt_path_backup.Text, "'”Ì „ ”—„«∆Ì'");
					backup("bd_documentstatus", txt_path_backup.Text, "'”Ì” „ ê—„«∆Ì'");
					backup("bd_facing", txt_path_backup.Text, "'‰„«'");
					backup("bd_geographysituation", txt_path_backup.Text, "'„Êﬁ⁄Ì  Ã€—«›Ì«∆Ì'");
					backup("bd_kitchentype", txt_path_backup.Text, "'‰Ê⁄ ¬‘Å“Œ«‰Â'");
					backup("bd_landtype", txt_path_backup.Text, "'‰Ê⁄ „·ﬂ'");
					backup("bd_warmsystem", txt_path_backup.Text, "'”Ì” „ ê—„«∆Ì'");
					backup("bd_zone", txt_path_backup.Text, "'„‰ÿﬁÂ'");
					break;
				default:
					break;
			}
		}

		private void frm_backup_Load(object sender, System.EventArgs e)
		{
			cnn.Open();

			oda_options.Fill(ds_options, "options");

			OleDbCommand cmd = new OleDbCommand("SELECT * FROM options", cnn);
			OleDbDataReader drr = cmd.ExecuteReader();
			while (drr.Read())
			{
				txt_path_backup.Text = drr["Path_BackUp"].ToString();
				txt_path_restore.Text = drr["Path_ReStore"].ToString();
				txt_date_last_backup.Text = drr["Date_Last_BackUp"].ToString();
				txt_date_last_restore.Text = drr["Date_Last_ReStore"].ToString();
				txt_time_last_backup.Text = drr["Time_Last_BackUp"].ToString();
				txt_time_last_restore.Text = drr["Time_Last_ReStore"].ToString();
				break;
			}

			cnn.Close();
			drr.Close();
			drr = null;
		}

		private void btn_restore_Click(object sender, System.EventArgs e)
		{
			fbd_restore.SelectedPath = txt_path_restore.Text;
			DialogResult result = fbd_restore.ShowDialog();
			switch (result)
			{
				case DialogResult.OK:
					txt_date_last_restore.Text = msbg_sd1.msbg_ShamsiDate().Trim();
					txt_time_last_restore.Text = String.Concat(DateTime.Now.Hour.ToString(), ":", DateTime.Now.Minute.ToString(), ":", DateTime.Now.Second.ToString()).Trim();
					txt_path_restore.Text =  String.Concat(fbd_restore.SelectedPath.Trim(), "\\");
					cnn.Open();
					OleDbCommand cmd = new OleDbCommand("SELECT * FROM [options] WHERE (([PassWord]=[PassWord]))", cnn);
					OleDbDataReader drr = cmd.ExecuteReader();
					while (drr.Read())
					{
						DataRow dr = ds_options.Tables["options"].Rows[0];

						dr.BeginEdit();
						dr["Path_restore"] = txt_path_restore.Text;
						dr["Date_Last_ReStore"] = txt_date_last_restore.Text;
						dr["Time_Last_ReStore"] = txt_time_last_restore.Text;
						dr.EndEdit();

						OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda_options);
						ocb.QuotePrefix = "[";
						ocb.QuoteSuffix = "]";
						oda_options.UpdateCommand = ocb.GetUpdateCommand();
						if (oda_options.Update(ds_options, "options") == 1)
							ds_options.AcceptChanges();
						else
							ds_options.RejectChanges();
						break;
					}
					cnn.Close();
					drr.Close();
					drr =null;
					restore("master", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'«„·«ﬂ'");
					restore("bd_agreementtype", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'‰Ê⁄ ﬁ—«—œ«œ'");
					restore("bd_coldsystem", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'”Ì „ ”—„«∆Ì'");
					restore("bd_documentstatus", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'”Ì” „ ê—„«∆Ì'");
					restore("bd_facing", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'‰„«'");
					restore("bd_geographysituation", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'„Êﬁ⁄Ì  Ã€—«›Ì«∆Ì'");
					restore("bd_kitchentype", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'‰Ê⁄ ¬‘Å“Œ«‰Â'");
					restore("bd_landtype", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'‰Ê⁄ „·ﬂ'");
					restore("bd_warmsystem", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'”Ì” „ ê—„«∆Ì'");
					restore("bd_zone", String.Concat(fbd_restore.SelectedPath.Trim(), "\\"), "'„‰ÿﬁÂ'");
					break;
				default:
					break;
			}
		}
	}
}