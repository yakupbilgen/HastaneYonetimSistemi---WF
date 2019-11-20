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
	public partial class frmDoktorBilgiDuzenle : Form
	{
		public frmDoktorBilgiDuzenle()
		{
			InitializeComponent();
		}

		public string TC;
		SqlConn ctx = new SqlConn();

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			string query = "UPDATE TBLDoktor SET DoktorAd=@doktorad,DoktorSoyad=@doktorsoyad,DoktorBrans=@doktorbrans,DoktorSifre=@doktorsifre WHERE DoktorTC=@doktortc";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@doktorad", txtAd.Text);
			cmd.Parameters.AddWithValue("@doktorsoyad", txtSoyad.Text);
			cmd.Parameters.AddWithValue("@doktorbrans", cmbBrans.Text);
			cmd.Parameters.AddWithValue("@doktorsifre", txtSifre.Text);
			cmd.Parameters.AddWithValue("@doktortc", mskTC.Text);
			cmd.ExecuteNonQuery();
			ctx.Baglanti().Close();

			MessageBox.Show("Doktor bilgileri başarıyla güncellendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			GeriDon();
		}

		private void frmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
		{
			mskTC.Text = TC;
			//Doktor ad soyad çekme
			string queryDoktorAdSoyad = "SELECT * FROM TBLDoktor WHERE DoktorTC=@doktortc";
			SqlCommand cmdDoktorAdSoyad = new SqlCommand(queryDoktorAdSoyad,ctx.Baglanti());
			cmdDoktorAdSoyad.Parameters.AddWithValue("@doktortc", mskTC.Text);
			SqlDataReader drDoktorAdSoyad = cmdDoktorAdSoyad.ExecuteReader();
			while (drDoktorAdSoyad.Read())
			{
				txtAd.Text = drDoktorAdSoyad[1].ToString();
				txtSoyad.Text = drDoktorAdSoyad[2].ToString();
				cmbBrans.Text = drDoktorAdSoyad[3].ToString();
				txtSifre.Text = drDoktorAdSoyad[5].ToString();
			}
			ctx.Baglanti().Close();

			string queryDoktorBrans = "SELECT BransAd FROM TBLBrans";
			SqlCommand cmdBrans = new SqlCommand(queryDoktorBrans, ctx.Baglanti());
			SqlDataReader drBrans = cmdBrans.ExecuteReader();
			while (drBrans.Read())
			{
				cmbBrans.Items.Add(drBrans[0]);
			}
			ctx.Baglanti().Close();
		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			GeriDon();
		}
		public void GeriDon()
		{
			frmDoktorDetay frm = new frmDoktorDetay();
			frm.TC = mskTC.Text;
			this.Hide();
			frm.Show();
		}
	}
}
