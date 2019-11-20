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
	public partial class frmHastaDetay : Form
	{
		public string TC;

		private SqlConn ctx = new SqlConn();
		public frmHastaDetay()
		{
			InitializeComponent();
		}

		private void frmHastaDetay_Load(object sender, EventArgs e)
		{
			//Ad soyad verilerini getirme.
			lblTC.Text = TC;
			string queryAdSoyad = "SELECT HastaAd,HastaSoyad FROM TBLHasta WHERE HastaTC=@hastatc";
			SqlCommand cmd = new SqlCommand(queryAdSoyad, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@hastatc", lblTC.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				lblAdSoyad.Text = dr[0] + " " + dr[1];
			}
			ctx.Baglanti().Close();

			//Branş verilerini getirme.
			string queryBrans = "SELECT BransAd FROM TBLBrans";
			SqlCommand cmd2 = new SqlCommand(queryBrans, ctx.Baglanti());
			SqlDataReader dr2 = cmd2.ExecuteReader();
			while (dr2.Read())
			{
				cmbBrans.Items.Add(dr2[0]);
			}
			ctx.Baglanti().Close();

			//Randevu geçmişi verilerini getirme.
			RandevuGecmisi();
		}
		public void RandevuGecmisi()
		{
			DataTable dt = new DataTable();
			string query = "SELECT Randevuid as [İD],RandevuTarih as [Tarih],RandevuSaat as [Saat],RandevuBrans as [Branş],RandevuDoktor as [Doktor],RandevuHastaTC as [Hasta TC],RandevuDurum  as [Durum],RandevuHastaSikayet as [Şikayet] FROM TBLRandevu WHERE RandevuHastaTC=" + TC;
			SqlDataAdapter da = new SqlDataAdapter(query, ctx.Baglanti());
			da.Fill(dt);
			dgvRandevuGecmisi.DataSource = dt;
		}
		private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbDoktor.Items.Clear();
			string queryDoktorlar = "SELECT DoktorAd,DoktorSoyad FROM TBLDoktor WHERE DoktorBrans=@doktorbrans";
			SqlCommand cmd = new SqlCommand(queryDoktorlar, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@doktorbrans", cmbBrans.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
			}
			ctx.Baglanti().Close();
		}

		private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			string query = "SELECT Randevuid as [İD],RandevuTarih as [Tarih],RandevuSaat as [Saat],RandevuBrans as [Branş],RandevuDoktor as [Doktor],RandevuHastaTC as [Hasta TC],RandevuDurum  as [Durum],RandevuHastaSikayet as [Şikayet] " +
				"FROM TBLRandevu WHERE RandevuBrans='" + cmbBrans.Text + "'" + " AND RandevuDoktor='" + cmbDoktor.Text + "' AND RandevuDurum=0";
			SqlDataAdapter da = new SqlDataAdapter(query, ctx.Baglanti());
			da.Fill(dt);
			dgvAktifRandevu.DataSource = dt;
		}

		private void linkBilgileriDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmHastaBilgiDuzenle frm = new frmHastaBilgiDuzenle();
			frm.TC = lblTC.Text;
			frm.Show();
			this.Hide();
		}

		private void btnRandevuAl_Click(object sender, EventArgs e)
		{
			string query = "UPDATE TBLRandevu SET RandevuDurum=1,RandevuHastaTC=@randevuhastatc,RandevuHastaSikayet=@randevuhastasikayet,Randevuid=@randevuid";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@randevuhastatc", lblTC.Text);
			cmd.Parameters.AddWithValue("@randevuhastasikayet", txtSikayet.Text);
			cmd.Parameters.AddWithValue("@randevuid", txtid.Text);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Randevu başarıyla kaydedildi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ctx.Baglanti().Close();
			RandevuGecmisi();
			txtid.Text = "";
			txtSikayet.Text = "";
			cmbBrans.Text = "";
			cmbDoktor.Text = "";
		}

		private void dgvAktifRandevu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = dgvAktifRandevu.SelectedCells[0].RowIndex;
			txtid.Text = dgvAktifRandevu.Rows[id].Cells[0].Value.ToString();
		}
	}
}
