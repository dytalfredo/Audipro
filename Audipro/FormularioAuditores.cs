/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 16/2/2025
 * Time: 1:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Audipro
{
	/// <summary>
	/// Description of FormularioAuditores.
	/// </summary>
	public partial class FormularioAuditores : Form
	{
		public Auditores datos;
		public Auditor auditorActualizar = null;
		bool actualizable =false;
		public FormularioAuditores()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.TopLevel = false; // ¡Importante!
    		this.FormBorderStyle = FormBorderStyle.None; // 
    		this.WindowState = FormWindowState.Maximized;
    		ActualizarUltimosAuditores();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public FormularioAuditores(Auditores x)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			InitializeComponent();
			this.TopLevel = false; // ¡Importante!
    		this.FormBorderStyle = FormBorderStyle.None; // 
    		this.WindowState = FormWindowState.Maximized;
    		datos = x;
    		ActualizarUltimosAuditores();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label5Click(object sender, EventArgs e)
		{
			
		}
		
		void TableLayoutPanel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void RegistrarBtnClick(object sender, EventArgs e)
		{
			if(CamposCompletos("Registro")&&!datos.existe(cedulaText.Text)&&MayorEdad()){
			   	datos.agregarAuditor(CrearAuditor());
			   	MessageBox.Show("Auditor: "+CrearAuditor().Nombres + "Creado con exito","Registro Completado",MessageBoxButtons.OK);
			   	ActualizarUltimosAuditores();
			   	ClearInputs();
			}
			
		}
		
		public Boolean MayorEdad(){
			if((DateTime.Today.Year-inputNacimiento.Value.Year)>=18){
				return true;
			}else{
				MessageBox.Show("Solo se contrata personal mayor de edad");
				return false;
				
			}
			
		}
		
		public Auditor CrearAuditor(){
			Auditor x = new Auditor();
			x.Cedula = cedulaText.Text;
			x.Nombres = nombreText.Text;
			x.Apellidos = apellidoText.Text;
			x.Direccion = direccionText.Text;
			x.Sexo = Convert.ToChar(comboSexo.Text);
			x.TituloGrado = comboTitulo.Text;
			x.Activo = checkActivo.Checked;
			x.CantidadProcesos=0;
			x.FechaNacimiento = inputNacimiento.Value;
			x.FechaIngreso = inputIngreso.Value;
			return x;
		}
		
		public Auditor CrearAuditor(Auditor y){
			Auditor x = new Auditor();
		x.Cedula = cedulaText.Text;
			x.Nombres = nombreText.Text;
			x.Apellidos = apellidoText.Text;
			x.Direccion = direccionText.Text;
			x.Sexo = Convert.ToChar(comboSexo.Text);
			x.TituloGrado = comboTitulo.Text;
			x.Activo = checkActivo.Checked;
		
			x.FechaNacimiento = inputNacimiento.Value;
			x.FechaIngreso = inputIngreso.Value;
			x.CantidadProcesos=y.CantidadProcesos;
			x.Procesos = y.Procesos;
			return x;
		}
		
		public void ActualizarUltimosAuditores(){
			
			panelUltimosAuditores.Controls.Clear();
			
			Int16 maximos= 10;
			Int16 contador=0;
			
			foreach(Auditor y in datos.Datos){
				contador++;
				if(contador>maximos){
					break;
				}
				
			Button btnAuditor = new Button();
			btnAuditor.BackColor = System.Drawing.Color.PaleTurquoise;
			btnAuditor.Dock = System.Windows.Forms.DockStyle.Top;
			btnAuditor.FlatAppearance.BorderSize = 0;
			btnAuditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnAuditor.Location = new System.Drawing.Point(0, 0);
			btnAuditor.Name = "btn"+y.Nombres;
			btnAuditor.Size = new System.Drawing.Size(267, 50);
			btnAuditor.Margin = new Padding(0,10,0,10);
			btnAuditor.TabIndex = 0;
			btnAuditor.Tag= y;
			btnAuditor.Text = y.Nombres+" CI: "+y.Cedula + " Cumpleaños: "+ y.FechaNacimiento.Day+"/"+y.FechaNacimiento.Month +" Auditorias: "+y.Procesos.Count;
			btnAuditor.Click+= ConsultaAuditorButton;
			btnAuditor.UseVisualStyleBackColor = false;
			panelUltimosAuditores.Controls.Add(btnAuditor);
	
			}
			
		}
		
		public void ConsultaAuditorButton(object sender, EventArgs e){
			Button botonClickeado = sender as Button;
			if(botonClickeado!=null){
				Auditor auditorSeleccionado = botonClickeado.Tag as Auditor; // Recuperar el objeto Sistema desde la propiedad Tag
        if (auditorSeleccionado != null)
        {
            // Llenar los TextBox con la información del sistema seleccionado
            DesactivarInputs();
            RellenarInputs(auditorSeleccionado);
          
           }
            
        }
			}
			
		public void RellenarInputs(Auditor x){
			  cedulaText.Text= x.Cedula;
            nombreText.Text = x.Nombres;
            apellidoText.Text = x.Apellidos;
            direccionText.Text = x.Direccion;
            comboSexo.Text = x.Sexo.ToString();
            comboTitulo.Text = x.TituloGrado;
            checkActivo.Checked = x.Activo;
           panelAuditor.Controls.Clear();
           foreach(Int16 y in x.Procesos){
           	
           	Button btnProceso = new Button();
			btnProceso.BackColor = System.Drawing.Color.PaleTurquoise;
			btnProceso.Dock = System.Windows.Forms.DockStyle.Top;
			btnProceso.FlatAppearance.BorderSize = 0;
			btnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnProceso.Location = new System.Drawing.Point(0, 0);
			btnProceso.Name = "btn"+y.ToString();
			btnProceso.Size = new System.Drawing.Size(267, 50);
			btnProceso.TabIndex = 0;
			btnProceso.Tag= y;
			btnProceso.Text = y.ToString();
		
			btnProceso.UseVisualStyleBackColor = false;
			panelAuditor.Controls.Add(btnProceso);
           }}
		
		
		void DesactivarInputs(){
		cedulaText.ReadOnly= true;
            nombreText.ReadOnly = true;
            apellidoText.ReadOnly= true;
            direccionText.ReadOnly = true;
            comboSexo.Enabled= false;
            comboTitulo.Enabled= false;
			
		}
		
		void ActivarInputs(){
		
            nombreText.ReadOnly = false;
            apellidoText.ReadOnly= false;
            direccionText.ReadOnly = false;
            comboSexo.Enabled= true;
            comboTitulo.Enabled= true;
		}
		
	
		
		public void ClearInputs(){
			  cedulaText.Text= "";
            nombreText.Text = "";
            apellidoText.Text = "";
            direccionText.Text = "";
            comboSexo.Text = "";
            comboTitulo.Text = "";
           panelAuditor.Controls.Clear();
		}
		
		public bool CamposCompletos(String x){
			if(String.IsNullOrWhiteSpace(cedulaText.Text) || String.IsNullOrWhiteSpace(nombreText.Text) ||
			   String.IsNullOrWhiteSpace(apellidoText.Text) || String.IsNullOrWhiteSpace(direccionText.Text) ||
			   String.IsNullOrWhiteSpace(inputNacimiento.Text) || String.IsNullOrWhiteSpace(inputIngreso.Text) ||
			   String.IsNullOrWhiteSpace(comboSexo.Text) ||	String.IsNullOrWhiteSpace(comboTitulo.Text)){
				MessageBox.Show("Tienes campos vacios, por favor rellenalos todos para continuar con el " + x,"Campos Faltantes", MessageBoxButtons.OK);
				return false;
			}else{
				return true;
			}
		}
		
	
		
		void ActualizarBtnClick(object sender, EventArgs e)
		{
			
			if(actualizable){
				datos.ActualizarAuditor(CrearAuditor(auditorActualizar), cedulaText.Text);
				actualizable=false;
				
			}
			if (String.IsNullOrWhiteSpace(cedulaText.Text)){
			    	MessageBox.Show("Para Actualizar ingresala Cedula del Auditor","Falta el Rif");
			    	actualizable=false;
			    }else{
			    	auditorActualizar= datos.Consultar(cedulaText.Text);
			    }
			if(auditorActualizar!=null){
				actualizable=true;
				ActivarInputs();
				MessageBox.Show("Sistema listo para Actualizar");
				cedulaText.ReadOnly=true;
				RellenarInputs(auditorActualizar);
			}
			
		}
		
		void LimpiarBtnClick(object sender, EventArgs e)
		{
			ClearInputs();
			ActivarInputs();
			cedulaText.ReadOnly=false;
		}
	}
}
