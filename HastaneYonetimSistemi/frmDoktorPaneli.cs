using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneYonetimSistemi
{
	public partial class frmDoktorPaneli : Form
	{
		public frmDoktorPaneli()
		{
			InitializeComponent();
		}
		SqlConn ctx = new SqlConn();

		private void frmDoktorPaneli_Load(object sender, EventArgs e)
		{
			//Doktor bilgilerini getirme - Datagridview
			DoktorGetir();

			//Branş bilgilerini getirme - Combobox
			string queryBrans = "SELECT BransAd FROM TBLBrans";
			SqlCommand cmdBransCombo = new SqlCommand(queryBrans, ctx.Baglanti());
			SqlDataReader drBransCombo = cmdBransCombo.ExecuteReader();
			while (drBransCombo.Read())
			{
				cmbBrans.Items.Add(drBransCombo[0].ToString());
			}
			ctx.Baglanti().Close();
		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			frmSekreterDetay frm = new frmSekreterDetay();
			this.Hide();
			frm.Show();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO TBLDoktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) VALUES (@doktorad,@doktorsoyad,@doktorbrans,@doktortc,@doktorsifre)";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@doktorad", txtAd.Text);
			cmd.Parameters.AddWithValue("@doktorsoyad", txtSoyad.Text);
			cmd.Parameters.AddWithValue("@doktorbrans", cmbBrans.Text);
			cmd.Parameters.AddWithValue("@doktortc", mskTC.Text);
			cmd.Parameters.AddWithValue("@doktorsifre", txtSifre.Text);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Doktor kaydetme işlemi başarılı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Temizle();
			DoktorGetir();
			ctx.Baglanti().Close();
		}

		private void dgvDoktorlar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = dgvDoktorlar.SelectedCells[0].RowIndex;
			txtAd.Text = dgvDoktorlar.Rows[id].Cells[1].Value.ToString();
			txtSoyad.Text = dgvDoktorlar.Rows[id].Cells[2].Value.ToString();
			cmbBrans.Text = dgvDoktorlar.Rows[id].Cells[3].Value.ToString();
			mskTC.Text = dgvDoktorlar.Rows[id].Cells[4].Value.ToString();
			txtSifre.Text = dgvDoktorlar.Rows[id].Cells[5].Value.ToString();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DialogResult dialog = new DialogResult();
			dialog = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialog == DialogResult.Yes)
			{
				string query = "DELETE FROM TBLDoktor WHERE DoktorTC=@doktortc";
				SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
				cmd.Parameters.AddWithValue("@doktortc", mskTC.Text);
				cmd.ExecuteNonQuery();
				ctx.Baglanti().Close();
				MessageBox.Show("Silme işlemi gerçekleşti.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Temizle();
				DoktorGetir();
			}
		}
		public void Temizle()
		{
			txtAd.Text = "";
			txtSifre.Text = "";
			txtSoyad.Text = "";
			mskTC.Text = "";
			cmbBrans.Text = "Branş seçiniz.";
		}
		public void DoktorGetir()
		{
			DataTable dtDoktordgv = new DataTable();
			SqlDataAdapter daDoktordgv = new SqlDataAdapter("SELECT * FROM TBLDoktor", ctx.Baglanti());
			daDoktordgv.Fill(dtDoktordgv);
			dgvDoktorlar.DataSource = dtDoktordgv;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			string query = "UPDATE TBLDoktor SET DoktorAd=@doktorad,DoktorSoyad=@doktorsoyad,DoktorBrans=@doktorbrans,DoktorTC=@doktortc,DoktorSifre=@doktorsifre WHERE DoktorTC=@doktortc";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@doktorad", txtAd.Text);
			cmd.Parameters.AddWithValue("@doktorsoyad", txtSoyad.Text);
			cmd.Parameters.AddWithValue("@doktorbrans", cmbBrans.Text);
			cmd.Parameters.AddWithValue("@doktortc", mskTC.Text);
			cmd.Parameters.AddWithValue("@doktorsifre", txtSifre.Text);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Doktor bilgileri başarıyla güncellendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Temizle();
			DoktorGetir();
			ctx.Baglanti().Close();
		}
	}
}
