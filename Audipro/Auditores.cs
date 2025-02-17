
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace Audipro
{
	/// <summary>
	/// Description of Auditores.
	/// </summary>
	public class Auditores
	{
		private List<Auditor> _datos;
		public List<Auditor> Datos { get { return _datos;} set { _datos = value;}}
		private String _archivo = @"Auditores.txt"; 
		
		public Auditores()
		{
			_datos = new List<Auditor>();
		}
		
		public void Guardar()
		{
			
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.OpenOrCreate);
			BinaryWriter _streamDatos = new BinaryWriter(_archivoCreado, Encoding.UTF8);
			foreach (Auditor _j in _datos)
			{
				
				ConvertirBinario(_streamDatos, _j);
			}
			_streamDatos.Close();
	
		}
			
		public void Recuperar()
		{
			_datos.Clear();
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.Open);
			BinaryReader _streamDatos = new BinaryReader(_archivoCreado, Encoding.UTF8);
			while(true){
			
				try{
					_datos.Add(Leer(_streamDatos));
				}
				catch (EndOfStreamException)
        {
            // Se lanza EndOfStreamException cuando se intenta leer más allá del final del archivo.
            // Esto indica que hemos leído todos los objetos. Salir del bucle.
            break; 
        }
        catch (IOException e)
        {
            Console.WriteLine("Error de E/S durante la lectura: {e.Message}");
            // Manejar errores de lectura dentro del bucle, si es necesario
            break; // o puedes optar por continuar, dependiendo de cómo quieras manejar errores
        }
			
			
		}
			_streamDatos.Close();
		}
		
		public void ConvertirBinario(BinaryWriter streameDatos, Auditor x)
		{
//			private string cedula;
//		private string nombres;
//		private string apellidos;
//		private string direccion;
//		private char sexo; // m o f
//		private DateTime fechaNacimiento;
//		private DateTime fechaIngreso;
//		private string tituloGrado; 
//		private bool activo;
//		private List<Int16> procesos;
//		private Int16 cantidadProcesos;
			

			
			streameDatos.Write(x.Cedula);
			streameDatos.Write(x.Nombres);
			streameDatos.Write(x.Apellidos);
			streameDatos.Write(x.Direccion);
			streameDatos.Write(x.Sexo);
			streameDatos.Write(x.FechaNacimiento.Day);
			streameDatos.Write(x.FechaNacimiento.Month);
			streameDatos.Write(x.FechaNacimiento.Year);
			streameDatos.Write(x.FechaIngreso.Day);
			streameDatos.Write(x.FechaIngreso.Month);
			streameDatos.Write(x.FechaIngreso.Year);
			streameDatos.Write(x.TituloGrado);
			streameDatos.Write(x.Activo);
			streameDatos.Write(x.CantidadProcesos);
			// si tengo 0 procesos no entra en el siguiente for
			for (int i = 0; i < x.CantidadProcesos; i++) {
				streameDatos.Write(x.Procesos[i]);
			}
		
		}
		
		
		private Auditor Leer(BinaryReader x)
		{
		
			Int32 dN,mN,aN,dI,mI,aI;
			
			Auditor h = new Auditor();
			
			
//			streameDatos.Write(x.Cedula);
//			streameDatos.Write(x.Nombres);
//			streameDatos.Write(x.Apellidos);
//			streameDatos.Write(x.Direccion);
//			streameDatos.Write(x.Sexo);
//			streameDatos.Write(x.FechaNacimiento.Day);
//			streameDatos.Write(x.FechaNacimiento.Month);
//			streameDatos.Write(x.FechaNacimiento.Year);
//			streameDatos.Write(x.FechaIngreso.Day);
//			streameDatos.Write(x.FechaIngreso.Month);
//			streameDatos.Write(x.FechaIngreso.Year);
//			streameDatos.Write(x.TituloGrado);
//			streameDatos.Write(x.Activo);
//			streameDatos.Write(x.CantidadProcesos);
//			// si tengo 0 procesos no entra en el siguiente for
//			for (int i = 0; i < x.CantidadProcesos; i++) {
//				streameDatos.Write(x.Procesos[i]);
//			}
			
			h.Cedula = x.ReadString();
			h.Nombres = x.ReadString();
			h.Apellidos = x.ReadString();
			h.Direccion = x.ReadString();
			h.Sexo = x.ReadChar();
			
			dN = x.ReadInt32();
			mN = x.ReadInt32();
			aN = x.ReadInt32();
			dI = x.ReadInt32();
			mI = x.ReadInt32();
			aI = x.ReadInt32();
			h.TituloGrado = x.ReadString();
			h.Activo = x.ReadBoolean();
			h.CantidadProcesos = x.ReadInt16();

			//Console.WriteLine("la cantidad de procesos del sistema " + h.NombreSistema+" es "+h.CantidadProcesos);
			for (int i = 0; i < h.CantidadProcesos; i++) {
				
				h.Procesos.Add(x.ReadInt16());
			}
		
			h.FechaNacimiento = new DateTime(aN,mN,dN);
			h.FechaIngreso = new DateTime(aI,mI,dN);
		
			return h;
		}
		
		
		
		public void agregarAuditor(Auditor x){
				_datos.Add(x);
				Guardar();
			
		}
		
		public void AgregarProcesoAuditor(Int16 x, String cedula){
			foreach(Auditor y in _datos){
				if(y.Cedula==cedula){
					y.AgregarProceso(x);
				}
			}
			Guardar();
			Recuperar();
		}
		
		public bool existe(String x){
		foreach (Auditor y in _datos) {
			if(y.Cedula == x){
				MessageBox.Show("El Auditor ya se encuentra registrado");
				return true;
			}
		}
		return false;
	}

		public Auditor Consultar(String x){
			Auditor h = null;
			foreach(Auditor y in _datos){
				if(y.Cedula == x){
					h=y;
					break;
				}
			}
			if(h==null){
				MessageBox.Show("Auditor no encontrado23","Sin coincidencias");
				return h;
			}
			return h;
		}		
		
		public void ActualizarAuditor(Auditor x, String y){
			
			foreach(Auditor h in _datos){
				if(h.Cedula== y){
					h.Cedula = x.Cedula;
					h.Nombres = x.Nombres;
					h.Apellidos = x.Apellidos;
					h.Direccion = x.Direccion;
					h.FechaNacimiento = x.FechaNacimiento;
					h.FechaIngreso = x.FechaIngreso;
					h.TituloGrado= x.TituloGrado;
					h.Activo = x.Activo;
					h.Procesos = h.Procesos;
					h.CantidadProcesos = Convert.ToInt16(h.Procesos.Count);
					
					
					MessageBox.Show("Auditor Actualizado con Exito","Actualizacion Completa");
					Guardar();
					break;
				}
			}
			
		}
		
	}
}
