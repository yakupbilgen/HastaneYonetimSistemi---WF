namespace HastaneYonetimSistemi
{
	partial class frmDuyurular
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
			this.dgvDuyurular = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDuyurular
			// 
			this.dgvDuyurular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDuyurular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDuyurular.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDuyurular.Location = new System.Drawing.Point(0, 0);
			this.dgvDuyurular.Name = "dgvDuyurular";
			this.dgvDuyurular.Size = new System.Drawing.Size(592, 256);
			this.dgvDuyurular.TabIndex = 0;
			// 
			// frmDuyurular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 256);
			this.Controls.Add(this.dgvDuyurular);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmDuyurular";
			this.Text = "Duyurular";
			this.Load += new System.EventHandler(this.frmDuyurular_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDuyurular)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDuyurular;
	}
}