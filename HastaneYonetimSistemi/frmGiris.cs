using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneYonetimSistemi
{
	public partial class frmGiris : Form
	{
		public frmGiris()
		{
			InitializeComponent();
		}

		private void btnHasta_Click(object sender, EventArgs e)
		{
			frmHastaGiris frm = new frmHastaGiris();
			frm.Show();
			this.Hide();
		}

		private void btnDoktor_Click(object sender, EventArgs e)
		{
			frmDoktorGiris frm = new frmDoktorGiris();
			frm.Show();
			this.Hide();
		}

		private void btnSekreter_Click(object sender, EventArgs e)
		{
			frmSekreterGiris frm = new frmSekreterGiris();
			frm.Show();
			this.Hide();
		}
	}
}
