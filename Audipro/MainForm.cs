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

// Centrar todo en el panel interno
tableLayoutPanelMain.Anchor = AnchorStyles.None;


			m = new Usuarios();
		
			
			m.Guardar();
			m.Recuperar();

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
				Usuario x = new Usuario();
				if(String.IsNullOrWhiteSpace(usuarioText.Text)){
				   	MessageBox.Show("Para iniciar sesion ingresa un nombre de usuario");
				   }else{
				try{
				x = m.Consultar(usuarioText.Text);
				if(x!=null){
					if(ContraseñaCorrecta(x)){
						MessageBox.Show("USUARIO Legeado","Inicio de Sesion");
						Form1 nuevoFormulario = new Form1(x.NombreUsuario);
						nuevoFormulario.ShowDialog();
						this.Close();
					
					}else{
						MessageBox.Show("USUARIO No Legeado","Contraseña Incorrecta");
					}}
					
				} catch(Exception ex){
					MessageBox.Show("El Usuario no se encuentra registrado", "Busqueda", MessageBoxButtons.OK);
				   	}					}}
		
	
		
		bool ContraseñaCorrecta(Usuario x){
			if(x.ContraseñaUsuario == contraseñaText.Text){
				MessageBox.Show("Contraseña Correcta","Error");
				return true;
			}else {
				
				MessageBox.Show(x.ContraseñaUsuario,"Error");
				return false;
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
			if(!labelContraseña.Visible){
				labelUsuario2.Visible=true;
			labelContraseña.Visible = true;
			}else{
			
			if(String.IsNullOrWhiteSpace(usuarioText.Text)||String.IsNullOrWhiteSpace(contraseñaText.Text))
			{
			   	MessageBox.Show("Debe Rellenar todos los campos", "Campos faltantes");
			   	
			}else if(usuarioText.Text.Contains("")){
			         MessageBox.Show("El nombre de usuario no debe tener espacios en blanco");
			         }else{
				
				
			
				if(FormatoDeCodigoCorrecto(contraseñaText.Text) && !m.existe(usuarioText.Text)){
				   	m.Datos.Add(new Usuario(usuarioText.Text,contraseñaText.Text));
				   	            m.Guardar();
				   	            m.Recuperar();
				   }
				   
			}
			
			}}
		
		void TableLayoutPanelMainPaint(object sender, PaintEventArgs e)
		{
			
		}
		
		void Panel5Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(contraseñaText.PasswordChar=='*'){
				contraseñaText.PasswordChar='\0';
			}else{
				contraseñaText.PasswordChar='*';
			}
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ContraseñaTextKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter){
				m.Recuperar();
				Usuario x = new Usuario();
				if(String.IsNullOrWhiteSpace(usuarioText.Text)){
				   	MessageBox.Show("Para iniciar sesion ingresa un nombre de usuario");
				   }else{
				try{
				x = m.Consultar(usuarioText.Text);
				if(x!=null){
					if(ContraseñaCorrecta(x)){
						MessageBox.Show("USUARIO Legeado","Inicio de Sesion");
						Form1 nuevoFormulario = new Form1(x.NombreUsuario);
						nuevoFormulario.ShowDialog();
						this.Close();
					
					}else{
						MessageBox.Show("USUARIO No Legeado","Contraseña Incorrecta");
					}}
					
				} catch(Exception ex){
					MessageBox.Show("El Usuario no se encuentra registrado", "Busqueda", MessageBoxButtons.OK);
				   	}					}
			}
    {
		}
	}
	}}
