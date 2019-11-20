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
	public partial class frmDuyurular : Form
	{
		public frmDuyurular()
		{
			InitializeComponent();
		}

		SqlConn ctx = new SqlConn();

		private void frmDuyurular_Load(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("SELECT DuyuruIcerik as [Duyuru İçeriği],DuyuruTarih as [Duyuru Tarihi] FROM TBLDuyuru", ctx.Baglanti());
			da.Fill(dt);
			dgvDuyurular.DataSource = dt;
		}
	}
}
