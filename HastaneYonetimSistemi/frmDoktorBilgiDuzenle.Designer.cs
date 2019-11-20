namespace HastaneYonetimSistemi
{
	partial class frmDoktorBilgiDuzenle
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
			this.cmbBrans = new System.Windows.Forms.ComboBox();
			this.mskTC = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGeriDon = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmbBrans
			// 
			this.cmbBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbBrans.FormattingEnabled = true;
			this.cmbBrans.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
			this.cmbBrans.Location = new System.Drawing.Point(82, 94);
			this.cmbBrans.Name = "cmbBrans";
			this.cmbBrans.Size = new System.Drawing.Size(168, 24);
			this.cmbBrans.TabIndex = 4;
			// 
			// mskTC
			// 
			this.mskTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskTC.Location = new System.Drawing.Point(82, 66);
			this.mskTC.Mask = "00000000000";
			this.mskTC.Name = "mskTC";
			this.mskTC.Size = new System.Drawing.Size(168, 22);
			this.mskTC.TabIndex = 3;
			this.mskTC.ValidatingType = typeof(int);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(24, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 16);
			this.label6.TabIndex = 37;
			this.label6.Text = "Branş";
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(82, 122);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(168, 22);
			this.txtSifre.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(32, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 16);
			this.label5.TabIndex = 36;
			this.label5.Text = "Şifre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(41, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 16);
			this.label3.TabIndex = 32;
			this.label3.Text = "TC";
			// 
			// txtSoyad
			// 
			this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyad.Location = new System.Drawing.Point(82, 38);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(168, 22);
			this.txtSoyad.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(19, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 29;
			this.label2.Text = "Soyad";
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.Location = new System.Drawing.Point(141, 150);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(109, 40);
			this.btnGuncelle.TabIndex = 6;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAd.Location = new System.Drawing.Point(82, 11);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(168, 22);
			this.txtAd.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(42, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 16);
			this.label1.TabIndex = 25;
			this.label1.Text = "Ad";
			// 
			// btnGeriDon
			// 
			this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGeriDon.Location = new System.Drawing.Point(22, 150);
			this.btnGeriDon.Name = "btnGeriDon";
			this.btnGeriDon.Size = new System.Drawing.Size(109, 40);
			this.btnGeriDon.TabIndex = 38;
			this.btnGeriDon.Text = "Geri Dön";
			this.btnGeriDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnGeriDon.UseVisualStyleBackColor = true;
			this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
			// 
			// frmDoktorBilgiDuzenle
			// 
			this.AcceptButton = this.btnGuncelle;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(262, 198);
			this.Controls.Add(this.btnGeriDon);
			this.Controls.Add(this.cmbBrans);
			this.Controls.Add(this.mskTC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmDoktorBilgiDuzenle";
			this.Text = "Doktor Bilgilerini Güncelle";
			this.Load += new System.EventHandler(this.frmDoktorBilgiDuzenle_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbBrans;
		private System.Windows.Forms.MaskedTextBox mskTC;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGeriDon;
	}
}