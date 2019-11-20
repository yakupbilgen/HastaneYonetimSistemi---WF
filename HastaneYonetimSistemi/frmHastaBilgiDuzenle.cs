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
	public partial class frmHastaBilgiDuzenle : Form
	{
		public frmHastaBilgiDuzenle()
		{
			InitializeComponent();
		}

		SqlConn ctx = new SqlConn();
		public string TC;

		private void frmBilgiDuzenle_Load(object sender, EventArgs e)
		{
			mskTC.Text = TC;
			string query = "SELECT * FROM TBLHasta WHERE HastaTC=@hastatc";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@hastatc", mskTC.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				txtAd.Text = dr[1].ToString();
				txtSoyad.Text = dr[2].ToString();
				mskTelefon.Text = dr[4].ToString();
				txtSifre.Text = dr[5].ToString();
				cmbCinsiyet.Text = dr[6].ToString();
			}
			ctx.Baglanti().Close();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			string query = "UPDATE TBLHasta SET HastaAd=@HastaAd,HastaSoyad=@HastaSoyad,HastaTelefon=@HastaTelefon,HastaSifre=@HastaSifre,HastaCinsiyet=@HastaCinsiyet WHERE HastaTC=@hastatc";
			SqlCommand cmd = new SqlCommand(query,ctx.Baglanti());
			cmd.Parameters.AddWithValue("@HastaAd", txtAd.Text);
			cmd.Parameters.AddWithValue("@HastaSoyad", txtSoyad.Text);
			cmd.Parameters.AddWithValue("@HastaTelefon", mskTelefon.Text);
			cmd.Parameters.AddWithValue("@HastaSifre", txtSifre.Text);
			cmd.Parameters.AddWithValue("@HastaCinsiyet", cmbCinsiyet.Text);
			cmd.Parameters.AddWithValue("@hastatc", TC);
			cmd.ExecuteNonQuery();
			ctx.Baglanti().Close();
			MessageBox.Show("Hasta bilgileri başarıyla güncellendi!", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Information);
			frmHastaDetay frm = new frmHastaDetay();
			frm.TC = mskTC.Text;
			this.Hide();
			frm.Show();

		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			frmHastaDetay frm = new frmHastaDetay();
			frm.TC = mskTC.Text;
			this.Hide();
			frm.Show();
		}
	}
}
