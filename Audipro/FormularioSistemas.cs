/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 15/2/2025
 * Time: 5:21 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Audipro
{
	/// <summary>
	/// Description of FormularioSistemas.
	/// </summary>
	public partial class FormularioSistemas : Form
	{
		public Sistemas datos;
		public Procesos datosProcesos;
		public Sistema sistemaActualizar = null;
		bool actualizable =false;
		public FormularioSistemas()
		{
		
			InitializeComponent();
			this.TopLevel = false;
    		this.FormBorderStyle = FormBorderStyle.None;  
    		this.WindowState = FormWindowState.Maximized;

		}
		public FormularioSistemas(Sistemas x, Procesos p)
		{

			InitializeComponent();
			this.TopLevel = false; 
    		this.FormBorderStyle = FormBorderStyle.None; 
    		this.WindowState = FormWindowState.Maximized;
		
			datos = x;
			datosProcesos=p;
			ActualizarUltimosSistemas();
			
		}
			
		
		void RegistrarBtnClick(object sender, EventArgs e)
		{
			if(CamposCompletos("Registro")&&!datos.existe(rifText.Text)&&datos.fechasCorrectas(CrearSistema())){
			   	datos.agregarSistema(CrearSistema());
			   	LimpiarInputs();
			   	MessageBox.Show("Sistema: "+CrearSistema().NombreSistema + "Creado con exito","Registro Completado",MessageBoxButtons.OK);
			   	ActualizarUltimosSistemas();
			}
						
		}
		
		public Sistema CrearSistema(){
			Sistema x = new Sistema();
			x.NombreSistema= nombreText.Text;
			x.NombreEmpresa = empresaText.Text;
			x.RifEmpresa = rifText.Text;
			x.DireccionEmpresa = direccionText.Text;
			x.FechaInicio = inputFechaInicio.Value;
			x.FechaFinal = inputFechaFinal.Value;
			x.CantidadProcesos=0;
			return x;
		}
		
		public void ActualizarUltimosSistemas(){
			
			panelUltimosSistemas.Controls.Clear();
			
			Int16 maximos= 20;
			Int16 contador=0;
			
			foreach(Sistema y in datos.Datos){
				contador++;
				if(contador>maximos){
					break;
				}
				Int16 fallas = 0;
				foreach(Int16 h in y.Procesos){
					if(datosProcesos.Consultar(h).Falla){
						fallas++;
					}
				}
			Button btnSistema = new Button();
			btnSistema.BackColor = System.Drawing.Color.PaleTurquoise;
			btnSistema.Dock = System.Windows.Forms.DockStyle.Top;
			btnSistema.FlatAppearance.BorderSize = 0;
			btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnSistema.Location = new System.Drawing.Point(0, 0);
			btnSistema.Name = "btn"+y.NombreSistema;
			btnSistema.Size = new System.Drawing.Size(267, 23);
			btnSistema.Margin = new Padding(0,10,0,10);
			btnSistema.TabIndex = 0;
			btnSistema.Tag= y;
			btnSistema.Text = "Sistema: " +y.NombreSistema+ " Procesos: " + y.Procesos.Count + " Cantidad de fallas: " + fallas;
			btnSistema.Click+= ConsultarSistemaButton;
			btnSistema.UseVisualStyleBackColor = false;
			panelUltimosSistemas.Controls.Add(btnSistema);
	
			}
			
		}
		public bool CamposCompletos(String x){
			if(String.IsNullOrWhiteSpace(nombreText.Text) || String.IsNullOrWhiteSpace(empresaText.Text)
			   || String.IsNullOrWhiteSpace(rifText.Text) || String.IsNullOrWhiteSpace(direccionText.Text)){
				MessageBox.Show("Tienes campos vacios, por favor rellenalos todos para continuar con el " + x,"Campos Faltantes", MessageBoxButtons.OK);
			return false;
			}else if(!FormatoDeRifCorrecto()){
				return false;
			}else
				{
				return FechasElegidas();
			}
		}
		
		public bool FormatoDeRifCorrecto(){
			String patron = @"^j\d{8}$";
			Regex rif = new Regex(patron);
			if(!rif.IsMatch(rifText.Text)){
			   	MessageBox.Show("El formato de rif debe ser 'j' seguido de 8 digitos numericos","Formato de Rif incorrecto",MessageBoxButtons.OK);
			   }
			return rif.IsMatch(rifText.Text);
		}
		
		public bool FechasElegidas(){
			if(inputFechaInicio.Value==inputFechaInicio.MinDate){
				MessageBox.Show("Debes elegir una fecha de Inicio");
				return false;
			}else if(inputFechaFinal.Value==inputFechaFinal.MinDate) {
				MessageBox.Show("Debes elegir una fecha de Finalización");
				return false;
			}else{
				return true;
			}}
		
		
		public void ConsultarSistemaButton(object sender, EventArgs e){
			Button botonClickeado = sender as Button;
			if(botonClickeado!=null){
				Sistema sistemaSeleccionado = botonClickeado.Tag as Sistema; // Recuperar el objeto Sistema desde la propiedad Tag
        if (sistemaSeleccionado != null)
        {
            // Llenar los TextBox con la información del sistema seleccionado
            actualizable=false;
			DesactivarInputs();
            RellenarInputs(sistemaSeleccionado);
           }
            
        }
			}
			
		
		void RellenarInputs(Sistema h){
			nombreText.Text= h.NombreSistema;
            empresaText.Text = h.NombreEmpresa;
            rifText.Text = h.RifEmpresa;
            direccionText.Text = h.DireccionEmpresa;
           inputFechaInicio.Value= h.FechaInicio;
           inputFechaFinal.Value = h.FechaFinal;
//           if(actualizable){
//           	ActivarInputs();
//           }else{
//           	DesactivarInputs();}
           panelProcesos.Controls.Clear();
           foreach(Int16 y in h.Procesos){
           	Button btnProceso = new Button();
           	if(datosProcesos.Consultar(y).Falla){
           		btnProceso.BackColor = System.Drawing.Color.OrangeRed;
           	}else{
			btnProceso.BackColor = System.Drawing.Color.PaleTurquoise;
           	}
			btnProceso.Dock = System.Windows.Forms.DockStyle.Top;
			btnProceso.FlatAppearance.BorderSize = 0;
			btnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnProceso.Location = new System.Drawing.Point(0, 0);
			btnProceso.Name = "btn"+y.ToString();
			btnProceso.Size = new System.Drawing.Size(267, 50);
			btnProceso.TabIndex = 0;
			btnProceso.Tag= y;
			btnProceso.Text = y.ToString();
			btnProceso.Click+= ConsultarSistemaButton;
			btnProceso.UseVisualStyleBackColor = false;
			panelProcesos.Controls.Add(btnProceso);
		}
	}
		
		void ConsultarBtnClick(object sender, EventArgs e)
		{
			
			Sistema h = null;
			if(String.IsNullOrWhiteSpace(rifText.Text)){
			   	MessageBox.Show("Para consultar ingresa el rif de la empresa","Falta el Rif");
			   }else{
			   	h = datos.Consultar(rifText.Text);
			   }
			if(h!=null){
				
				RellenarInputs(h);
				
			}
	}
		
		void DesactivarInputs(){
			nombreText.ReadOnly= true;
			Console.WriteLine(nombreText.ReadOnly);
            empresaText.ReadOnly= true;
            rifText.ReadOnly= true;
            direccionText.ReadOnly= true;
           inputFechaInicio.Enabled=false;
           inputFechaFinal.Enabled=false;
			
		}
		
		void ActivarInputs(){
			nombreText.ReadOnly= false;
			Console.WriteLine(nombreText.ReadOnly);
            empresaText.ReadOnly= false;
    
            direccionText.ReadOnly= false;
           inputFechaInicio.Enabled=true;
           inputFechaFinal.Enabled=true;
		}
		
		public Sistema CrearSistema(Sistema y){
			Sistema x = new Sistema();
			x.NombreSistema= nombreText.Text;
			x.NombreEmpresa = empresaText.Text;
			x.RifEmpresa = rifText.Text;
			x.DireccionEmpresa = direccionText.Text;
			x.FechaInicio = inputFechaInicio.Value;
			x.FechaFinal = inputFechaFinal.Value;
			x.CantidadProcesos=y.CantidadProcesos;
			x.Procesos = y.Procesos;
			return x;
		}
		
		
		void ActualizarBtnClick(object sender, EventArgs e)
		{
			
			if(actualizable){
				datos.ActualizarSistema(CrearSistema(sistemaActualizar), rifText.Text);
				actualizable=false;
				
			}
			if (String.IsNullOrWhiteSpace(rifText.Text)){
			    	MessageBox.Show("Para Actualizar ingresa el rif de la empresa","Falta el Rif");
			    	actualizable=false;
			    }else{
			    	sistemaActualizar= datos.Consultar(rifText.Text);
			    }
			if(sistemaActualizar!=null){
				actualizable=true;
				MessageBox.Show("Sistema listo para Actualizar");
				ActivarInputs();
				RellenarInputs(sistemaActualizar);
			}
			
		}
		
		void LimpiarInputs(){
			nombreText.Text= "";
            empresaText.Text = "";
            rifText.Text = "";
            direccionText.Text = "";
           inputFechaInicio.Value= inputFechaInicio.MinDate;
           inputFechaFinal.Value = inputFechaFinal.MinDate;
            panelProcesos.Controls.Clear();
			
		}
		
		void LimpiarBtnClick(object sender, EventArgs e)
		{
			LimpiarInputs();
			ActivarInputs();
			rifText.ReadOnly=false;
		}
	}
	}

