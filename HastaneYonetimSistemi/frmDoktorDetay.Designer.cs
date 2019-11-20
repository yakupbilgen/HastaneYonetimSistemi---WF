namespace HastaneYonetimSistemi
{
	partial class frmDoktorDetay
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
			this.txtSikayet = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dgvRandevuListesi = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnDuyurular = new System.Windows.Forms.Button();
			this.btnBilgiDuzenle = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).BeginInit();
			this.groupBox4.SuspendLayout();
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
			this.groupBox1.Size = new System.Drawing.Size(210, 105);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Doktor Bilgileri";
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
			this.groupBox2.Controls.Add(this.txtSikayet);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(12, 123);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(210, 252);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Hasta Şikayeti";
			// 
			// txtSikayet
			// 
			this.txtSikayet.Location = new System.Drawing.Point(3, 22);
			this.txtSikayet.Multiline = true;
			this.txtSikayet.Name = "txtSikayet";
			this.txtSikayet.Size = new System.Drawing.Size(197, 224);
			this.txtSikayet.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dgvRandevuListesi);
			this.groupBox3.Location = new System.Drawing.Point(228, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(499, 436);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Randevu Listesi";
			// 
			// dgvRandevuListesi
			// 
			this.dgvRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvRandevuListesi.Location = new System.Drawing.Point(3, 16);
			this.dgvRandevuListesi.Name = "dgvRandevuListesi";
			this.dgvRandevuListesi.Size = new System.Drawing.Size(493, 417);
			this.dgvRandevuListesi.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnDuyurular);
			this.groupBox4.Controls.Add(this.btnBilgiDuzenle);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox4.Location = new System.Drawing.Point(12, 381);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(210, 67);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Hızlı Erişim";
			// 
			// btnDuyurular
			// 
			this.btnDuyurular.Location = new System.Drawing.Point(107, 16);
			this.btnDuyurular.Name = "btnDuyurular";
			this.btnDuyurular.Size = new System.Drawing.Size(97, 45);
			this.btnDuyurular.TabIndex = 1;
			this.btnDuyurular.Text = "Duyurular";
			this.btnDuyurular.UseVisualStyleBackColor = true;
			this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
			// 
			// btnBilgiDuzenle
			// 
			this.btnBilgiDuzenle.Location = new System.Drawing.Point(3, 16);
			this.btnBilgiDuzenle.Name = "btnBilgiDuzenle";
			this.btnBilgiDuzenle.Size = new System.Drawing.Size(97, 45);
			this.btnBilgiDuzenle.TabIndex = 0;
			this.btnBilgiDuzenle.Text = "Bilgilerimi Düzenle";
			this.btnBilgiDuzenle.UseVisualStyleBackColor = true;
			this.btnBilgiDuzenle.Click += new System.EventHandler(this.btnBilgiDuzenle_Click);
			// 
			// frmDoktorDetay
			// 
			this.AcceptButton = this.btnDuyurular;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(739, 457);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmDoktorDetay";
			this.Text = "Doktor Detay Ekranı";
			this.Load += new System.EventHandler(this.frmDoktorDetay_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblAdSoyad;
		private System.Windows.Forms.Label lblTC;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dgvRandevuListesi;
		private System.Windows.Forms.TextBox txtSikayet;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnDuyurular;
		private System.Windows.Forms.Button btnBilgiDuzenle;
	}
}