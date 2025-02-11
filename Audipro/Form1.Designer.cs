/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 10/2/2025
 * Time: 10:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Audipro
{
	partial class Form1
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
			this.Panel4 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// Panel4
			// 
			this.Panel4.BackColor = System.Drawing.Color.PaleTurquoise;
			this.Panel4.Location = new System.Drawing.Point(103, 24);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(642, 380);
			this.Panel4.TabIndex = 5;
			this.Panel4.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(848, 429);
			this.Controls.Add(this.Panel4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Audipro";
			this.TransparencyKey = System.Drawing.Color.Gray;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel Panel4;
	}
}
