/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 16/2/2025
 * Time: 10:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Audipro
{
	/// <summary>
	/// Description of Auditor.
	/// </summary>
	public class Auditor
	{
		private string cedula;
		private string nombres;
		private string apellidos;
		private string direccion;
		private char sexo; // m o f
		private DateTime fechaNacimiento;
		private DateTime fechaIngreso;
		private string tituloGrado; 
		private bool activo;
		private List<Int16> procesos;
		private Int16 cantidadProcesos;
		
		public List<Int16> Procesos {get {return procesos;} set{procesos= value;}}
		public Int16 CantidadProcesos {get {return cantidadProcesos;} set{cantidadProcesos = value;}}
		public string Cedula {get {return cedula; } set { cedula = value;}}
		public string Nombres {get {return nombres; } set { nombres = value;}}
		public string Apellidos {get {return apellidos; } set { apellidos = value;}}
		public string Direccion {get {return direccion; } set { direccion = value;}}
		public char Sexo {get {return sexo; } set { sexo = value;}}
		public DateTime FechaNacimiento  {get {return fechaNacimiento; } set { fechaNacimiento = value;}}
		public DateTime FechaIngreso {get {return fechaIngreso; } set { fechaIngreso = value;}}
		public string TituloGrado {get {return tituloGrado; } set { tituloGrado = value;}}
		public bool Activo {get {return activo;} set{activo=value;}}
		
		
		public Auditor()
		{
			procesos = new List<Int16>();
			cantidadProcesos= Convert.ToInt16( procesos.Count);
		}
		public void AgregarProceso(Int16 index){
			procesos.Add(index);
			cantidadProcesos= Convert.ToInt16( procesos.Count);
		}
	}
}
