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
			_datos = new List<Sistema>();
			_datos.Add( new Sistema("Sistema 1","Tesla", "Calle Mis amores", "j0132456432", DateTime.Now, DateTime.Now));
			
		}
		
		public void Guardar()
		{
			
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.OpenOrCreate);
			BinaryWriter _streamDatos = new BinaryWriter(_archivoCreado, En);
			foreach (Sistema _j in _datos)
			{
				Console.WriteLine(_j);
				String _lienaDeTexto = Escribir(_j);
				_streamDatos.WriteLine(_lienaDeTexto);
			}
			_streamDatos.Close();
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
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.Open,FileAccess.Read);
			StreamReader _streamDatos = new StreamReader(_archivoCreado);
			String _r = _streamDatos.ReadLine();
			while (_r != null)
			{
				_datos.Add(Leer(_r));
			    _r = _streamDatos.ReadLine();
			}
			_streamDatos.Close();
		}
		
		
		
		private Sistema Leer(String x)
		{
			Sistema h = new Sistema();
			String[] arregloDeTextos = x.Split(_separador);
			h.NombreSistema = arregloDeTextos[0];
			h.NombreEmpresa = arregloDeTextos[1];
			h.DireccionEmpresa = arregloDeTextos[2];
			h.RifEmpresa = arregloDeTextos[3];
			h.FechaInicio = Convert.ToDateTime(arregloDeTextos[4], CultureInfo.InvariantCulture);
			h.FechaFinal = Convert.ToDateTime(arregloDeTextos[5],CultureInfo.InvariantCulture);
		
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
