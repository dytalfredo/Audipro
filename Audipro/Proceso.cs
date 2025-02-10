/*
 * Created by SharpDevelop.
 * User: melar
 * Date: 9/2/2025
 * Time: 8:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Audipro
{
	/// <summary>
	/// Description of Proceso.
	/// </summary>
	public class Proceso
	{
		private String nombreProceso;
		private Int16 idAuditor;
		private Int16 idSistema;
		private DateTime fechaProceso;
		private Int16 horasUsadas;
		private String resultados;
		private bool falla;
		
		public String NombreProceso {get {return nombreProceso;} set {nombreProceso=value;}}
		public Int16 IdAuditor {get {return idAuditor;} set { idAuditor=value;}}
		public Int16 IdSistema {get {return idSistema;} set { idSistema = value;}}
		public DateTime FechaProceso { get { return fechaProceso;} set {fechaProceso=value;}}
		public Int16 HorasUsadas {get {return horasUsadas;} set{horasUsadas=value;}}
		public String Resultados {get {return resultados;} set{resultados = value;}}
		public bool Falla {get{return falla;} set{falla=value;}}
		
		
		public Proceso()
		{
		}
	}
}
