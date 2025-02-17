/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 10/2/2025
 * Time: 10:43 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Audipro
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Sistemas s;
		public Auditores a;
		public Procesos p;
		
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			s = new Sistemas();
			a = new Auditores();
			p = new Procesos();
			
			p.Guardar();
			p.Recuperar();
			a.Guardar();
			a.Recuperar();
			s.Guardar();
			s.Recuperar();
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			
			FormularioSistemas nuevo = new FormularioSistemas(s,p);
			nuevo.TopLevel=false;
			nuevo.Dock = DockStyle.Fill;
			
			panelContenedor.Controls.Add(nuevo);
			nuevo.Show();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public Form1(string x)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			s = new Sistemas();
			a = new Auditores();
			p = new Procesos();
			
			p.Guardar();
			p.Recuperar();
			
			a.Guardar();
			a.Recuperar();
			
			s.Guardar();
			s.Recuperar();
	
			InitializeComponent();
			
			FormularioSistemas nuevo = new FormularioSistemas(s, p);
			nuevo.TopLevel=false;
			nuevo.Dock = DockStyle.Fill;
			this.WindowState = FormWindowState.Maximized;
			labelNombreUsuario.Text= "Bienvenido " + x;
			panelContenedor.Controls.Add(nuevo);
			nuevo.Show();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void Form1_Paint(object sender, PaintEventArgs e)
{
    // 1. Crea el LinearGradientBrush
    Rectangle rect = new Rectangle(0, 0, this.Width, this.Height); // Tamaño del formulario
    Color startColor = Color.Honeydew; // Color de inicio
    Color endColor = Color.PaleTurquoise; // Color de fin
    float angle = 45f; // Ángulo del degradado
    LinearGradientBrush gradientBrush = new LinearGradientBrush(rect, startColor, endColor, angle);

    // 2. Pinta el fondo del formulario
    e.Graphics.FillRectangle(gradientBrush, rect);
}
		
		
		void Button3Click(object sender, EventArgs e)
		{
			MainForm nuevoFormulario = new MainForm();
			this.Close();
			
		}
		
		void SistemaMenuBtnClick(object sender, EventArgs e)
		{
			reiniciarBotonesMenu();
			sistemaMenuBtn.BackColor= Color.White;
			panelContenedor.Controls.Clear();
			FormularioSistemas nuevo = new FormularioSistemas(s, p);
			nuevo.TopLevel=false;
			nuevo.Dock = DockStyle.Fill;
			
			panelContenedor.Controls.Add(nuevo);
			nuevo.Show();
		}
		
		public void reiniciarBotonesMenu(){
			sistemaMenuBtn.BackColor= Color.Transparent;
			auditoriasMenuBtn.BackColor= Color.Transparent;
			procesosMenuBtn.BackColor= Color.Transparent;
			panelContenedor.Controls.Clear();
		}
		
		void AuditoriasMenuBtnClick(object sender, EventArgs e)
		{
			reiniciarBotonesMenu();
			auditoriasMenuBtn.BackColor = Color.White;			
			panelContenedor.Controls.Clear();
			FormularioAuditores nuevo = new FormularioAuditores(a);
			nuevo.TopLevel=false;
			nuevo.Dock = DockStyle.Fill;
			
			panelContenedor.Controls.Add(nuevo);
			nuevo.Show();
		}
		
		void ProcesosMenuBtnClick(object sender, EventArgs e)
		{
			reiniciarBotonesMenu();
			procesosMenuBtn.BackColor = Color.White;	
			panelContenedor.Controls.Clear();
			FormularoProcesos nuevo = new FormularoProcesos(p,s,a);
			nuevo.TopLevel=false;
			nuevo.Dock = DockStyle.Fill;
			
			panelContenedor.Controls.Add(nuevo);
			nuevo.Show();			
		}
		
		void LabelNombreUsuarioClick(object sender, EventArgs e)
		{
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			MainForm nuevoFormulario = new MainForm();
			nuevoFormulario.ShowDialog();
			this.Close();
		}
	}
}
