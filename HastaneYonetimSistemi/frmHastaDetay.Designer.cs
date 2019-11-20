namespace HastaneYonetimSistemi
{
	partial class frmHastaDetay
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblAdSoyad = new System.Windows.Forms.Label();
			this.lblTC = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.linkBilgileriDuzenle = new System.Windows.Forms.LinkLabel();
			this.btnRandevuAl = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbDoktor = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSikayet = new System.Windows.Forms.TextBox();
			this.cmbBrans = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dgvRandevuGecmisi = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgvAktifRandevu = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRandevuGecmisi)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAktifRandevu)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblAdSoyad);
			this.groupBox1.Controls.Add(this.lblTC);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(210, 89);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hasta Bilgileri";
			// 
			// lblAdSoyad
			// 
			this.lblAdSoyad.AutoSize = true;
			this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdSoyad.Location = new System.Drawing.Point(87, 30);
			this.lblAdSoyad.Name = "lblAdSoyad";
			this.lblAdSoyad.Size = new System.Drawing.Size(60, 16);
			this.lblAdSoyad.TabIndex = 3;
			this.lblAdSoyad.Text = "null null";
			// 
			// lblTC
			// 
			this.lblTC.AutoSize = true;
			this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTC.Location = new System.Drawing.Point(87, 56);
			this.lblTC.Name = "lblTC";
			this.lblTC.Size = new System.Drawing.Size(96, 16);
			this.lblTC.TabIndex = 2;
			this.lblTC.Text = "00000000000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "TC:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad Soyad:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtid);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.linkBilgileriDuzenle);
			this.groupBox2.Controls.Add(this.btnRandevuAl);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.cmbDoktor);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtSikayet);
			this.groupBox2.Controls.Add(this.cmbBrans);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(12, 107);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(210, 299);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Randevu Bilgileri";
			// 
			// txtid
			// 
			this.txtid.Enabled = false;
			this.txtid.Location = new System.Drawing.Point(62, 28);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(134, 22);
			this.txtid.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "İD";
			// 
			// linkBilgileriDuzenle
			// 
			this.linkBilgileriDuzenle.AutoSize = true;
			this.linkBilgileriDuzenle.Location = new System.Drawing.Point(3, 266);
			this.linkBilgileriDuzenle.Name = "linkBilgileriDuzenle";
			this.linkBilgileriDuzenle.Size = new System.Drawing.Size(104, 16);
			this.linkBilgileriDuzenle.TabIndex = 5;
			this.linkBilgileriDuzenle.TabStop = true;
			this.linkBilgileriDuzenle.Text = "Bilgileri Düzenle";
			this.linkBilgileriDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBilgileriDuzenle_LinkClicked);
			// 
			// btnRandevuAl
			// 
			this.btnRandevuAl.Location = new System.Drawing.Point(106, 256);
			this.btnRandevuAl.Name = "btnRandevuAl";
			this.btnRandevuAl.Size = new System.Drawing.Size(90, 36);
			this.btnRandevuAl.TabIndex = 4;
			this.btnRandevuAl.Text = "Randevu Al";
			this.btnRandevuAl.UseVisualStyleBackColor = true;
			this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 16);
			this.label7.TabIndex = 5;
			this.label7.Text = "Şikayet";
			// 
			// cmbDoktor
			// 
			this.cmbDoktor.FormattingEnabled = true;
			this.cmbDoktor.Location = new System.Drawing.Point(62, 86);
			this.cmbDoktor.Name = "cmbDoktor";
			this.cmbDoktor.Size = new System.Drawing.Size(134, 24);
			this.cmbDoktor.TabIndex = 2;
			this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 89);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Doktor";
			// 
			// txtSikayet
			// 
			this.txtSikayet.Location = new System.Drawing.Point(62, 117);
			this.txtSikayet.Multiline = true;
			this.txtSikayet.Name = "txtSikayet";
			this.txtSikayet.Size = new System.Drawing.Size(134, 133);
			this.txtSikayet.TabIndex = 3;
			// 
			// cmbBrans
			// 
			this.cmbBrans.FormattingEnabled = true;
			this.cmbBrans.Location = new System.Drawing.Point(62, 56);
			this.cmbBrans.Name = "cmbBrans";
			this.cmbBrans.Size = new System.Drawing.Size(134, 24);
			this.cmbBrans.TabIndex = 1;
			this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Branş";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dgvRandevuGecmisi);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox4.Location = new System.Drawing.Point(242, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(550, 190);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Randevu Geçmişi";
			// 
			// dgvRandevuGecmisi
			// 
			this.dgvRandevuGecmisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvRandevuGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRandevuGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvRandevuGecmisi.Location = new System.Drawing.Point(3, 18);
			this.dgvRandevuGecmisi.Name = "dgvRandevuGecmisi";
			this.dgvRandevuGecmisi.Size = new System.Drawing.Size(544, 169);
			this.dgvRandevuGecmisi.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvAktifRandevu);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox3.Location = new System.Drawing.Point(242, 216);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(550, 190);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Aktif Randevular";
			// 
			// dgvAktifRandevu
			// 
			this.dgvAktifRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAktifRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAktifRandevu.Location = new System.Drawing.Point(3, 18);
			this.dgvAktifRandevu.Name = "dgvAktifRandevu";
			this.dgvAktifRandevu.Size = new System.Drawing.Size(544, 169);
			this.dgvAktifRandevu.TabIndex = 0;
			this.dgvAktifRandevu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAktifRandevu_CellDoubleClick);
			// 
			// frmHastaDetay
			// 
			this.AcceptButton = this.btnRandevuAl;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(807, 416);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmHastaDetay";
			this.Text = "Hasta Detayları Ekranı";
			this.Load += new System.EventHandler(this.frmHastaDetay_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvRandevuGecmisi)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAktifRandevu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblAdSoyad;
		private System.Windows.Forms.Label lblTC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnRandevuAl;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbDoktor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSikayet;
		private System.Windows.Forms.ComboBox cmbBrans;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dgvRandevuGecmisi;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dgvAktifRandevu;
		private System.Windows.Forms.LinkLabel linkBilgileriDuzenle;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label label3;
	}
}