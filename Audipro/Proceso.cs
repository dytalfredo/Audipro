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
		private String cedulaAuditor;
		private String rifSistema;
		private Int16 idProceso;
		private DateTime fechaProceso;
		private Int32 horasUsadas;
		private String resultados;
		private bool falla;
		
		public String NombreProceso {get {return nombreProceso;} set {nombreProceso=value;}}
		public String CedulaAuditor {get {return cedulaAuditor;} set { cedulaAuditor=value;}}
		public String RifSistema {get {return rifSistema;} set { rifSistema = value;}}
		public Int16 IdProceso {get {return idProceso;} set {idProceso=value;}}
		public DateTime FechaProceso { get { return fechaProceso;} set {fechaProceso=value;}}
		public Int32 HorasUsadas {get {return horasUsadas;} set{horasUsadas=value;}}
		public String Resultados {get {return resultados;} set{resultados = value;}}
		public bool Falla {get{return falla;} set{falla=value;}}
		
		
		public Proceso()
		{
			
		}
	}
}
