/*
 * Created by SharpDevelop.
 * User: melar
 * Date: 9/2/2025
 * Time: 7:33 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Audipro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Sistemas m;
		public MainForm()
		{
			InitializeComponent();
			m = new Sistemas();
			m.Guardar();
			MessageBox.Show("Pausa","Mensaje");
			m.Recuperar();
			foreach(Sistema w in m.Datos)
			{
				MessageBox.Show(w.ToString());
			}
			
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
		
		
		void BotonInicioClick(object sender, System.EventArgs e)
		{
				
				
				ReiniciarBotones();
				Panel1.Visible=true;
			BotonInicio.BackgroundColor = Color.DarkBlue;
			BotonInicio.ForeColor = Color.WhiteSmoke;
		}
	
		void ReiniciarBotones(){
			BotonInicio.ForeColor = Color.Black;
			BotonInicio.BackgroundColor = Color.Transparent;
			BotonSistemas.ForeColor = Color.Black;
			BotonSistemas.BackgroundColor = Color.Transparent;
			BotonProcesos.ForeColor = Color.Black;
			BotonProcesos.BackgroundColor = Color.Transparent;
			BotonAuditores.ForeColor = Color.Black;
			BotonAuditores.BackgroundColor = Color.Transparent;
			Panel1.Visible=false;
			Panel2.Visible=false;
			Panel3.Visible=false;
			Panel4.Visible=false;
		}
		
		void BotonSistemasClick(object sender, EventArgs e)
		{	
		
			ReiniciarBotones();
			Panel2.Visible=true;
			BotonSistemas.BackgroundColor = Color.DarkBlue;
			BotonSistemas.ForeColor = Color.WhiteSmoke;
			
			
		}
		
		void BotonProcesosClick(object sender, EventArgs e)
		{
			ReiniciarBotones();
			Panel3.Visible=true;
			BotonProcesos.BackgroundColor = Color.DarkBlue;
			BotonProcesos.ForeColor = Color.WhiteSmoke;
		}
		
		void BotonAuditoresClick(object sender, EventArgs e)
		{
			ReiniciarBotones();
			Panel4.Visible=true;
			BotonAuditores.BackgroundColor = Color.DarkBlue;
			BotonAuditores.ForeColor = Color.WhiteSmoke;
		}
	}
}
