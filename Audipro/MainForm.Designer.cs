/*
 * Created by SharpDevelop.
 * User: melar
 * Date: 9/2/2025
 * Time: 7:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Audipro
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
			this.TopPanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonSistemas = new Audipro.Rounded();
			this.ButtonInicio = new Audipro.Rounded();
			this.PanelInicio = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.crearBtn = new System.Windows.Forms.Button();
			this.inicioBtn = new System.Windows.Forms.Button();
			this.contraseñaText = new System.Windows.Forms.TextBox();
			this.usurioText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TopPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.Color.Transparent;
			this.TopPanel.Controls.Add(this.pictureBox1);
			this.TopPanel.Controls.Add(this.label1);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(848, 43);
			this.TopPanel.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(14, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 37);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Nunito Sans Normal Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Audipro";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonSistemas
			// 
			this.ButtonSistemas.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.ButtonSistemas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.ButtonSistemas.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.ButtonSistemas.BorderRadius = 20;
			this.ButtonSistemas.BorderSize = 0;
			this.ButtonSistemas.FlatAppearance.BorderSize = 0;
			this.ButtonSistemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonSistemas.ForeColor = System.Drawing.Color.White;
			this.ButtonSistemas.Location = new System.Drawing.Point(0, 0);
			this.ButtonSistemas.Name = "ButtonSistemas";
			this.ButtonSistemas.Size = new System.Drawing.Size(150, 40);
			this.ButtonSistemas.TabIndex = 0;
			this.ButtonSistemas.TextColor = System.Drawing.Color.White;
			this.ButtonSistemas.UseVisualStyleBackColor = false;
			// 
			// ButtonInicio
			// 
			this.ButtonInicio.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.ButtonInicio.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.ButtonInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.ButtonInicio.BorderRadius = 20;
			this.ButtonInicio.BorderSize = 0;
			this.ButtonInicio.FlatAppearance.BorderSize = 0;
			this.ButtonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonInicio.ForeColor = System.Drawing.Color.White;
			this.ButtonInicio.Location = new System.Drawing.Point(0, 0);
			this.ButtonInicio.Name = "ButtonInicio";
			this.ButtonInicio.Size = new System.Drawing.Size(150, 40);
			this.ButtonInicio.TabIndex = 0;
			this.ButtonInicio.TextColor = System.Drawing.Color.White;
			this.ButtonInicio.UseVisualStyleBackColor = false;
			// 
			// PanelInicio
			// 
			this.PanelInicio.Location = new System.Drawing.Point(0, 0);
			this.PanelInicio.Name = "PanelInicio";
			this.PanelInicio.Size = new System.Drawing.Size(200, 100);
			this.PanelInicio.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.crearBtn);
			this.panel1.Controls.Add(this.inicioBtn);
			this.panel1.Controls.Add(this.contraseñaText);
			this.panel1.Controls.Add(this.usurioText);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(848, 386);
			this.panel1.TabIndex = 1;
			// 
			// crearBtn
			// 
			this.crearBtn.Location = new System.Drawing.Point(437, 292);
			this.crearBtn.Name = "crearBtn";
			this.crearBtn.Size = new System.Drawing.Size(113, 23);
			this.crearBtn.TabIndex = 6;
			this.crearBtn.Text = "Crear Usuario";
			this.crearBtn.UseVisualStyleBackColor = true;
			this.crearBtn.Click += new System.EventHandler(this.CrearBtnClick);
			// 
			// inicioBtn
			// 
			this.inicioBtn.Location = new System.Drawing.Point(208, 292);
			this.inicioBtn.Name = "inicioBtn";
			this.inicioBtn.Size = new System.Drawing.Size(113, 23);
			this.inicioBtn.TabIndex = 4;
			this.inicioBtn.Text = "Iniciar Sesión";
			this.inicioBtn.UseVisualStyleBackColor = true;
			this.inicioBtn.Click += new System.EventHandler(this.InicioBtnClick);
			// 
			// contraseñaText
			// 
			this.contraseñaText.Location = new System.Drawing.Point(299, 215);
			this.contraseñaText.Name = "contraseñaText";
			this.contraseñaText.Size = new System.Drawing.Size(176, 20);
			this.contraseñaText.TabIndex = 3;
			// 
			// usurioText
			// 
			this.usurioText.Location = new System.Drawing.Point(299, 129);
			this.usurioText.Name = "usurioText";
			this.usurioText.Size = new System.Drawing.Size(176, 20);
			this.usurioText.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(299, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Contraseña";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(299, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nombre de Usuario";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(848, 429);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.TopPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Audipro";
			this.TransparencyKey = System.Drawing.Color.Gray;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.TopPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox usurioText;
		private System.Windows.Forms.TextBox contraseñaText;
		private System.Windows.Forms.Button inicioBtn;
		private System.Windows.Forms.Button crearBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel PanelInicio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Audipro.Rounded ButtonSistemas;
		private Audipro.Rounded ButtonInicio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel TopPanel;
		
	
	
	}
}
