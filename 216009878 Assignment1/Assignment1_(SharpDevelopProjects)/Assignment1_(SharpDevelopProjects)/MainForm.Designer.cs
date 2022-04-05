/*
 * Created by SharpDevelop.
 * User: Dlamini NP
 * Date: 2018/03/13
 * Time: 09:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Assignment1__SharpDevelopProjects_
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button BtnGenPool;
		private System.Windows.Forms.Button btnDrawTile;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		
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
			this.BtnGenPool = new System.Windows.Forms.Button();
			this.btnDrawTile = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnGenPool
			// 
			this.BtnGenPool.Location = new System.Drawing.Point(12, 560);
			this.BtnGenPool.Name = "BtnGenPool";
			this.BtnGenPool.Size = new System.Drawing.Size(200, 23);
			this.BtnGenPool.TabIndex = 0;
			this.BtnGenPool.Text = "Generate Pool";
			this.BtnGenPool.UseVisualStyleBackColor = true;
			this.BtnGenPool.Click += new System.EventHandler(this.BtnGenPoolClick);
			// 
			// btnDrawTile
			// 
			this.btnDrawTile.Location = new System.Drawing.Point(699, 560);
			this.btnDrawTile.Name = "btnDrawTile";
			this.btnDrawTile.Size = new System.Drawing.Size(167, 23);
			this.btnDrawTile.TabIndex = 1;
			this.btnDrawTile.Text = "DrawTile";
			this.btnDrawTile.UseVisualStyleBackColor = true;
			this.btnDrawTile.Click += new System.EventHandler(this.BtnDrawTileClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(661, 542);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(795, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(197, 223);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 585);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnDrawTile);
			this.Controls.Add(this.BtnGenPool);
			this.Name = "MainForm";
			this.Text = "Assignment1_(SharpDevelopProjects)";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
