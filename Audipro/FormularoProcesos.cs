/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 16/2/2025
 * Time: 9:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Audipro
{
	/// <summary>
	/// Description of FormularoProcesos.
	/// </summary>
	public partial class FormularoProcesos : Form
	{
			public Procesos datosProcesos;
			public Sistemas datosSistemas;
			public Auditores datosAuditores;
				public Proceso sistemaActualizar = null;
				bool actualizable =false;
		
		public FormularoProcesos()
		{
				
		
				InitializeComponent();
			this.TopLevel = false; 
    		this.FormBorderStyle = FormBorderStyle.None; 
    		this.WindowState = FormWindowState.Maximized;
    		
		
			
	
		}
		public FormularoProcesos(Procesos p, Sistemas s, Auditores a)
		{
			
				
				InitializeComponent();
			this.TopLevel = false; 
    		this.FormBorderStyle = FormBorderStyle.None; 
    		this.WindowState = FormWindowState.Maximized;
    		datosProcesos = p;
    		
    		datosSistemas = s;
    		datosAuditores = a;
    		datosProcesos.Recuperar();
    	
    		datosProcesos.RecuperarContador();
    		Console.WriteLine("EL CONTENO VA EN "+ datosProcesos.Contador);
    			ActualizarUltimosSistemas();
    		
    		foreach(Auditor x in datosAuditores.Datos){
    			if(x.Activo){
    				comboAuditor.Items.Add(x.Cedula);
    			}
    			
    		}
    		
    		foreach(Sistema x in datosSistemas.Datos){
    			comboSistema.Items.Add(x.RifEmpresa);
    		}
    		
    		if (datosProcesos!=null){
    			
    				idtext.Text= (datosProcesos.Contador+1).ToString();
    		}
    	
    		
		
			
	
		}
		
		void RegistrarBtnClick(object sender, EventArgs e)
		{
			if(CamposCompletos("Registro")&&!datosProcesos.existe(idtext.Text)){
			   	datosProcesos.agregarProceso(CrearProceso());
			   	datosSistemas.agregarProcesoASistema(Convert.ToInt16(idtext.Text),comboSistema.Text);
			   	datosAuditores.AgregarProcesoAuditor(Convert.ToInt16(idtext.Text),comboAuditor.Text);
			   	
			   	MessageBox.Show("Proceso Creado con exito","Registro Completado",MessageBoxButtons.OK);
			   	ActualizarUltimosSistemas();
			   	datosProcesos.IncrementarAutoconteo();
			   	ClearInputs();
			   	datosProcesos.Guardar();
			   	datosProcesos.Recuperar();
			}
						
		}
		
		public Proceso CrearProceso(){
			Proceso x = new Proceso();
			x.NombreProceso= nombreText.Text;
			x.CedulaAuditor = comboAuditor.Text;
			x.RifSistema = comboSistema.Text;
			x.IdProceso = Convert.ToInt16(idtext.Text);
			x.HorasUsadas = Convert.ToInt32(horasText.Text);
			x.FechaProceso = fechaProceso.Value;
			x.Resultados = resultadoText.Text;
			x.Falla = checkFallas.Checked;
			
			return x;
		}
		
		public bool CamposCompletos(String x){
			if(String.IsNullOrWhiteSpace(nombreText.Text) || String.IsNullOrWhiteSpace(comboAuditor.Text)
			   || String.IsNullOrWhiteSpace(comboSistema.Text) || String.IsNullOrWhiteSpace(horasText.Text)
			  || String.IsNullOrWhiteSpace(resultadoText.Text)){
				MessageBox.Show("Tienes campos vacios, por favor rellenalos todos para continuar con el " + x,"Campos Faltantes", MessageBoxButtons.OK);
			return false;
			}else {
				return true;
			}
		}
		
		void ClearInputs(){
			idtext.Text= (datosProcesos.Contador+1).ToString();
			nombreText.Text="";
			comboAuditor.Text="";
			comboSistema.Text="";
			horasText.Text="";
			resultadoText.Text="";
			checkFallas.Checked=false;
			
		}
		
		public void ActualizarUltimosSistemas(){
			
			panelUltimosProcesos.Controls.Clear();
			
			Int16 maximos= 10;
			Int16 contador=0;
			
			foreach(Proceso y in datosProcesos.Datos){
				contador++;
				if(contador>maximos){
					break;
				}
				Sistema controlSistema = datosSistemas.Consultar(y.RifSistema);
			
			Button btnProceso = new Button();
			
			if(y.Falla){
				btnProceso.BackColor = System.Drawing.Color.OrangeRed;
			}else{btnProceso.BackColor = System.Drawing.Color.PaleTurquoise;}
			
			btnProceso.Dock = System.Windows.Forms.DockStyle.Top;
			btnProceso.FlatAppearance.BorderSize = 0;
			btnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnProceso.Location = new System.Drawing.Point(0, 0);
			btnProceso.Name = "btn"+controlSistema.NombreSistema + " " + y.IdProceso ;
			btnProceso.Size = new System.Drawing.Size(267, 23);
			btnProceso.Margin = new Padding(0,10,0,10);
			btnProceso.TabIndex = 0;
			btnProceso.Tag= y;
			btnProceso.Text = "Proceso id: " + y.IdProceso ;
			btnProceso.Click+= ConsultarProcesoButton;
			btnProceso.UseVisualStyleBackColor = false;
			panelUltimosProcesos.Controls.Add(btnProceso);
	
			}
			
		}
		
		public void ConsultarProcesoButton(object sender, EventArgs e){
			Button botonClickeado = sender as Button;
			if(botonClickeado!=null){
				Proceso procesoSeleccionado = botonClickeado.Tag as Proceso; // Recuperar el objeto Sistema desde la propiedad Tag
        if (procesoSeleccionado != null)
        {
            // Llenar los TextBox con la información del sistema seleccionado
            RellenarInputs(procesoSeleccionado);
           }
            
        }
			}
			
		
		void RellenarInputs(Proceso h){
			nombreText.Text= h.NombreProceso;
            comboAuditor.Text = h.CedulaAuditor;
            comboSistema.Text = h.RifSistema;
            idtext.Text = h.IdProceso.ToString();
           fechaProceso.Value= h.FechaProceso;
           resultadoText.Text = h.Resultados;
           horasText.Text = h.HorasUsadas.ToString();
           checkFallas.Checked = h.Falla;
           
		}
		
		void FiltrarBtnClick(object sender, EventArgs e)
		{
			if(fechasCorrectas(fechaInicial.Value, fechaFinal.Value)){
				FiltroPorFecha(fechaInicial.Value, fechaFinal.Value);
				labelFiltro.Visible=true;
			   }
		}
		
		
		void FiltroPorFecha(DateTime x, DateTime z){
			panelUltimosProcesos.Controls.Clear();
			
			Int16 maximos= 10;
			Int16 contador=0;
			
			foreach(Proceso y in datosProcesos.Datos){
				contador++;
				if(contador>maximos){
					break;
				}
				Sistema controlSistema = datosSistemas.Consultar(y.RifSistema);
			
			Button btnProceso = new Button();
			if(x<y.FechaProceso && y.FechaProceso<z){
				
			
			if(y.Falla){
				btnProceso.BackColor = System.Drawing.Color.OrangeRed;
			}else{btnProceso.BackColor = System.Drawing.Color.PaleTurquoise;}
			
			btnProceso.Dock = System.Windows.Forms.DockStyle.Top;
			btnProceso.FlatAppearance.BorderSize = 0;
			btnProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			btnProceso.Location = new System.Drawing.Point(0, 0);
			btnProceso.Name = "btn"+controlSistema.NombreSistema + " " + y.IdProceso ;
			btnProceso.Size = new System.Drawing.Size(267, 23);
			btnProceso.Margin = new Padding(0,10,0,10);
			btnProceso.TabIndex = 0;
			btnProceso.Tag= y;
			btnProceso.Text = "Proceso id: " + y.IdProceso ;
			btnProceso.Click+= ConsultarProcesoButton;
			btnProceso.UseVisualStyleBackColor = false;
			panelUltimosProcesos.Controls.Add(btnProceso);
			}
			}
			
		}
		
		private Boolean fechasCorrectas(DateTime x , DateTime y){
			if(y > x){
				return true;
			}else{
				MessageBox.Show("La fecha final debe ser mayor que la inicial");
				return false;
			}
		}
		
		void TodosBtnClick(object sender, EventArgs e)
		{
			ActualizarUltimosSistemas();
			labelFiltro.Visible=false;
		}
		
		void LimpiarBtnClick(object sender, EventArgs e)
		{
			ClearInputs();
		}
	}
		

	}

