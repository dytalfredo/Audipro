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
		private String _archivo = @"Archivo.txt";
		private Char _separador = ',';
		private String _salto = "\r\n";
		
		public Sistemas()
		{
			_datos = new List<Sistema>(); //crear la lista
			_datos.Add( new Sistema("Sistema 1","Tesla", "Calle Mis amores", "j0132456432", new DateTime(2023,5,2), new DateTime(2024,5,2)));
			_datos.Add( new Sistema("Sistema Grande","Unloked", "Los Leones", "j053245644", new DateTime(2023,5,2), new DateTime(2024,5,2)));			
		}
		
		public void Guardar()
		{
			
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.OpenOrCreate);
			BinaryWriter _streamDatos = new BinaryWriter(_archivoCreado, Encoding.UTF8);
			foreach (Sistema _j in _datos)
			{
				Console.WriteLine(_j);
				Linea_Sistema(_streamDatos, _j);
			}
			_streamDatos.Close();
			MessageBox.Show("Componentes guardados en el Archivo Componente_01.txt","Salida");
		}
		
		private String Escribir(Sistema objeto) 
		{
			String w = "";
			String _t = _separador.ToString().Trim();
			w = objeto.NombreSistema +_t + objeto.NombreEmpresa;
			w+=	_t + objeto.DireccionEmpresa + _t + objeto.RifEmpresa + _t + objeto.FechaInicio.ToString("s");
			w+= _t + objeto.FechaFinal.ToString("s");

			return w;
		}
		
		
		
		public void Recuperar()
		{
			_datos.Clear();
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.Open);
			BinaryReader _streamDatos = new BinaryReader(_archivoCreado, Encoding.UTF8);
			_datos.Add(Leer(_streamDatos));
			_streamDatos.Close();
		}
		
		public void Linea_Sistema(BinaryWriter streameDatos, Sistema x)
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
			h.FechaInicio = new DateTime(aI,mI,dI);
			h.FechaFinal =new DateTime(aF,mF,dF);
			
		
			return h;
		}
		
		private DateTime Fecha(String l)
		{
			Int16 dia = Convert.ToInt16(l.Substring(0,2));
			Int16 mes = Convert.ToInt16(l.Substring(3,2));
			Int16 año = Convert.ToInt16(l.Substring(6,4));
			DateTime u = new DateTime(año,mes,dia);
			return u;
		}
		
		public String Mostrar()
		{
			String w = "";
			foreach (Sistema _j in _datos)
			{
				w = w + Escribir(_j) + _salto; 
			}
			return w;
		}
		
		
		
	}
}
