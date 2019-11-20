namespace HastaneYonetimSistemi
{
	partial class frmHastaKayit
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
			this.txtAd = new System.Windows.Forms.TextBox();
			this.btnKayitOl = new System.Windows.Forms.Button();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mskTC = new System.Windows.Forms.MaskedTextBox();
			this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
			this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(43, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad";
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAd.Location = new System.Drawing.Point(83, 18);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(121, 22);
			this.txtAd.TabIndex = 0;
			// 
			// btnKayitOl
			// 
			this.btnKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKayitOl.Location = new System.Drawing.Point(106, 187);
			this.btnKayitOl.Name = "btnKayitOl";
			this.btnKayitOl.Size = new System.Drawing.Size(98, 40);
			this.btnKayitOl.TabIndex = 6;
			this.btnKayitOl.Text = "Kayıt Ol";
			this.btnKayitOl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnKayitOl.UseVisualStyleBackColor = true;
			this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
			// 
			// txtSoyad
			// 
			this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyad.Location = new System.Drawing.Point(83, 45);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(121, 22);
			this.txtSoyad.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(20, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Soyad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(42, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "TC";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(14, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Telefon";
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(83, 129);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(121, 22);
			this.txtSifre.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(33, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Şifre";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(13, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Cinsiyet";
			// 
			// mskTC
			// 
			this.mskTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskTC.Location = new System.Drawing.Point(83, 73);
			this.mskTC.Mask = "00000000000";
			this.mskTC.Name = "mskTC";
			this.mskTC.Size = new System.Drawing.Size(121, 22);
			this.mskTC.TabIndex = 2;
			this.mskTC.ValidatingType = typeof(int);
			// 
			// mskTelefon
			// 
			this.mskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskTelefon.Location = new System.Drawing.Point(83, 101);
			this.mskTelefon.Mask = "(999) 000-0000";
			this.mskTelefon.Name = "mskTelefon";
			this.mskTelefon.Size = new System.Drawing.Size(121, 22);
			this.mskTelefon.TabIndex = 3;
			// 
			// cmbCinsiyet
			// 
			this.cmbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbCinsiyet.FormattingEnabled = true;
			this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
			this.cmbCinsiyet.Location = new System.Drawing.Point(83, 157);
			this.cmbCinsiyet.Name = "cmbCinsiyet";
			this.cmbCinsiyet.Size = new System.Drawing.Size(121, 24);
			this.cmbCinsiyet.TabIndex = 5;
			// 
			// frmHastaKayit
			// 
			this.AcceptButton = this.btnKayitOl;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(220, 237);
			this.Controls.Add(this.cmbCinsiyet);
			this.Controls.Add(this.mskTelefon);
			this.Controls.Add(this.mskTC);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnKayitOl);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmHastaKayit";
			this.Text = "Hasta Kayıt Ekranı";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Button btnKayitOl;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox mskTC;
		private System.Windows.Forms.MaskedTextBox mskTelefon;
		private System.Windows.Forms.ComboBox cmbCinsiyet;
	}
}