/*
 * Created by SharpDevelop.
 * User: CC2_PC16
 * Date: 21/11/2024
 * Time: 07:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ght
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblTITULO = new System.Windows.Forms.Label();
			this.pnlBOTONES = new System.Windows.Forms.Panel();
			this.btnDT = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnlBOTONES.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTITULO
			// 
			this.lblTITULO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lblTITULO.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTITULO.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lblTITULO.Location = new System.Drawing.Point(13, 9);
			this.lblTITULO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTITULO.Name = "lblTITULO";
			this.lblTITULO.Size = new System.Drawing.Size(524, 98);
			this.lblTITULO.TabIndex = 0;
			this.lblTITULO.Text = "Costo de realizar un tapete de aserrín.";
			// 
			// pnlBOTONES
			// 
			this.pnlBOTONES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.pnlBOTONES.AutoScroll = true;
			this.pnlBOTONES.BackColor = System.Drawing.Color.SteelBlue;
			this.pnlBOTONES.Controls.Add(this.btnDT);
			this.pnlBOTONES.Location = new System.Drawing.Point(576, 0);
			this.pnlBOTONES.Margin = new System.Windows.Forms.Padding(4);
			this.pnlBOTONES.Name = "pnlBOTONES";
			this.pnlBOTONES.Size = new System.Drawing.Size(319, 508);
			this.pnlBOTONES.TabIndex = 1;
			// 
			// btnDT
			// 
			this.btnDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDT.Location = new System.Drawing.Point(93, 258);
			this.btnDT.Margin = new System.Windows.Forms.Padding(4);
			this.btnDT.Name = "btnDT";
			this.btnDT.Size = new System.Drawing.Size(146, 34);
			this.btnDT.TabIndex = 0;
			this.btnDT.Text = "Calculo del tapete";
			this.btnDT.UseVisualStyleBackColor = true;
			this.btnDT.Click += new System.EventHandler(this.BtnDTClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(105, 140);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(376, 254);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(888, 501);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pnlBOTONES);
			this.Controls.Add(this.lblTITULO);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "ght";
			this.pnlBOTONES.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnDT;
		private System.Windows.Forms.Panel pnlBOTONES;
		private System.Windows.Forms.Label lblTITULO;
	}
}
