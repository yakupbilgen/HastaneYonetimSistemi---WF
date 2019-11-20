namespace HastaneYonetimSistemi
{
	partial class frmSekreterDetay
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblAdSoyad = new System.Windows.Forms.Label();
			this.lblTC = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDuyuruListesi = new System.Windows.Forms.Button();
			this.btnDuyuruOlustur = new System.Windows.Forms.Button();
			this.txtDuyuru = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnRandevuOlustur = new System.Windows.Forms.Button();
			this.btnRandevuListesi = new System.Windows.Forms.Button();
			this.cbDurum = new System.Windows.Forms.CheckBox();
			this.mskTC = new System.Windows.Forms.MaskedTextBox();
			this.cmbDoktor = new System.Windows.Forms.ComboBox();
			this.cmbBrans = new System.Windows.Forms.ComboBox();
			this.mskSaat = new System.Windows.Forms.MaskedTextBox();
			this.mskTarih = new System.Windows.Forms.MaskedTextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dgvBranslar = new System.Windows.Forms.DataGridView();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.dgvDoktorlar = new System.Windows.Forms.DataGridView();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.btnCikis = new System.Windows.Forms.Button();
			this.btnBransPaneli = new System.Windows.Forms.Button();
			this.btnDoktorPaneli = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSikayet = new System.Windows.Forms.TextBox();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBranslar)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).BeginInit();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblAdSoyad);
			this.groupBox2.Controls.Add(this.lblTC);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(210, 77);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Sekreter Bilgileri";
			// 
			// lblAdSoyad
			// 
			this.lblAdSoyad.AutoSize = true;
			this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdSoyad.Location = new System.Drawing.Point(68, 26);
			this.lblAdSoyad.Name = "lblAdSoyad";
			this.lblAdSoyad.Size = new System.Drawing.Size(60, 16);
			this.lblAdSoyad.TabIndex = 3;
			this.lblAdSoyad.Text = "null null";
			// 
			// lblTC
			// 
			this.lblTC.AutoSize = true;
			this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTC.Location = new System.Drawing.Point(68, 52);
			this.lblTC.Name = "lblTC";
			this.lblTC.Size = new System.Drawing.Size(96, 16);
			this.lblTC.TabIndex = 2;
			this.lblTC.Text = "00000000000";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "TC:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad Soyad:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDuyuruListesi);
			this.groupBox1.Controls.Add(this.btnDuyuruOlustur);
			this.groupBox1.Controls.Add(this.txtDuyuru);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(12, 95);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(210, 235);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Duyuru Oluştur";
			// 
			// btnDuyuruListesi
			// 
			this.btnDuyuruListesi.Location = new System.Drawing.Point(106, 196);
			this.btnDuyuruListesi.Name = "btnDuyuruListesi";
			this.btnDuyuruListesi.Size = new System.Drawing.Size(102, 33);
			this.btnDuyuruListesi.TabIndex = 2;
			this.btnDuyuruListesi.Text = "Duyuru Listesi";
			this.btnDuyuruListesi.UseVisualStyleBackColor = true;
			this.btnDuyuruListesi.Click += new System.EventHandler(this.btnDuyuruListesi_Click);
			// 
			// btnDuyuruOlustur
			// 
			this.btnDuyuruOlustur.Location = new System.Drawing.Point(0, 196);
			this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
			this.btnDuyuruOlustur.Size = new System.Drawing.Size(102, 33);
			this.btnDuyuruOlustur.TabIndex = 1;
			this.btnDuyuruOlustur.Text = "Duyuru Oluştur";
			this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
			this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
			// 
			// txtDuyuru
			// 
			this.txtDuyuru.Location = new System.Drawing.Point(6, 19);
			this.txtDuyuru.Multiline = true;
			this.txtDuyuru.Name = "txtDuyuru";
			this.txtDuyuru.Size = new System.Drawing.Size(198, 171);
			this.txtDuyuru.TabIndex = 0;
			this.txtDuyuru.TextChanged += new System.EventHandler(this.txtDuyuru_TextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtSikayet);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.btnRandevuOlustur);
			this.groupBox3.Controls.Add(this.btnRandevuListesi);
			this.groupBox3.Controls.Add(this.cbDurum);
			this.groupBox3.Controls.Add(this.mskTC);
			this.groupBox3.Controls.Add(this.cmbDoktor);
			this.groupBox3.Controls.Add(this.cmbBrans);
			this.groupBox3.Controls.Add(this.mskSaat);
			this.groupBox3.Controls.Add(this.mskTarih);
			this.groupBox3.Controls.Add(this.txtid);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox3.Location = new System.Drawing.Point(228, 17);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(195, 401);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Randevu Paneli";
			// 
			// btnRandevuOlustur
			// 
			this.btnRandevuOlustur.Location = new System.Drawing.Point(13, 323);
			this.btnRandevuOlustur.Name = "btnRandevuOlustur";
			this.btnRandevuOlustur.Size = new System.Drawing.Size(172, 33);
			this.btnRandevuOlustur.TabIndex = 7;
			this.btnRandevuOlustur.Text = "Randevu Oluştur";
			this.btnRandevuOlustur.UseVisualStyleBackColor = true;
			this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
			// 
			// btnRandevuListesi
			// 
			this.btnRandevuListesi.Location = new System.Drawing.Point(13, 362);
			this.btnRandevuListesi.Name = "btnRandevuListesi";
			this.btnRandevuListesi.Size = new System.Drawing.Size(172, 33);
			this.btnRandevuListesi.TabIndex = 8;
			this.btnRandevuListesi.Text = "Randevu Listesi";
			this.btnRandevuListesi.UseVisualStyleBackColor = true;
			this.btnRandevuListesi.Click += new System.EventHandler(this.btnRandevuListesi_Click);
			// 
			// cbDurum
			// 
			this.cbDurum.AutoSize = true;
			this.cbDurum.Location = new System.Drawing.Point(64, 301);
			this.cbDurum.Name = "cbDurum";
			this.cbDurum.Size = new System.Drawing.Size(66, 20);
			this.cbDurum.TabIndex = 6;
			this.cbDurum.Text = "Durum";
			this.cbDurum.UseVisualStyleBackColor = true;
			// 
			// mskTC
			// 
			this.mskTC.Location = new System.Drawing.Point(64, 171);
			this.mskTC.Mask = "00000000000";
			this.mskTC.Name = "mskTC";
			this.mskTC.Size = new System.Drawing.Size(121, 22);
			this.mskTC.TabIndex = 5;
			this.mskTC.ValidatingType = typeof(int);
			this.mskTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTC_MaskInputRejected);
			// 
			// cmbDoktor
			// 
			this.cmbDoktor.FormattingEnabled = true;
			this.cmbDoktor.Location = new System.Drawing.Point(64, 141);
			this.cmbDoktor.Name = "cmbDoktor";
			this.cmbDoktor.Size = new System.Drawing.Size(121, 24);
			this.cmbDoktor.TabIndex = 4;
			this.cmbDoktor.Text = "Doktor seçiniz.";
			// 
			// cmbBrans
			// 
			this.cmbBrans.FormattingEnabled = true;
			this.cmbBrans.Location = new System.Drawing.Point(64, 110);
			this.cmbBrans.Name = "cmbBrans";
			this.cmbBrans.Size = new System.Drawing.Size(121, 24);
			this.cmbBrans.TabIndex = 3;
			this.cmbBrans.Text = "Branş seçiniz.";
			this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
			// 
			// mskSaat
			// 
			this.mskSaat.Location = new System.Drawing.Point(64, 81);
			this.mskSaat.Mask = "00:00";
			this.mskSaat.Name = "mskSaat";
			this.mskSaat.Size = new System.Drawing.Size(121, 22);
			this.mskSaat.TabIndex = 2;
			this.mskSaat.ValidatingType = typeof(System.DateTime);
			// 
			// mskTarih
			// 
			this.mskTarih.Location = new System.Drawing.Point(64, 50);
			this.mskTarih.Mask = "00/00/0000";
			this.mskTarih.Name = "mskTarih";
			this.mskTarih.Size = new System.Drawing.Size(121, 22);
			this.mskTarih.TabIndex = 1;
			this.mskTarih.ValidatingType = typeof(System.DateTime);
			// 
			// txtid
			// 
			this.txtid.Enabled = false;
			this.txtid.Location = new System.Drawing.Point(64, 22);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(121, 22);
			this.txtid.TabIndex = 0;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(32, 174);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 16);
			this.label8.TabIndex = 5;
			this.label8.Text = "TC";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 4;
			this.label7.Text = "Doktor";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Branş";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 16);
			this.label5.TabIndex = 2;
			this.label5.Text = "Saat";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Tarih";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "İD";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dgvBranslar);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox4.Location = new System.Drawing.Point(429, 17);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(500, 200);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Branşlar";
			// 
			// dgvBranslar
			// 
			this.dgvBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBranslar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBranslar.Location = new System.Drawing.Point(3, 18);
			this.dgvBranslar.Name = "dgvBranslar";
			this.dgvBranslar.Size = new System.Drawing.Size(494, 179);
			this.dgvBranslar.TabIndex = 0;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.dgvDoktorlar);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox5.Location = new System.Drawing.Point(429, 223);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(500, 200);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Doktorlar";
			// 
			// dgvDoktorlar
			// 
			this.dgvDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDoktorlar.Location = new System.Drawing.Point(3, 18);
			this.dgvDoktorlar.Name = "dgvDoktorlar";
			this.dgvDoktorlar.Size = new System.Drawing.Size(494, 179);
			this.dgvDoktorlar.TabIndex = 0;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.btnCikis);
			this.groupBox6.Controls.Add(this.btnBransPaneli);
			this.groupBox6.Controls.Add(this.btnDoktorPaneli);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox6.Location = new System.Drawing.Point(12, 336);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(210, 84);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Hızlı Erişim";
			// 
			// btnCikis
			// 
			this.btnCikis.Location = new System.Drawing.Point(140, 21);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(65, 50);
			this.btnCikis.TabIndex = 2;
			this.btnCikis.Text = "Çıkış";
			this.btnCikis.UseVisualStyleBackColor = true;
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// btnBransPaneli
			// 
			this.btnBransPaneli.Location = new System.Drawing.Point(72, 21);
			this.btnBransPaneli.Name = "btnBransPaneli";
			this.btnBransPaneli.Size = new System.Drawing.Size(65, 50);
			this.btnBransPaneli.TabIndex = 1;
			this.btnBransPaneli.Text = "Branş Paneli";
			this.btnBransPaneli.UseVisualStyleBackColor = true;
			this.btnBransPaneli.Click += new System.EventHandler(this.btnBransPaneli_Click);
			// 
			// btnDoktorPaneli
			// 
			this.btnDoktorPaneli.Location = new System.Drawing.Point(4, 21);
			this.btnDoktorPaneli.Name = "btnDoktorPaneli";
			this.btnDoktorPaneli.Size = new System.Drawing.Size(65, 50);
			this.btnDoktorPaneli.TabIndex = 0;
			this.btnDoktorPaneli.Text = "Doktor Paneli";
			this.btnDoktorPaneli.UseVisualStyleBackColor = true;
			this.btnDoktorPaneli.Click += new System.EventHandler(this.btnDoktorPaneli_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "d/M/yyy";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(22, 457);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 7;
			this.dateTimePicker1.Visible = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 206);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 16);
			this.label9.TabIndex = 9;
			this.label9.Text = "Şikayet";
			// 
			// txtSikayet
			// 
			this.txtSikayet.Location = new System.Drawing.Point(64, 200);
			this.txtSikayet.Multiline = true;
			this.txtSikayet.Name = "txtSikayet";
			this.txtSikayet.Size = new System.Drawing.Size(121, 96);
			this.txtSikayet.TabIndex = 10;
			// 
			// frmSekreterDetay
			// 
			this.AcceptButton = this.btnDuyuruOlustur;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(939, 430);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmSekreterDetay";
			this.Text = "Sekreter Detay Ekranı";
			this.Load += new System.EventHandler(this.frmSekreterDetay_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBranslar)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblAdSoyad;
		private System.Windows.Forms.Label lblTC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDuyuruOlustur;
		private System.Windows.Forms.TextBox txtDuyuru;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnRandevuOlustur;
		private System.Windows.Forms.CheckBox cbDurum;
		private System.Windows.Forms.MaskedTextBox mskTC;
		private System.Windows.Forms.ComboBox cmbDoktor;
		private System.Windows.Forms.ComboBox cmbBrans;
		private System.Windows.Forms.MaskedTextBox mskSaat;
		private System.Windows.Forms.MaskedTextBox mskTarih;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dgvBranslar;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DataGridView dgvDoktorlar;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button btnCikis;
		private System.Windows.Forms.Button btnRandevuListesi;
		private System.Windows.Forms.Button btnBransPaneli;
		private System.Windows.Forms.Button btnDoktorPaneli;
		private System.Windows.Forms.Button btnDuyuruListesi;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox txtSikayet;
		private System.Windows.Forms.Label label9;
	}
}