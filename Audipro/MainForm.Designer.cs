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
			this.PanelInicio = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.usuarioText = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.contraseñaText = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.crearBtn = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.inicioBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.labelUsuario2 = new System.Windows.Forms.Label();
			this.labelUsuario = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.TopPanel = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.labelContraseña = new System.Windows.Forms.Label();
			this.tableLayoutPanelMain.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.TopPanel.SuspendLayout();
			this.SuspendLayout();
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
			this.label3.TabIndex = 10;
			// 
			// tableLayoutPanelMain
			// 
			this.tableLayoutPanelMain.AutoSize = true;
			this.tableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanelMain.ColumnCount = 3;
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.82547F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.23585F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.93868F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelMain.Controls.Add(this.labelContraseña, 2, 2);
			this.tableLayoutPanelMain.Controls.Add(this.panel3, 1, 1);
			this.tableLayoutPanelMain.Controls.Add(this.panel1, 1, 2);
			this.tableLayoutPanelMain.Controls.Add(this.panel5, 1, 3);
			this.tableLayoutPanelMain.Controls.Add(this.label5, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.labelUsuario2, 2, 1);
			this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 43);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 5;
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
			this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanelMain.Size = new System.Drawing.Size(848, 386);
			this.tableLayoutPanelMain.TabIndex = 1;
			this.tableLayoutPanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanelMainPaint);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.usuarioText);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Location = new System.Drawing.Point(221, 66);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(419, 48);
			this.panel3.TabIndex = 20;
			// 
			// usuarioText
			// 
			this.usuarioText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usuarioText.Font = new System.Drawing.Font("Nunito Sans Normal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usuarioText.Location = new System.Drawing.Point(148, 12);
			this.usuarioText.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
			this.usuarioText.Name = "usuarioText";
			this.usuarioText.Size = new System.Drawing.Size(268, 29);
			this.usuarioText.TabIndex = 0;
			this.usuarioText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label4);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Margin = new System.Windows.Forms.Padding(0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(102, 48);
			this.panel4.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Nunito Sans Normal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 40);
			this.label4.TabIndex = 11;
			this.label4.Text = "Usuario";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.contraseñaText);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(221, 121);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(419, 47);
			this.panel1.TabIndex = 21;
			// 
			// contraseñaText
			// 
			this.contraseñaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.contraseñaText.Font = new System.Drawing.Font("Nunito Sans Normal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contraseñaText.Location = new System.Drawing.Point(148, 12);
			this.contraseñaText.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
			this.contraseñaText.Name = "contraseñaText";
			this.contraseñaText.PasswordChar = '*';
			this.contraseñaText.Size = new System.Drawing.Size(268, 29);
			this.contraseñaText.TabIndex = 1;
			this.contraseñaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.contraseñaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseñaTextKeyPress);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(102, 47);
			this.panel2.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Nunito Sans Normal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 40);
			this.label2.TabIndex = 9;
			this.label2.Text = "Contraseña";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(221, 174);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(419, 188);
			this.panel5.TabIndex = 3;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5Paint);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.button1);
			this.panel7.Controls.Add(this.crearBtn);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel7.Location = new System.Drawing.Point(236, 0);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(0, 75, 0, 75);
			this.panel7.Size = new System.Drawing.Size(183, 188);
			this.panel7.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SkyBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Nunito Sans Normal", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(66, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 24);
			this.button1.TabIndex = 20;
			this.button1.Text = "Mostrar Contraseña";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// crearBtn
			// 
			this.crearBtn.BackColor = System.Drawing.Color.MidnightBlue;
			this.crearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.crearBtn.FlatAppearance.BorderSize = 0;
			this.crearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.crearBtn.Font = new System.Drawing.Font("Nunito Sans Normal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.crearBtn.ForeColor = System.Drawing.Color.White;
			this.crearBtn.Location = new System.Drawing.Point(0, 75);
			this.crearBtn.Name = "crearBtn";
			this.crearBtn.Size = new System.Drawing.Size(183, 38);
			this.crearBtn.TabIndex = 4;
			this.crearBtn.Text = "Crear Usuario";
			this.crearBtn.UseVisualStyleBackColor = false;
			this.crearBtn.Click += new System.EventHandler(this.CrearBtnClick);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.inicioBtn);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(0, 75, 0, 75);
			this.panel6.Size = new System.Drawing.Size(190, 188);
			this.panel6.TabIndex = 4;
			// 
			// inicioBtn
			// 
			this.inicioBtn.BackColor = System.Drawing.Color.SteelBlue;
			this.inicioBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inicioBtn.FlatAppearance.BorderSize = 0;
			this.inicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.inicioBtn.Font = new System.Drawing.Font("Nunito Sans Normal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inicioBtn.ForeColor = System.Drawing.Color.White;
			this.inicioBtn.Location = new System.Drawing.Point(0, 75);
			this.inicioBtn.Name = "inicioBtn";
			this.inicioBtn.Size = new System.Drawing.Size(190, 38);
			this.inicioBtn.TabIndex = 3;
			this.inicioBtn.Text = "Iniciar Sesion";
			this.inicioBtn.UseVisualStyleBackColor = false;
			this.inicioBtn.Click += new System.EventHandler(this.InicioBtnClick);
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Nunito Sans Normal Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(221, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(419, 63);
			this.label5.TabIndex = 12;
			this.label5.Text = "Bienvenido a Audipro";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelUsuario2
			// 
			this.labelUsuario2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelUsuario2.ForeColor = System.Drawing.Color.DimGray;
			this.labelUsuario2.Location = new System.Drawing.Point(646, 63);
			this.labelUsuario2.Name = "labelUsuario2";
			this.labelUsuario2.Size = new System.Drawing.Size(199, 55);
			this.labelUsuario2.TabIndex = 7;
			this.labelUsuario2.Text = "Ingrese un usuario no registrado.\r\n";
			this.labelUsuario2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelUsuario2.Visible = false;
			// 
			// labelUsuario
			// 
			this.labelUsuario.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
			this.labelUsuario.Location = new System.Drawing.Point(300, 500);
			this.labelUsuario.Name = "labelUsuario";
			this.labelUsuario.Size = new System.Drawing.Size(300, 200);
			this.labelUsuario.TabIndex = 0;
			this.labelUsuario.Text = "dasdasdasdasd\r\nasdklanwlñd hawnidhaclwd\r\nasdñ-k ahwobdhacoiwdh\r\n6a wdñ{lkjaclbwhd" +
			"awd\r\n";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Nunito Sans Normal Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Audipro";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.Color.Transparent;
			this.TopPanel.Controls.Add(this.button2);
			this.TopPanel.Controls.Add(this.pictureBox1);
			this.TopPanel.Controls.Add(this.label1);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(848, 43);
			this.TopPanel.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Dock = System.Windows.Forms.DockStyle.Right;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Nunito Sans Normal Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Red;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(724, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(124, 43);
			this.button2.TabIndex = 15;
			this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// labelContraseña
			// 
			this.labelContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelContraseña.ForeColor = System.Drawing.Color.DimGray;
			this.labelContraseña.Location = new System.Drawing.Point(646, 118);
			this.labelContraseña.Name = "labelContraseña";
			this.labelContraseña.Size = new System.Drawing.Size(199, 53);
			this.labelContraseña.TabIndex = 6;
			this.labelContraseña.Text = "Ingresa una contraseña con al menos 8 digitos y un numero\r\n";
			this.labelContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelContraseña.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(848, 429);
			this.Controls.Add(this.tableLayoutPanelMain);
			this.Controls.Add(this.TopPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Audipro";
			this.TransparencyKey = System.Drawing.Color.Gray;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.TopPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labelUsuario2;
		private System.Windows.Forms.Label labelContraseña;
		private System.Windows.Forms.Label labelUsuario;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button crearBtn;
		private System.Windows.Forms.Button inicioBtn;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox usuarioText;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox contraseñaText;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel PanelInicio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel TopPanel;
		
	
	
	}
}
