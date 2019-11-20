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
	public partial class frmDoktorDetay : Form
	{
		public frmDoktorDetay()
		{
			InitializeComponent();
		}

		SqlConn ctx = new SqlConn();
		public string TC;

		private void frmDoktorDetay_Load(object sender, EventArgs e)
		{
			lblTC.Text = TC;

			//Doktor Ad Soyad bilgilerini getirme.
			string queryDoktorAdSoyad = "SELECT DoktorAd,DoktorSoyad FROM TBLDoktor WHERE DoktorTC=@doktortc";
			SqlCommand cmd = new SqlCommand(queryDoktorAdSoyad, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@doktortc", lblTC.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				lblAdSoyad.Text = dr[0] + " " + dr[1];
			}
			ctx.Baglanti().Close();

			//Doktor'a ait randevu bilgilerini getirme
			DataTable dtDoktorRandevulari = new DataTable();
			SqlDataAdapter daDoktorRandevulari = new SqlDataAdapter("SELECT * FROM TBLRandevu WHERE RandevuDoktor='" + lblAdSoyad.Text + "'", ctx.Baglanti());
			daDoktorRandevulari.Fill(dtDoktorRandevulari);
			dgvRandevuListesi.DataSource = dtDoktorRandevulari;
		}

		private void btnDuyurular_Click(object sender, EventArgs e)
		{
			frmDuyurular frm = new frmDuyurular();
			frm.Show();
		}

		private void btnBilgiDuzenle_Click(object sender, EventArgs e)
		{
			frmDoktorBilgiDuzenle frm = new frmDoktorBilgiDuzenle();
			frm.TC = lblTC.Text;
			frm.Show();
			this.Hide();
		}
	}
}
