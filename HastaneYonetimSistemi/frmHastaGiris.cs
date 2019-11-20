using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneYonetimSistemi
{
	public partial class frmHastaGiris : Form
	{
		public frmHastaGiris()
		{
			InitializeComponent();
		}
		SqlConn ctx = new SqlConn();

		private void linkYeniKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmHastaKayit frm = new frmHastaKayit();
			frm.Show();
			this.Hide();
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			string query = "Select * From TBLHasta Where HastaTC=@hastatc and HastaSifre=@hastasifre";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@hastatc", mskTC.Text);
			cmd.Parameters.AddWithValue("@hastasifre", txtSifre.Text);
			SqlDataReader dr = cmd.ExecuteReader();

			if (dr.Read())
			{
				frmHastaDetay frm = new frmHastaDetay();
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
	}
}
