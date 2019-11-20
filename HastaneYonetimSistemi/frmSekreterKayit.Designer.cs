namespace HastaneYonetimSistemi
{
	partial class frmSekreterKayit
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
			this.mskTC = new System.Windows.Forms.MaskedTextBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnKayitOl = new System.Windows.Forms.Button();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGeriDon = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mskTC
			// 
			this.mskTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskTC.Location = new System.Drawing.Point(91, 75);
			this.mskTC.Mask = "00000000000";
			this.mskTC.Name = "mskTC";
			this.mskTC.Size = new System.Drawing.Size(121, 22);
			this.mskTC.TabIndex = 2;
			this.mskTC.ValidatingType = typeof(int);
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(91, 103);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(121, 22);
			this.txtSifre.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(41, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 16);
			this.label5.TabIndex = 23;
			this.label5.Text = "Şifre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(50, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 16);
			this.label3.TabIndex = 19;
			this.label3.Text = "TC";
			// 
			// txtSoyad
			// 
			this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyad.Location = new System.Drawing.Point(91, 47);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(121, 22);
			this.txtSoyad.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(28, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 16;
			this.label2.Text = "Soyad";
			// 
			// btnKayitOl
			// 
			this.btnKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKayitOl.Location = new System.Drawing.Point(114, 131);
			this.btnKayitOl.Name = "btnKayitOl";
			this.btnKayitOl.Size = new System.Drawing.Size(98, 40);
			this.btnKayitOl.TabIndex = 4;
			this.btnKayitOl.Text = "Kayıt Ol";
			this.btnKayitOl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnKayitOl.UseVisualStyleBackColor = true;
			this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
			// 
			// txtAd
			// 
			this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAd.Location = new System.Drawing.Point(91, 20);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(121, 22);
			this.txtAd.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(51, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Ad";
			// 
			// btnGeriDon
			// 
			this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGeriDon.Location = new System.Drawing.Point(11, 131);
			this.btnGeriDon.Name = "btnGeriDon";
			this.btnGeriDon.Size = new System.Drawing.Size(98, 40);
			this.btnGeriDon.TabIndex = 5;
			this.btnGeriDon.Text = "Geri Dön";
			this.btnGeriDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnGeriDon.UseVisualStyleBackColor = true;
			this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
			// 
			// frmSekreterKayit
			// 
			this.AcceptButton = this.btnKayitOl;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(224, 181);
			this.Controls.Add(this.btnGeriDon);
			this.Controls.Add(this.mskTC);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnKayitOl);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.label1);
			this.Name = "frmSekreterKayit";
			this.Text = "Sekreter Kayıt";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MaskedTextBox mskTC;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnKayitOl;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGeriDon;
	}
}