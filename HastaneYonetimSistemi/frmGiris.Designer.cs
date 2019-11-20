namespace HastaneYonetimSistemi
{
	partial class frmGiris
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
			this.btnHasta = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnDoktor = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnSekreter = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnHasta);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(11, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(165, 175);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hasta";
			// 
			// btnHasta
			// 
			this.btnHasta.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnHasta.BackgroundImage = global::HastaneYonetimSistemi.Properties.Resources.hasta;
			this.btnHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnHasta.Location = new System.Drawing.Point(9, 19);
			this.btnHasta.Name = "btnHasta";
			this.btnHasta.Size = new System.Drawing.Size(150, 150);
			this.btnHasta.TabIndex = 0;
			this.btnHasta.UseVisualStyleBackColor = false;
			this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnDoktor);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(191, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(165, 175);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Doktor";
			// 
			// btnDoktor
			// 
			this.btnDoktor.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnDoktor.BackgroundImage = global::HastaneYonetimSistemi.Properties.Resources.doktor;
			this.btnDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDoktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDoktor.Location = new System.Drawing.Point(9, 19);
			this.btnDoktor.Name = "btnDoktor";
			this.btnDoktor.Size = new System.Drawing.Size(150, 150);
			this.btnDoktor.TabIndex = 1;
			this.btnDoktor.UseVisualStyleBackColor = false;
			this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnSekreter);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox3.Location = new System.Drawing.Point(375, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(165, 175);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sekreter";
			// 
			// btnSekreter
			// 
			this.btnSekreter.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnSekreter.BackgroundImage = global::HastaneYonetimSistemi.Properties.Resources.sekreter;
			this.btnSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSekreter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSekreter.Location = new System.Drawing.Point(9, 19);
			this.btnSekreter.Name = "btnSekreter";
			this.btnSekreter.Size = new System.Drawing.Size(150, 150);
			this.btnSekreter.TabIndex = 2;
			this.btnSekreter.UseVisualStyleBackColor = false;
			this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
			// 
			// frmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(553, 198);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "frmGiris";
			this.Text = "Giriş";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnHasta;
		private System.Windows.Forms.Button btnDoktor;
		private System.Windows.Forms.Button btnSekreter;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
	}
}

