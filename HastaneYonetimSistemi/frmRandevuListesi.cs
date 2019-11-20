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
	public partial class frmRandevuListesi : Form
	{
		public frmRandevuListesi()
		{
			InitializeComponent();
		}

		SqlConn ctx = new SqlConn();

		private void frmRandevuListesi_Load(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLRandevu ORDER BY RandevuTarih",ctx.Baglanti());
			da.Fill(dt);
			dgvRandevuListesi.DataSource = dt;
		}
		public int id;
		private void dgvRandevuListesi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			frmSekreterDetay frm = new frmSekreterDetay();
			id = dgvRandevuListesi.SelectedCells[0].RowIndex;
		}
	}
}
