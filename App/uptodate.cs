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
	/// Summary description for uptodate.
	/// </summary>
	public class frm_uptodate : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.TextBox txt_status;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_uptodate()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_uptodate));
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.lbl_status = new System.Windows.Forms.Label();
			this.txt_status = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_update
			// 
			this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_update.Location = new System.Drawing.Point(88, 40);
			this.btn_update.Name = "btn_update";
			this.btn_update.TabIndex = 0;
			this.btn_update.Text = "»Â —Ê“ —”«‰Ì";
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.btn_cancel.Location = new System.Drawing.Point(8, 40);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "·€Ê";
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// lbl_status
			// 
			this.lbl_status.Location = new System.Drawing.Point(168, 8);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(40, 23);
			this.lbl_status.TabIndex = 4;
			this.lbl_status.Text = "Ê÷⁄Ì ";
			// 
			// txt_status
			// 
			this.txt_status.Location = new System.Drawing.Point(8, 8);
			this.txt_status.Name = "txt_status";
			this.txt_status.ReadOnly = true;
			this.txt_status.Size = new System.Drawing.Size(152, 21);
			this.txt_status.TabIndex = 2;
			this.txt_status.Text = "";
			// 
			// frm_uptodate
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(214, 68);
			this.ControlBox = false;
			this.Controls.Add(this.txt_status);
			this.Controls.Add(this.lbl_status);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_update);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_uptodate";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "»Â —Ê“ —”«‰Ì Ê» ”«Ì  »—‰«„Â";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			frm_main Form_Main = new frm_main();
			Form_Main.Show();
			this.Hide();
		}

		private void btn_update_Click(object sender, System.EventArgs e)
		{
			btn_cancel.Enabled = false;
			btn_update.Enabled = false;
			txt_status.Text = "œ— Õ«· »Â —Ê“ —”«‰Ì...";

			OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM master", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
			DataSet ds = new DataSet();

			oda.Fill(ds, "master");

			oda.SelectCommand.CommandText = "SELECT * from bd_agreementtype";
			oda.Fill(ds, "bd_agreementtype");

			oda.SelectCommand.CommandText = "SELECT * from bd_coldsystem";
			oda.Fill(ds, "bd_coldsystem");

			oda.SelectCommand.CommandText = "SELECT * from bd_documentstatus";
			oda.Fill(ds, "bd_documentstatus");

			oda.SelectCommand.CommandText = "SELECT * from bd_facing";
			oda.Fill(ds, "bd_facing");

			oda.SelectCommand.CommandText = "SELECT * from bd_geographysituation";
			oda.Fill(ds, "bd_geographysituation");

			oda.SelectCommand.CommandText = "SELECT * from bd_kitchentype";
			oda.Fill(ds, "bd_kitchentype");

			oda.SelectCommand.CommandText = "SELECT * from bd_landtype";
			oda.Fill(ds, "bd_landtype");

			oda.SelectCommand.CommandText = "SELECT * from bd_warmsystem";
			oda.Fill(ds, "bd_warmsystem");

			oda.SelectCommand.CommandText = "SELECT * from bd_zone";
			oda.Fill(ds, "bd_zone");

			pabksrv.data service = new pabksrv.data();

			try
			{
				service.upload(ds);
				txt_status.Text = "« „«„ ⁄„·Ì«  »Â —Ê“ —”«‰Ì";
				MessageBox.Show("Ê» ”«Ì  »—‰«„Â »« „Ê›ﬁÌ  »Â —Ê“ —”«‰Ì ‘œ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch
			{
				txt_status.Text = "Œÿ« œ— »Â —Ê“ —”«‰Ì";
				MessageBox.Show("»Â —Ê“ —”«‰Ì „„ﬂ‰ ‰„Ì »«‘œ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			frm_main Form_Main = new frm_main();
			Form_Main.Show();
			this.Hide();
		}
	}
}