using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace Audipro
{
	/// <summary>
	/// Description of Procesos.
	/// </summary>
	public class Procesos
	{
		private List<Proceso> _datos;
		private Int16 contador;
		public Int16 Contador {get {return contador;} set{contador= value;}}
		public List<Proceso> Datos { get { return _datos;} set { _datos = value;}}
		private String _archivo = @"Procesos.txt";
		private String _conteo = @"Conteo.txt";

		
		public Procesos()
		{
			_datos = new List<Proceso>();
			contador=0;
					//crear la lista
			
		}
		
		public void GuardarContador(){
			FileStream _archivoCreado = new FileStream(_conteo,FileMode.OpenOrCreate);
			BinaryWriter _streamDatos = new BinaryWriter(_archivoCreado, Encoding.UTF8);
			_streamDatos.Write(contador);
			Console.WriteLine("DATO DEL CONTADOR ESCRITO ES " +contador);
			_streamDatos.Close();
		}
		
		public void RecuperarContador(){
			FileStream _archivoCreado = new FileStream(_conteo,FileMode.Open);
			BinaryReader _streamDatos = new BinaryReader(_archivoCreado, Encoding.UTF8);
			contador= _streamDatos.ReadInt16();
			Console.WriteLine("Dato del contador leido es " +contador);
			_streamDatos.Close();
		}
		
		public void Guardar()
		{
			
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.OpenOrCreate);
			BinaryWriter _streamDatos = new BinaryWriter(_archivoCreado, Encoding.UTF8);
			
			
			foreach (Proceso _j in _datos)
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
            break; // Salir del bucle while
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
		
		public void ConvertirBinario(BinaryWriter streameDatos, Proceso x)
		{
			streameDatos.Write(x.NombreProceso);
			streameDatos.Write(x.CedulaAuditor);
			streameDatos.Write(x.RifSistema);
			streameDatos.Write(x.IdProceso);
			streameDatos.Write(x.FechaProceso.Day);
			streameDatos.Write(x.FechaProceso.Month);
			streameDatos.Write(x.FechaProceso.Year);
			streameDatos.Write(x.HorasUsadas);
			streameDatos.Write(x.Resultados);
			streameDatos.Write(x.Falla);
		
		}
		
		public void IncrementarAutoconteo(){
			contador++;
			GuardarContador();
			RecuperarContador();
			
	
		}
		
		
		private Proceso Leer(BinaryReader x)
		{
		
			Int32 dI,mI,aI;
			
			//			
//			private String nombreProceso;
//		private String cedulaAuditor;
//		private String rifSistema;
//		private Int16 idProceso;
//		private DateTime fechaProceso;
//		private Int32 horasUsadas;
//		private String resultados;
//		private bool falla;
//			
			
			Proceso h = new Proceso();
			
			h.NombreProceso = x.ReadString();
			h.CedulaAuditor = x.ReadString();
			h.RifSistema = x.ReadString();
			h.IdProceso = x.ReadInt16();
			dI= x.ReadInt32();
			mI= x.ReadInt32();
			aI= x.ReadInt32();
			h.HorasUsadas = x.ReadInt32();
			h.Resultados = x.ReadString();
			h.Falla= x.ReadBoolean();
			
			h.FechaProceso = new DateTime(aI,mI,dI);
			
			
		
			return h;
		}
		
		public void agregarProceso(Proceso x){
			
				_datos.Add(x);
				Guardar();
			
		}
		

		public bool existe(String x){
		foreach (Proceso y in _datos) {
				if(y.IdProceso == Convert.ToInt16(x)){
				MessageBox.Show("El id del sitema ya se encuentra registrado");
				return true;
			}
		}
		return false;
	}

		public Proceso Consultar(Int16 x){
			Proceso h = null;
			foreach(Proceso y in _datos){
				if(y.IdProceso == x){
					h=y;
					break;
				}
			}
			if(h==null){
				MessageBox.Show("Proceso no encontrado23","Sin coincidencias");
				return h;
			}
			return h;
		}
		
		public void ActualizarSistema(Proceso x, String y){
			
			foreach(Proceso h in _datos){
				if(h.IdProceso== Convert.ToInt16(y)){
			h.NombreProceso = x.NombreProceso;
			h.CedulaAuditor = x.CedulaAuditor;
			h.RifSistema = x.RifSistema;
			h.IdProceso = x.IdProceso;
			h.HorasUsadas = x.HorasUsadas;
			h.Resultados = x.Resultados;
			h.Falla= x.Falla;
			h.FechaProceso = x.FechaProceso;
					
					MessageBox.Show("Proceso Actualizado con Exito","Actualizacion Completa");
					Guardar();
					break;
				}
			}
			
		}
		
	}
}
