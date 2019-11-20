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
	public partial class frmSekreterGiris : Form
	{
		public frmSekreterGiris()
		{
			InitializeComponent();
		}
		SqlConn ctx = new SqlConn();
		private void linkYeniKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmSekreterKayit frm = new frmSekreterKayit();
			this.Hide();
			frm.Show();
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			string query = "SELECT * FROM TBLSekreter WHERE SekreterTC=@sekretertc AND SekreterSifre=@sekretersifre";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@sekretertc", mskTC.Text);
			cmd.Parameters.AddWithValue("@sekretersifre", txtSifre.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				frmSekreterDetay frm = new frmSekreterDetay();
				frm.TC = mskTC.Text;
				frm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Lütfen bilgilerini kontrol ediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			ctx.Baglanti().Close();
		}
	}
}
