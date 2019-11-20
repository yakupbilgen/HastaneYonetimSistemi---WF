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
	public partial class frmBrans : Form
	{
		public frmBrans()
		{
			InitializeComponent();
		}

		SqlConn ctx = new SqlConn();

		public void BransGetir()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLBrans", ctx.Baglanti());
			da.Fill(dt);
			dgvBranslar.DataSource = dt;
		}
		public void Temizle()
		{
			txtid.Text = "";
			txtAd.Text = "";
		}

		private void frmBrans_Load(object sender, EventArgs e)
		{
			BransGetir();
		}

		private void btnGeriDon_Click(object sender, EventArgs e)
		{
			frmSekreterDetay frm = new frmSekreterDetay();
			this.Hide();
			frm.Show();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO TBLBrans (BransAd) VALUES (@bransad)";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@bransad", txtAd.Text);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Branş başarıyla kaydedildi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ctx.Baglanti().Close();
			BransGetir();
			Temizle();
		}

		private void dgvBranslar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = dgvBranslar.SelectedCells[0].RowIndex;
			txtid.Text = dgvBranslar.Rows[id].Cells[0].Value.ToString();
			txtAd.Text = dgvBranslar.Rows[id].Cells[1].Value.ToString();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DialogResult dialog = new DialogResult();
			dialog = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialog == DialogResult.Yes)
			{
				string query = "DELETE FROM TBLBrans WHERE Bransid=@bransid";
				SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
				cmd.Parameters.AddWithValue("@bransid", txtid.Text);
				cmd.ExecuteNonQuery();
				MessageBox.Show("Branş başarıyla silindi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ctx.Baglanti().Close();
				BransGetir();
				Temizle();
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			string query = "UPDATE TBLBrans SET BransAd=@bransad WHERE Bransid=@bransid";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@bransid", txtid.Text);
			cmd.Parameters.AddWithValue("@bransad", txtAd.Text);
			cmd.ExecuteNonQuery();
			MessageBox.Show("Branş başarıyla güncellendi!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			ctx.Baglanti().Close();
			BransGetir();
			Temizle();
		}
	}
}
