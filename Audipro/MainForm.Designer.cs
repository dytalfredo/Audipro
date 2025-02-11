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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.BotonInicio = new Audipro.Rounded();
			this.BotonSistemas = new Audipro.Rounded();
			this.BotonProcesos = new Audipro.Rounded();
			this.BotonAuditores = new Audipro.Rounded();
			this.BotonCerrarSesion = new Audipro.Rounded();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.TopPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.Panel4.SuspendLayout();
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
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.flowLayoutPanel1.Controls.Add(this.BotonInicio);
			this.flowLayoutPanel1.Controls.Add(this.BotonSistemas);
			this.flowLayoutPanel1.Controls.Add(this.BotonProcesos);
			this.flowLayoutPanel1.Controls.Add(this.BotonAuditores);
			this.flowLayoutPanel1.Controls.Add(this.BotonCerrarSesion);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 43);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(22, 30, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 386);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// BotonInicio
			// 
			this.BotonInicio.BackColor = System.Drawing.Color.DarkBlue;
			this.BotonInicio.BackgroundColor = System.Drawing.Color.DarkBlue;
			this.BotonInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.BotonInicio.BorderRadius = 15;
			this.BotonInicio.BorderSize = 0;
			this.BotonInicio.FlatAppearance.BorderSize = 0;
			this.BotonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonInicio.Font = new System.Drawing.Font("Nunito Sans Normal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotonInicio.ForeColor = System.Drawing.Color.White;
			this.BotonInicio.Location = new System.Drawing.Point(25, 33);
			this.BotonInicio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.BotonInicio.Name = "BotonInicio";
			this.BotonInicio.Size = new System.Drawing.Size(150, 40);
			this.BotonInicio.TabIndex = 0;
			this.BotonInicio.Text = "Inicio";
			this.BotonInicio.TextColor = System.Drawing.Color.White;
			this.BotonInicio.UseVisualStyleBackColor = false;
			this.BotonInicio.Click += new System.EventHandler(this.BotonInicioClick);
			// 
			// BotonSistemas
			// 
			this.BotonSistemas.BackColor = System.Drawing.Color.Transparent;
			this.BotonSistemas.BackgroundColor = System.Drawing.Color.Transparent;
			this.BotonSistemas.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.BotonSistemas.BorderRadius = 15;
			this.BotonSistemas.BorderSize = 0;
			this.BotonSistemas.FlatAppearance.BorderSize = 0;
			this.BotonSistemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.flowLayoutPanel1.SetFlowBreak(this.BotonSistemas, true);
			this.BotonSistemas.Font = new System.Drawing.Font("Nunito Sans Normal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotonSistemas.ForeColor = System.Drawing.Color.Black;
			this.BotonSistemas.Location = new System.Drawing.Point(25, 96);
			this.BotonSistemas.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.BotonSistemas.Name = "BotonSistemas";
			this.BotonSistemas.Size = new System.Drawing.Size(150, 40);
			this.BotonSistemas.TabIndex = 1;
			this.BotonSistemas.Text = "Sistemas";
			this.BotonSistemas.TextColor = System.Drawing.Color.Black;
			this.BotonSistemas.UseVisualStyleBackColor = false;
			this.BotonSistemas.Click += new System.EventHandler(this.BotonSistemasClick);
			// 
			// BotonProcesos
			// 
			this.BotonProcesos.BackColor = System.Drawing.Color.Transparent;
			this.BotonProcesos.BackgroundColor = System.Drawing.Color.Transparent;
			this.BotonProcesos.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.BotonProcesos.BorderRadius = 15;
			this.BotonProcesos.BorderSize = 0;
			this.BotonProcesos.FlatAppearance.BorderSize = 0;
			this.BotonProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonProcesos.Font = new System.Drawing.Font("Nunito Sans Normal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotonProcesos.ForeColor = System.Drawing.Color.Black;
			this.BotonProcesos.Location = new System.Drawing.Point(25, 159);
			this.BotonProcesos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
			this.BotonProcesos.Name = "BotonProcesos";
			this.BotonProcesos.Size = new System.Drawing.Size(150, 40);
			this.BotonProcesos.TabIndex = 2;
			this.BotonProcesos.Text = "Procesos";
			this.BotonProcesos.TextColor = System.Drawing.Color.Black;
			this.BotonProcesos.UseVisualStyleBackColor = false;
			this.BotonProcesos.Click += new System.EventHandler(this.BotonProcesosClick);
			// 
			// BotonAuditores
			// 
			this.BotonAuditores.BackColor = System.Drawing.Color.Transparent;
			this.BotonAuditores.BackgroundColor = System.Drawing.Color.Transparent;
			this.BotonAuditores.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.BotonAuditores.BorderRadius = 15;
			this.BotonAuditores.BorderSize = 0;
			this.BotonAuditores.FlatAppearance.BorderSize = 0;
			this.BotonAuditores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonAuditores.Font = new System.Drawing.Font("Nunito Sans Normal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotonAuditores.ForeColor = System.Drawing.Color.Black;
			this.BotonAuditores.Location = new System.Drawing.Point(25, 222);
			this.BotonAuditores.Margin = new System.Windows.Forms.Padding(3, 3, 3, 70);
			this.BotonAuditores.Name = "BotonAuditores";
			this.BotonAuditores.Size = new System.Drawing.Size(150, 40);
			this.BotonAuditores.TabIndex = 3;
			this.BotonAuditores.Text = "Auditores";
			this.BotonAuditores.TextColor = System.Drawing.Color.Black;
			this.BotonAuditores.UseVisualStyleBackColor = false;
			this.BotonAuditores.Click += new System.EventHandler(this.BotonAuditoresClick);
			// 
			// BotonCerrarSesion
			// 
			this.BotonCerrarSesion.BackColor = System.Drawing.Color.LightSteelBlue;
			this.BotonCerrarSesion.BackgroundColor = System.Drawing.Color.LightSteelBlue;
			this.BotonCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.BotonCerrarSesion.BorderRadius = 12;
			this.BotonCerrarSesion.BorderSize = 0;
			this.BotonCerrarSesion.FlatAppearance.BorderSize = 0;
			this.BotonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BotonCerrarSesion.Font = new System.Drawing.Font("Nunito Sans Normal", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotonCerrarSesion.ForeColor = System.Drawing.Color.Black;
			this.BotonCerrarSesion.Location = new System.Drawing.Point(25, 335);
			this.BotonCerrarSesion.Name = "BotonCerrarSesion";
			this.BotonCerrarSesion.Size = new System.Drawing.Size(150, 31);
			this.BotonCerrarSesion.TabIndex = 4;
			this.BotonCerrarSesion.Text = "Cerrar Sesion";
			this.BotonCerrarSesion.TextColor = System.Drawing.Color.Black;
			this.BotonCerrarSesion.UseVisualStyleBackColor = false;
			// 
			// Panel1
			// 
			this.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(622, 360);
			this.Panel1.TabIndex = 2;
			// 
			// Panel2
			// 
			this.Panel2.BackColor = System.Drawing.Color.DarkSalmon;
			this.Panel2.Location = new System.Drawing.Point(206, 49);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(622, 360);
			this.Panel2.TabIndex = 3;
			this.Panel2.Visible = false;
			// 
			// Panel3
			// 
			this.Panel3.BackColor = System.Drawing.Color.MediumAquamarine;
			this.Panel3.Location = new System.Drawing.Point(206, 49);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(622, 360);
			this.Panel3.TabIndex = 4;
			this.Panel3.Visible = false;
			// 
			// Panel4
			// 
			this.Panel4.BackColor = System.Drawing.Color.Peru;
			this.Panel4.Controls.Add(this.Panel1);
			this.Panel4.Location = new System.Drawing.Point(206, 49);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(622, 360);
			this.Panel4.TabIndex = 6;
			this.Panel4.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(848, 429);
			this.Controls.Add(this.Panel4);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.TopPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Audipro";
			this.TransparencyKey = System.Drawing.Color.Gray;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.TopPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel Panel4;
		private System.Windows.Forms.Panel Panel3;
		private System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.Panel Panel1;
		private Audipro.Rounded BotonCerrarSesion;
		private Audipro.Rounded BotonAuditores;
		private Audipro.Rounded BotonProcesos;
		private Audipro.Rounded BotonSistemas;
		private Audipro.Rounded BotonInicio;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel PanelInicio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Audipro.Rounded ButtonSistemas;
		private Audipro.Rounded ButtonInicio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel TopPanel;
		
	
	
	}
}
