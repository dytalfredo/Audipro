using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace Audipro
{
	/// <summary>
	/// Description of Sistemas.
	/// </summary>
	public class Sistemas
	{
		private List<Sistema> _datos;
		public List<Sistema> Datos { get { return _datos;} set { _datos = value;}}
		private String _archivo = @"Sistemas.txt";

		
		public Sistemas()
		{
			_datos = new List<Sistema>(); //crear la lista
			//_datos.Add( new Sistema("Sistema 1","Tesla", "Calle Mis amores", "j0132456432", new DateTime(2023,5,2), new DateTime(2024,5,2), new List<Int16>(){1,5,6}));
			//_datos.Add( new Sistema("Sistema Grande","Unloked", "Los Leones", "j053245644", new DateTime(2023,5,2), new DateTime(2024,5,2), new List<Int16>(){2,3,4}));
		}
		
		public void Guardar()
		{
			
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.OpenOrCreate);
			BinaryWriter _streamDatos = new BinaryWriter(_archivoCreado, Encoding.UTF8);
			foreach (Sistema _j in _datos)
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
		
		public void ConvertirBinario(BinaryWriter streameDatos, Sistema x)
		{
			
			streameDatos.Write(x.NombreSistema);
			streameDatos.Write(x.NombreEmpresa);
			streameDatos.Write(x.DireccionEmpresa);
			streameDatos.Write(x.RifEmpresa);
			streameDatos.Write(x.FechaInicio.Day);
			streameDatos.Write(x.FechaInicio.Month);
			streameDatos.Write(x.FechaInicio.Year);
			streameDatos.Write(x.FechaFinal.Day);
			streameDatos.Write(x.FechaFinal.Month);
			streameDatos.Write(x.FechaFinal.Year);
			streameDatos.Write(x.CantidadProcesos);
			for (int i = 0; i < x.CantidadProcesos; i++) {
				streameDatos.Write(x.Procesos[i]);
			}
		
		}
		
		
		private Sistema Leer(BinaryReader x)
		{
		
			Int32 dI,mI,aI,dF,mF,aF;
			
			
			Sistema h = new Sistema();
			h.NombreSistema = x.ReadString();
			h.NombreEmpresa = x.ReadString();
			h.DireccionEmpresa = x.ReadString();
			h.RifEmpresa = x.ReadString();
			dI= x.ReadInt32();
			mI= x.ReadInt32();
			aI= x.ReadInt32();
			dF= x.ReadInt32();
			mF= x.ReadInt32();
			aF= x.ReadInt32();
			h.CantidadProcesos = x.ReadInt16();
			Console.WriteLine("la cantidad de procesos del sistema " + h.NombreSistema+" es "+h.CantidadProcesos);
			for (int i = 0; i < h.CantidadProcesos; i++) {
				
				h.Procesos.Add(x.ReadInt16());
			}
			
			h.FechaInicio = new DateTime(aI,mI,dI);
			h.FechaFinal =new DateTime(aF,mF,dF);
			
		
			return h;
		}
		
		public void agregarProcesoASistema(Int16 x, String rif){
			foreach(Sistema y in _datos){
				if(y.RifEmpresa==rif){
					y.AgregarProceso(x);
				}
			}
			Guardar();
			Recuperar();
		}
		
		public void agregarSistema(Sistema x){
			if(fechasCorrectas(x)){
				_datos.Add(x);
				Guardar();
			}else{
				MessageBox.Show("La fecha final debe ser mayor que la fecha inicial","Incongruencia en las fechas",MessageBoxButtons.OK);
			}
			
		}
		
		private Boolean fechasCorrectas(Sistema x){
			if(x.FechaFinal > x.FechaInicio){
				return true;
			}else{
				return false;
			}
		}
		
		private DateTime Fecha(String l)
		{
			Int16 dia = Convert.ToInt16(l.Substring(0,2));
			Int16 mes = Convert.ToInt16(l.Substring(3,2));
			Int16 año = Convert.ToInt16(l.Substring(6,4));
			DateTime u = new DateTime(año,mes,dia);
			return u;
		}

		public bool existe(String x){
		foreach (Sistema y in _datos) {
			if(y.RifEmpresa == x){
				MessageBox.Show("El Rif del sitema ya se encuentra registrado");
				return true;
			}
		}
		return false;
	}

		public Sistema Consultar(String x){
			Sistema h = null;
			foreach(Sistema y in _datos){
				if(y.RifEmpresa == x){
					h=y;
					break;
				}
			}
			if(h==null){
				MessageBox.Show("Sistema no encontrado23","Sin coincidencias");
				return h;
			}
			return h;
		}
		
		public void ActualizarSistema(Sistema x, String y){
			
			foreach(Sistema h in _datos){
				if(h.RifEmpresa== y){
					h.NombreSistema = x.NombreSistema;
					h.NombreEmpresa = x.NombreEmpresa;
					h.DireccionEmpresa = x.DireccionEmpresa;
					h.FechaInicio = x.FechaInicio;
					h.FechaFinal = x.FechaFinal;
					h.Procesos = x.Procesos;
					MessageBox.Show("Sistema Actualizado con Exito","Actualizacion Completa");
					Guardar();
					break;
				}
			}
			
		}
		
	}
}
