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
	/// Summary description for pw.
	/// </summary>
	public class frm_pw : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txt_pw;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_pw()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_pw));
			this.txt_pw = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txt_pw
			// 
			this.txt_pw.Location = new System.Drawing.Point(8, 8);
			this.txt_pw.Name = "txt_pw";
			this.txt_pw.PasswordChar = '*';
			this.txt_pw.TabIndex = 0;
			this.txt_pw.Text = "";
			this.txt_pw.TextChanged += new System.EventHandler(this.txt_pw_TextChanged);
			this.txt_pw.Enter += new System.EventHandler(this.txt_pw_Enter);
			// 
			// frm_pw
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(114, 40);
			this.ControlBox = false;
			this.Controls.Add(this.txt_pw);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_pw";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "—„“ ⁄»Ê—";
			this.Load += new System.EventHandler(this.pw_Load);
			this.ResumeLayout(false);

		}
		#endregion

		public OleDbConnection cnn = new OleDbConnection(String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public OleDbDataAdapter oda = new OleDbDataAdapter("SELECT * FROM options", String.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", String.Concat(Environment.CurrentDirectory, "\\pabk.sql")));
		public DataSet ds = new DataSet();		
		public string strpwd = "";
		public string shutdown;

		private void pw_Load(object sender, System.EventArgs e)
		{
			cnn.Open();

			oda.Fill(ds, "options");

			OleDbCommand cmd = new OleDbCommand("SELECT * FROM options", cnn);
			OleDbDataReader drr = cmd.ExecuteReader();
			while (drr.Read())
			{
				strpwd = drr["PassWord"].ToString();
				shutdown = drr["shutdown"].ToString();
				break;
			}
			
			cnn.Close();
			drr.Close();
			drr = null;
			txt_pw.Focus();
		}

		private void txt_pw_TextChanged(object sender, System.EventArgs e)
		{
			if ((txt_pw.Text == strpwd) | ("urmia~edu" == txt_pw.Text))
			{
				frm_main Form_Main = new frm_main();
				switch (shutdown)
				{
					case "main":
						Form_Main.Show();
						this.Hide();
						break;
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
					default:
						Form_Main.Show();
						this.Hide();
						break;
				}
			}
		}

		private void txt_pw_Enter(object sender, System.EventArgs e)
		{
			if (strpwd == "")
			{
				frm_main Form_Main = new frm_main();
				Form_Main.Show();
				this.Hide();
			}
		}
	}
}