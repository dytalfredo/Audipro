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
using System.Text.RegularExpressions;

namespace Audipro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Usuarios m;
		public MainForm()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			m = new Usuarios();
		
			
			m.Guardar();
			m.Recuperar();
			MessageBox.Show("Pausa","Mensaje");
		
			foreach(Usuario w in m.Datos)
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

		}
	
		void ReiniciarBotones(){

		}
		
		void BotonSistemasClick(object sender, EventArgs e)
		{	
		
			ReiniciarBotones();

			
			
		}
		
		void BotonProcesosClick(object sender, EventArgs e)
		{
			ReiniciarBotones();

		}
		
		void BotonAuditoresClick(object sender, EventArgs e)
		{
			ReiniciarBotones();
	
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void InicioBtnClick(object sender, EventArgs e)
		{
			
				m.Recuperar();
			
			

			foreach (Usuario x in m.Datos) {
				if(x.NombreUsuario == usurioText.Text){
					
				}else{
					MessageBox.Show("Pausa","Usuario InValido");
				}
			}
				
		}
		
		bool FormatoDeCodigoCorrecto(String texto){
			string patron = @"\d";
			string patron2 = @".{8,}";
			
			Regex numero = new Regex(patron);
			Regex ocho= new Regex(patron2);
			
			bool tieneNumero= numero.IsMatch(texto);
			bool tieneOcho = ocho.IsMatch(texto);
			
			
			if(!tieneNumero){
				MessageBox.Show("La contraseña debe tener al menos un numero","Error");
				return false;
			} 
			else if(!tieneOcho) {
				MessageBox.Show("La contraseña debe tener al menos Ocho caracteres","Error");
				return false;
			}else{
				return true;
			}
		}
		
		void CrearBtnClick(object sender, EventArgs e)
		{
			if(String.IsNullOrWhiteSpace(usurioText.Text)||String.IsNullOrWhiteSpace(contraseñaText.Text))
			{
			   	MessageBox.Show("Debe Rellenar todos los campos", "Campos faltantes");
			   	
			}else{
				if(FormatoDeCodigoCorrecto(contraseñaText.Text)){
				   	m.Datos.Add(new Usuario(usurioText.Text,contraseñaText.Text));
				   	            m.Guardar();
				   }
			}
			
		}
	}
}
