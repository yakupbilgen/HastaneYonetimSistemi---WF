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
	public partial class frmSekreterKayit : Form
	{
		public frmSekreterKayit()
		{
			InitializeComponent();
		}
		SqlConn ctx = new SqlConn();
		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			frmSekreterGiris frm = new frmSekreterGiris();
			this.Hide();
			frm.Show();
		}

		private void btnKayitOl_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO TBLSekreter (SekreterAd,SekreterSoyad,SekreterTC,SekreterSifre) VALUES (@SekreterAd,@SekreterSoyad,@SekreterTC,@SekreterSifre)";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@SekreterAd", txtAd.Text);
			cmd.Parameters.AddWithValue("@SekreterSoyad", txtSoyad.Text);
			cmd.Parameters.AddWithValue("@SekreterTC", mskTC.Text);
			cmd.Parameters.AddWithValue("@SekreterSifre", txtSifre.Text);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Kayıt başarılı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			frmSekreterGiris frm = new frmSekreterGiris();
			this.Hide();
			frm.Show();
		}
	}
}
