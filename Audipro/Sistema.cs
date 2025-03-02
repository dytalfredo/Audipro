﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
namespace Audipro
{
	/// <summary>
	/// Description of Sistema.
	/// </summary>
	public class Sistema
		
		
	{
		
		private String nombreSistema;
		//private List<int> procesos;
		//private Int16 idSistema;
		private String nombreEmpresa;
		private String direccionEmpresa;
		private String rifEmpresa;
		private DateTime fechaInicio;
		private DateTime fechaFinal;
		
		
		//public List<Proceso> Procesos {get{return procesos;} set{procesos=value;}}
		public String NombreSistema { get {return nombreSistema;} set {nombreSistema = value;} }
		//public  Int16 IdSistema {get {return idSistema;} set{ idSistema= value;}}
		public String NombreEmpresa { get {return nombreEmpresa;} set {nombreEmpresa = value;} }
		public String DireccionEmpresa { get {return direccionEmpresa;} set {direccionEmpresa = value;} }
		public String RifEmpresa { get {return rifEmpresa;} set {rifEmpresa = value;} }	
		public DateTime FechaInicio {get { return fechaInicio;} set{ fechaInicio = value;}}
		public DateTime FechaFinal {get { return fechaFinal;} set{ fechaFinal = value;}}
		
		
		public Sistema(){
			
		}
		
		public Sistema(String nS, String nE, String dE, String rE, DateTime fI, DateTime fF)
		{
			//procesos = new List<Proceso>();
			nombreSistema=nS; nombreEmpresa = nE; direccionEmpresa = dE;
			rifEmpresa = rE; fechaInicio= fI; fechaFinal = fF;
			
		}
		
		public override string ToString()
		{
			return string.Format("[Sistema NombreSistema={0}, NombreEmpresa={1}, DireccionEmpresa={2}, RifEmpresa={3}, FechaInicio={4}, FechaFinal={5}]", nombreSistema, nombreEmpresa, direccionEmpresa, rifEmpresa, fechaInicio, fechaFinal);
		}

	}
}
