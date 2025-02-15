/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 15/2/2025
 * Time: 1:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Audipro
{
	/// <summary>
	/// Description of Usuario.
	/// </summary>
	public class Usuario
	{
		private String nombreUsuario;
		private String contraseñaUsuario;
		
		public String NombreUsuario {get {return nombreUsuario;} set { nombreUsuario=value;}}
		public String ContraseñaUsuario {get {return contraseñaUsuario;} set { contraseñaUsuario=value;}}
		
		public Usuario()
		{
			nombreUsuario="";
			contraseñaUsuario="";
		}
		public Usuario(String x, String y)
		{
			nombreUsuario=x;
			contraseñaUsuario=y;
		}
	}
}
