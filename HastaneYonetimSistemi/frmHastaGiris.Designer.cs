namespace HastaneYonetimSistemi
{
	partial class frmHastaGiris
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
			this.btnGiris = new System.Windows.Forms.Button();
			this.linkYeniKayit = new System.Windows.Forms.LinkLabel();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mskTC = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(13, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "TC Kimlik No";
			// 
			// btnGiris
			// 
			this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGiris.Location = new System.Drawing.Point(159, 76);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(85, 43);
			this.btnGiris.TabIndex = 2;
			this.btnGiris.Text = "Giriş Yap";
			this.btnGiris.UseVisualStyleBackColor = true;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// linkYeniKayit
			// 
			this.linkYeniKayit.AutoSize = true;
			this.linkYeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.linkYeniKayit.Location = new System.Drawing.Point(250, 34);
			this.linkYeniKayit.Name = "linkYeniKayit";
			this.linkYeniKayit.Size = new System.Drawing.Size(67, 16);
			this.linkYeniKayit.TabIndex = 3;
			this.linkYeniKayit.TabStop = true;
			this.linkYeniKayit.Text = "Yeni Kayıt";
			this.linkYeniKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkYeniKayit_LinkClicked);
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(104, 48);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.PasswordChar = '*';
			this.txtSifre.Size = new System.Drawing.Size(140, 22);
			this.txtSifre.TabIndex = 1;
			this.txtSifre.Text = "1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(63, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Şifre";
			// 
			// mskTC
			// 
			this.mskTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.mskTC.Location = new System.Drawing.Point(104, 18);
			this.mskTC.Mask = "00000000000";
			this.mskTC.Name = "mskTC";
			this.mskTC.Size = new System.Drawing.Size(140, 22);
			this.mskTC.TabIndex = 0;
			this.mskTC.Text = "11111111111";
			this.mskTC.ValidatingType = typeof(int);
			// 
			// frmHastaGiris
			// 
			this.AcceptButton = this.btnGiris;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(330, 131);
			this.Controls.Add(this.mskTC);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.linkYeniKayit);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmHastaGiris";
			this.Text = "Hasta Giriş Ekranı";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.LinkLabel linkYeniKayit;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox mskTC;
	}
}