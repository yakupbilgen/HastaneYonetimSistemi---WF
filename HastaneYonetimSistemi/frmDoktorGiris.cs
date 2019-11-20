using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetimSistemi
{
	public partial class frmDoktorGiris : Form
	{
		public frmDoktorGiris()
		{
			InitializeComponent();
		}

		SqlConn ctx = new SqlConn();

		private void btnGiris_Click(object sender, EventArgs e)
		{
			string query = "Select * From TBLDoktor Where DoktorTC=@doktortc and DoktorSifre=@doktorsifre";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@doktortc", mskTC.Text);
			cmd.Parameters.AddWithValue("@doktorsifre", txtSifre.Text);
			SqlDataReader dr = cmd.ExecuteReader();

			if (dr.Read())
			{
				frmDoktorDetay frm = new frmDoktorDetay();
				frm.TC = mskTC.Text;
				this.Hide();
				frm.Show();
			}
			else
			{
				MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz!");
				mskTC.Text = "";
				txtSifre.Text = "";
				mskTC.Focus();
			}

			ctx.Baglanti().Close();
		}

		private void linkYeniKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmDoktorPaneli frm = new frmDoktorPaneli();
			frm.Show();
			this.Hide();
		}
	}
}
