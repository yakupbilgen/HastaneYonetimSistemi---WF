﻿namespace HastaneYonetimSistemi
{
	partial class frmDoktorPaneli
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.cmbBrans = new System.Windows.Forms.ComboBox();
			this.mskTC = new System.Windows.Forms.MaskedTextBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.dgvDoktorlar = new System.Windows.Forms.DataGridView();
			this.btnGeriDon = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Soyad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Branş";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(34, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "TC";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Şifre";
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(69, 12);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(121, 22);
			this.txtAd.TabIndex = 0;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(69, 40);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(121, 22);
			this.txtSoyad.TabIndex = 1;
			// 
			// cmbBrans
			// 
			this.cmbBrans.FormattingEnabled = true;
			this.cmbBrans.Location = new System.Drawing.Point(69, 68);
			this.cmbBrans.Name = "cmbBrans";
			this.cmbBrans.Size = new System.Drawing.Size(121, 24);
			this.cmbBrans.TabIndex = 2;
			this.cmbBrans.Text = "Branş seçiniz.";
			// 
			// mskTC
			// 
			this.mskTC.Location = new System.Drawing.Point(69, 98);
			this.mskTC.Mask = "00000000000";
			this.mskTC.Name = "mskTC";
			this.mskTC.Size = new System.Drawing.Size(121, 22);
			this.mskTC.TabIndex = 3;
			this.mskTC.ValidatingType = typeof(int);
			// 
			// txtSifre
			// 
			this.txtSifre.Location = new System.Drawing.Point(69, 126);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(121, 22);
			this.txtSifre.TabIndex = 4;
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(12, 165);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(85, 30);
			this.btnEkle.TabIndex = 5;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(107, 165);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(85, 30);
			this.btnSil.TabIndex = 6;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(12, 201);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(85, 30);
			this.btnGuncelle.TabIndex = 7;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// dgvDoktorlar
			// 
			this.dgvDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDoktorlar.Location = new System.Drawing.Point(208, 12);
			this.dgvDoktorlar.Name = "dgvDoktorlar";
			this.dgvDoktorlar.Size = new System.Drawing.Size(620, 219);
			this.dgvDoktorlar.TabIndex = 14;
			this.dgvDoktorlar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoktorlar_CellContentDoubleClick);
			// 
			// btnGeriDon
			// 
			this.btnGeriDon.Location = new System.Drawing.Point(105, 201);
			this.btnGeriDon.Name = "btnGeriDon";
			this.btnGeriDon.Size = new System.Drawing.Size(85, 30);
			this.btnGeriDon.TabIndex = 8;
			this.btnGeriDon.Text = "Geri Dön";
			this.btnGeriDon.UseVisualStyleBackColor = true;
			this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
			// 
			// frmDoktorPaneli
			// 
			this.AcceptButton = this.btnEkle;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(840, 241);
			this.Controls.Add(this.btnGeriDon);
			this.Controls.Add(this.dgvDoktorlar);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.mskTC);
			this.Controls.Add(this.cmbBrans);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmDoktorPaneli";
			this.Text = "Doktor Paneli";
			this.Load += new System.EventHandler(this.frmDoktorPaneli_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.ComboBox cmbBrans;
		private System.Windows.Forms.MaskedTextBox mskTC;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.DataGridView dgvDoktorlar;
		private System.Windows.Forms.Button btnGeriDon;
	}
}