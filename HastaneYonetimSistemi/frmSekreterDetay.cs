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
	public partial class frmSekreterDetay : Form
	{
		public frmSekreterDetay()
		{
			InitializeComponent();
		}
		public string TC;
		SqlConn ctx = new SqlConn();

		private void frmSekreterDetay_Load(object sender, EventArgs e)
		{
			//Sekreter Ad Soyad TC bilgilerini getirme
			lblTC.Text = TC;
			string queryAdSoyad = "SELECT SekreterAd,SekreterSoyad FROM TBLSekreter WHERE SekreterTC=@sekretertc";
			SqlCommand cmd = new SqlCommand(queryAdSoyad, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@sekretertc", lblTC.Text);
			SqlDataReader drAdSoyad = cmd.ExecuteReader();
			while (drAdSoyad.Read())
			{
				lblAdSoyad.Text = drAdSoyad[0] + " " + drAdSoyad[1];
			}
			ctx.Baglanti().Close();

			//Branş bilgilerini getirme - Datagridview
			DataTable dtBransdgv = new DataTable();
			SqlDataAdapter daBransdgv = new SqlDataAdapter("SELECT * FROM TBLBrans", ctx.Baglanti());
			daBransdgv.Fill(dtBransdgv);
			dgvBranslar.DataSource = dtBransdgv;

			//Doktor bilgilerini getirme - Datagridview
			DataTable dtDoktordgv = new DataTable();
			string queryDoktorBilgi = "SELECT DoktorAd,DoktorSoyad,DoktorBrans FROM TBLDoktor";
			SqlDataAdapter daDoktordgv = new SqlDataAdapter(queryDoktorBilgi, ctx.Baglanti());
			daDoktordgv.Fill(dtDoktordgv);
			dgvDoktorlar.DataSource = dtDoktordgv;

			//Branş bilgilerini getirme - Combobox
			string queryBrans = "SELECT BransAd FROM TBLBrans";
			SqlCommand cmdBransCombo = new SqlCommand(queryBrans, ctx.Baglanti());
			SqlDataReader drBransCombo = cmdBransCombo.ExecuteReader();
			while (drBransCombo.Read())
			{
				cmbBrans.Items.Add(drBransCombo[0].ToString());
			}
			ctx.Baglanti().Close();

			if (txtDuyuru.Text=="")
			{
				btnDuyuruOlustur.Enabled = false;
			}
			if (mskTC.Text=="")
			{
				btnRandevuOlustur.Enabled = false;
			}
		}

		private void btnRandevuOlustur_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO TBLRandevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuHastaTC,RandevuDurum,RandevuHastaSikayet) " +
				"VALUES (@randevutarih,@randevusaat,@randevubrans,@randevudoktor,@randevuhastatc,@randevudurum,@randevuhastasikayet)";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@randevutarih", mskTarih.Text);
			cmd.Parameters.AddWithValue("@randevusaat", mskSaat.Text);
			cmd.Parameters.AddWithValue("@randevubrans", cmbBrans.Text);
			cmd.Parameters.AddWithValue("@randevudoktor", cmbDoktor.Text);
			cmd.Parameters.AddWithValue("@randevuhastatc", mskTC.Text);
			cmd.Parameters.AddWithValue("@randevudurum", cbDurum.Checked);
			cmd.Parameters.AddWithValue("@randevuhastasikayet", txtSikayet.Text);
			cmd.ExecuteNonQuery();
			ctx.Baglanti().Close();
			MessageBox.Show("Randevu başarıyla kaydedildi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			txtid.Text = "";
			mskTarih.Text = "";
			mskSaat.Text = "";
			cmbBrans.Text = "Branş seçiniz.";
			cmbDoktor.Text = "Doktor seçiniz.";
			mskTC.Text = "";
			cbDurum.Checked = false;
		}

		private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbDoktor.Items.Clear();
			string query = "SELECT DoktorAd,DoktorSoyad FROM TBLDoktor WHERE DoktorBrans=@doktorbrans";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@doktorbrans", cmbBrans.Text);
			SqlDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
			}
			ctx.Baglanti().Close();
		}

		private void btnDuyuruOlustur_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO TBLDuyuru (DuyuruIcerik,DuyuruTarih) VALUES (@duyuruicerik,@duyurutarih)";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@duyuruicerik", txtDuyuru.Text);
			cmd.Parameters.AddWithValue("@duyurutarih", dateTimePicker1.Value);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Duyuru oluşturuldu!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			txtDuyuru.Text = "";
			ctx.Baglanti().Close();
		}

		private void btnDoktorPaneli_Click(object sender, EventArgs e)
		{
			frmDoktorPaneli frm = new frmDoktorPaneli();
			this.Hide();
			frm.Show();
		}

		private void btnBransPaneli_Click(object sender, EventArgs e)
		{
			frmBrans frm = new frmBrans();
			this.Hide();
			frm.Show();
		}

		private void btnRandevuListesi_Click(object sender, EventArgs e)
		{
			frmRandevuListesi frm = new frmRandevuListesi();
			frm.Show();
		}

		private void btnCikis_Click(object sender, EventArgs e)
		{
			DialogResult dialog = new DialogResult();
			dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialog==DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnDuyuruListesi_Click(object sender, EventArgs e)
		{
			frmDuyurular frm = new frmDuyurular();
			frm.Show();
		}

		private void txtDuyuru_TextChanged(object sender, EventArgs e)
		{
			if (txtDuyuru.Text!="")
			{
				btnDuyuruOlustur.Enabled = true;
			}
			else
			{
				btnDuyuruOlustur.Enabled = false;
			}
		}

		private void mskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			if (mskTC.Text!="")
			{
				btnRandevuOlustur.Enabled = true;
			}
			else
			{
				btnRandevuOlustur.Enabled = false;
			}
		}
	}
}
