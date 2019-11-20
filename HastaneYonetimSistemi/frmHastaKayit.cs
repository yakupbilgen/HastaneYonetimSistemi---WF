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
	public partial class frmHastaKayit : Form
	{
		public frmHastaKayit()
		{
			InitializeComponent();
		}

		SqlConn ctx = new SqlConn();

		private void btnKayitOl_Click(object sender, EventArgs e)
		{
			string query = "INSERT INTO TBLHASTA (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) VALUES (@HastaAd,@HastaSoyad,@HastaTC,@HastaTelefon,@HastaSifre,@HastaCinsiyet)";
			SqlCommand cmd = new SqlCommand(query, ctx.Baglanti());
			cmd.Parameters.AddWithValue("@HastaAd", txtAd.Text);
			cmd.Parameters.AddWithValue("@HastaSoyad", txtSoyad.Text);
			cmd.Parameters.AddWithValue("@HastaTC", mskTC.Text);
			cmd.Parameters.AddWithValue("@HastaTelefon", mskTelefon.Text);
			cmd.Parameters.AddWithValue("@HastaSifre", txtSifre.Text);
			cmd.Parameters.AddWithValue("@HastaCinsiyet", cmbCinsiyet.Text);
			cmd.ExecuteNonQuery();
			ctx.Baglanti().Close();
			MessageBox.Show("Kayıt Başarılı");
			frmHastaGiris frm = new frmHastaGiris();
			this.Hide();
			frm.Show();
		}
	}
}
