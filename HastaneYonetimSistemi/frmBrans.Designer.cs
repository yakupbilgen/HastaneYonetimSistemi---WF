﻿namespace HastaneYonetimSistemi
{
	partial class frmBrans
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
			this.dgvBranslar = new System.Windows.Forms.DataGridView();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGeriDon = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvBranslar)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBranslar
			// 
			this.dgvBranslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBranslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBranslar.Location = new System.Drawing.Point(203, 12);
			this.dgvBranslar.Name = "dgvBranslar";
			this.dgvBranslar.Size = new System.Drawing.Size(444, 137);
			this.dgvBranslar.TabIndex = 28;
			this.dgvBranslar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBranslar_CellContentDoubleClick);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.Location = new System.Drawing.Point(17, 119);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(85, 30);
			this.btnGuncelle.TabIndex = 5;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = true;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
			// 
			// btnSil
			// 
			this.btnSil.Location = new System.Drawing.Point(112, 83);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(85, 30);
			this.btnSil.TabIndex = 4;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = true;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.Location = new System.Drawing.Point(17, 83);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(85, 30);
			this.btnEkle.TabIndex = 3;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(76, 43);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(121, 22);
			this.txtAd.TabIndex = 2;
			// 
			// txtid
			// 
			this.txtid.Enabled = false;
			this.txtid.Location = new System.Drawing.Point(75, 15);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(121, 22);
			this.txtid.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 16);
			this.label2.TabIndex = 16;
			this.label2.Text = "Branş Ad";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "Branş İd";
			// 
			// btnGeriDon
			// 
			this.btnGeriDon.Location = new System.Drawing.Point(112, 119);
			this.btnGeriDon.Name = "btnGeriDon";
			this.btnGeriDon.Size = new System.Drawing.Size(85, 30);
			this.btnGeriDon.TabIndex = 29;
			this.btnGeriDon.Text = "Geri Dön";
			this.btnGeriDon.UseVisualStyleBackColor = true;
			this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
			// 
			// frmBrans
			// 
			this.AcceptButton = this.btnEkle;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(658, 164);
			this.Controls.Add(this.btnGeriDon);
			this.Controls.Add(this.dgvBranslar);
			this.Controls.Add(this.btnGuncelle);
			this.Controls.Add(this.btnSil);
			this.Controls.Add(this.btnEkle);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmBrans";
			this.Text = "Branş Paneli";
			this.Load += new System.EventHandler(this.frmBrans_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvBranslar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBranslar;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGeriDon;
	}
}