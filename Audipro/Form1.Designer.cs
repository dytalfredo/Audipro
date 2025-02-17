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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.TopPanel = new System.Windows.Forms.Panel();
			this.labelNombreUsuario = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.procesosMenuBtn = new System.Windows.Forms.Button();
			this.auditoriasMenuBtn = new System.Windows.Forms.Button();
			this.sistemaMenuBtn = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.TopPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.Color.Transparent;
			this.TopPanel.Controls.Add(this.labelNombreUsuario);
			this.TopPanel.Controls.Add(this.button3);
			this.TopPanel.Controls.Add(this.pictureBox1);
			this.TopPanel.Controls.Add(this.label1);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(848, 43);
			this.TopPanel.TabIndex = 1;
			// 
			// labelNombreUsuario
			// 
			this.labelNombreUsuario.Font = new System.Drawing.Font("Nunito Sans Normal ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombreUsuario.Location = new System.Drawing.Point(239, 0);
			this.labelNombreUsuario.Name = "labelNombreUsuario";
			this.labelNombreUsuario.Size = new System.Drawing.Size(468, 43);
			this.labelNombreUsuario.TabIndex = 3;
			this.labelNombreUsuario.Text = "Bienvenido ";
			this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelNombreUsuario.Click += new System.EventHandler(this.LabelNombreUsuarioClick);
			// 
			// button3
			// 
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Dock = System.Windows.Forms.DockStyle.Right;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Nunito Sans Normal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Red;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(724, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(124, 43);
			this.button3.TabIndex = 2;
			this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.procesosMenuBtn);
			this.panel1.Controls.Add(this.auditoriasMenuBtn);
			this.panel1.Controls.Add(this.sistemaMenuBtn);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 43);
			this.panel1.Margin = new System.Windows.Forms.Padding(30, 20, 3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 657);
			this.panel1.TabIndex = 2;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Transparent;
			this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Nunito Sans Normal Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.button5.Location = new System.Drawing.Point(0, 616);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(200, 41);
			this.button5.TabIndex = 6;
			this.button5.Text = "Cerrar Sesion";
			this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// procesosMenuBtn
			// 
			this.procesosMenuBtn.BackColor = System.Drawing.Color.Transparent;
			this.procesosMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.procesosMenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.procesosMenuBtn.FlatAppearance.BorderSize = 0;
			this.procesosMenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.procesosMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.procesosMenuBtn.Font = new System.Drawing.Font("Nunito Sans Normal Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.procesosMenuBtn.Location = new System.Drawing.Point(0, 401);
			this.procesosMenuBtn.Name = "procesosMenuBtn";
			this.procesosMenuBtn.Size = new System.Drawing.Size(211, 41);
			this.procesosMenuBtn.TabIndex = 5;
			this.procesosMenuBtn.Text = "Procesos";
			this.procesosMenuBtn.UseVisualStyleBackColor = false;
			this.procesosMenuBtn.Click += new System.EventHandler(this.ProcesosMenuBtnClick);
			// 
			// auditoriasMenuBtn
			// 
			this.auditoriasMenuBtn.BackColor = System.Drawing.Color.Transparent;
			this.auditoriasMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.auditoriasMenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.auditoriasMenuBtn.FlatAppearance.BorderSize = 0;
			this.auditoriasMenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.auditoriasMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.auditoriasMenuBtn.Font = new System.Drawing.Font("Nunito Sans Normal Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.auditoriasMenuBtn.Location = new System.Drawing.Point(0, 333);
			this.auditoriasMenuBtn.Name = "auditoriasMenuBtn";
			this.auditoriasMenuBtn.Size = new System.Drawing.Size(211, 41);
			this.auditoriasMenuBtn.TabIndex = 4;
			this.auditoriasMenuBtn.Text = "Auditores";
			this.auditoriasMenuBtn.UseVisualStyleBackColor = false;
			this.auditoriasMenuBtn.Click += new System.EventHandler(this.AuditoriasMenuBtnClick);
			// 
			// sistemaMenuBtn
			// 
			this.sistemaMenuBtn.BackColor = System.Drawing.Color.Transparent;
			this.sistemaMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.sistemaMenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.sistemaMenuBtn.FlatAppearance.BorderSize = 0;
			this.sistemaMenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.sistemaMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sistemaMenuBtn.Font = new System.Drawing.Font("Nunito Sans Normal Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sistemaMenuBtn.Location = new System.Drawing.Point(0, 264);
			this.sistemaMenuBtn.Name = "sistemaMenuBtn";
			this.sistemaMenuBtn.Size = new System.Drawing.Size(211, 41);
			this.sistemaMenuBtn.TabIndex = 3;
			this.sistemaMenuBtn.Text = "Sistemas";
			this.sistemaMenuBtn.UseVisualStyleBackColor = false;
			this.sistemaMenuBtn.Click += new System.EventHandler(this.SistemaMenuBtnClick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 258);
			this.panel3.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Nunito Sans Normal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 258);
			this.label2.TabIndex = 0;
			this.label2.Text = "Sistema de Gestion de Auditorias. Registra, organiza y consulta sistemas, proceso" +
			"s y auditores";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelContenedor
			// 
			this.panelContenedor.BackColor = System.Drawing.Color.White;
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(200, 43);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(648, 657);
			this.panelContenedor.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(848, 700);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.TopPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Audipro";
			this.TransparencyKey = System.Drawing.Color.Gray;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.TopPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button procesosMenuBtn;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button sistemaMenuBtn;
		private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.Button auditoriasMenuBtn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelNombreUsuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel TopPanel;
	}
}
