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
	/// Summary description for password.
	/// </summary>
	public class frm_password_change : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txt_old_pass;
		private System.Windows.Forms.TextBox txt_new_pass;
		private System.Windows.Forms.TextBox txt_confirm;
		private System.Windows.Forms.Label lbl_old_pass;
		private System.Windows.Forms.Label lbl_new_pass;
		private System.Windows.Forms.Label lbl_confirm;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_password_change()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_password_change));
			this.txt_old_pass = new System.Windows.Forms.TextBox();
			this.txt_new_pass = new System.Windows.Forms.TextBox();
			this.txt_confirm = new System.Windows.Forms.TextBox();
			this.lbl_old_pass = new System.Windows.Forms.Label();
			this.lbl_new_pass = new System.Windows.Forms.Label();
			this.lbl_confirm = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt_old_pass
			// 
			this.txt_old_pass.Location = new System.Drawing.Point(8, 8);
			this.txt_old_pass.Name = "txt_old_pass";
			this.txt_old_pass.PasswordChar = '*';
			this.txt_old_pass.TabIndex = 0;
			this.txt_old_pass.Text = "";
			// 
			// txt_new_pass
			// 
			this.txt_new_pass.Location = new System.Drawing.Point(8, 32);
			this.txt_new_pass.Name = "txt_new_pass";
			this.txt_new_pass.PasswordChar = '*';
			this.txt_new_pass.TabIndex = 1;
			this.txt_new_pass.Text = "";
			// 
			// txt_confirm
			// 
			this.txt_confirm.Location = new System.Drawing.Point(8, 56);
			this.txt_confirm.Name = "txt_confirm";
			this.txt_confirm.PasswordChar = '*';
			this.txt_confirm.TabIndex = 2;
			this.txt_confirm.Text = "";
			// 
			// lbl_old_pass
			// 
			this.lbl_old_pass.Location = new System.Drawing.Point(112, 8);
			this.lbl_old_pass.Name = "lbl_old_pass";
			this.lbl_old_pass.Size = new System.Drawing.Size(64, 23);
			this.lbl_old_pass.TabIndex = 3;
			this.lbl_old_pass.Text = "Å”Ê—œ ﬁ»·Ì";
			// 
			// lbl_new_pass
			// 
			this.lbl_new_pass.Location = new System.Drawing.Point(112, 32);
			this.lbl_new_pass.Name = "lbl_new_pass";
			this.lbl_new_pass.Size = new System.Drawing.Size(64, 23);
			this.lbl_new_pass.TabIndex = 4;
			this.lbl_new_pass.Text = "Å”Ê—œ ÃœÌœ";
			// 
			// lbl_confirm
			// 
			this.lbl_confirm.Location = new System.Drawing.Point(112, 56);
			this.lbl_confirm.Name = "lbl_confirm";
			this.lbl_confirm.Size = new System.Drawing.Size(64, 23);
			this.lbl_confirm.TabIndex = 5;
			this.lbl_confirm.Text = " «ÌÌœ Å”Ê—œ";
			// 
			// btn_cancel
			// 
			this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_cancel.Location = new System.Drawing.Point(16, 88);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.TabIndex = 4;
			this.btn_cancel.Text = "·€Ê";
			this.btn_cancel.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// btn_ok
			// 
			this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_ok.Location = new System.Drawing.Point(96, 88);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.TabIndex = 3;
			this.btn_ok.Text = " «ÌÌœ";
			this.btn_ok.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// frm_password_change
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(186, 120);
			this.ControlBox = false;
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.lbl_confirm);
			this.Controls.Add(this.lbl_new_pass);
			this.Controls.Add(this.lbl_old_pass);
			this.Controls.Add(this.txt_confirm);
			this.Controls.Add(this.txt_new_pass);
			this.Controls.Add(this.txt_old_pass);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frm_password_change";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ⁄ÌÌ‰ —„“ ⁄»Ê—";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.frm_password_change_Load);
			this.ResumeLayout(false);

		}
		#endregion

		public OleDbConnection cnn = new OleDbConnection(String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM options", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public DataSet ds = new DataSet();		
		public string strpwd;

		private void btn_ok_Click(object sender, System.EventArgs e)
		{
			frm_main Form_Main = new frm_main();
			Form_Main.Show();
			this.Hide();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			if (txt_old_pass.Text == strpwd)
			{
				if (txt_new_pass.Text == txt_confirm.Text)
				{
					frm_main Form_Main = new frm_main();
					Form_Main.Show();
					this.Hide();
					
					cnn.Open();
					OleDbCommand cmd = new OleDbCommand("SELECT * FROM [options] WHERE (([PassWord]=[PassWord]))", cnn);
					OleDbDataReader drr = cmd.ExecuteReader();
					while (drr.Read())
					{
						DataRow dr = ds.Tables["options"].Rows[0];

						dr.BeginEdit();
							dr["PassWord"] = txt_confirm.Text;
						dr.EndEdit();

						OleDbCommandBuilder ocb = new OleDbCommandBuilder(oda);
						ocb.QuotePrefix = "[";
						ocb.QuoteSuffix = "]";
						oda.UpdateCommand = ocb.GetUpdateCommand();
						if (oda.Update(ds, "options") == 1)
							ds.AcceptChanges();
						else
							ds.RejectChanges();
						break;
					}
					cnn.Close();
					drr.Close();
					drr =null;
					
					MessageBox.Show("—„“ ⁄»Ê— ÃœÌœ Ã«Ìê“Ì‰ ‘œ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("·ÿ›« —„“ ⁄»Ê— —«  «ÌÌœ ﬂ‰Ìœ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txt_confirm.SelectAll();
					txt_confirm.Focus();
				}
			}
			else
			{
				MessageBox.Show("—„“ ⁄»Ê— ﬁ»·Ì «‘ »«Â „Ì »«‘œ", "ÅÌ‘ê«„«‰ «‰œÌ‘Â »Ì” Ê‰", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txt_old_pass.SelectAll();
				txt_old_pass.Focus();
			}
		}

		private void frm_password_change_Load(object sender, System.EventArgs e)
		{
			cnn.Open();

			oda.Fill(ds, "options");

			OleDbCommand cmd = new OleDbCommand("SELECT * FROM options", cnn);
			OleDbDataReader drr = cmd.ExecuteReader();
			while (drr.Read())
			{
				strpwd = drr["PassWord"].ToString();
				break;
			}

			cnn.Close();
			drr.Close();
			drr = null;
		}
	}
}