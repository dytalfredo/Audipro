using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Audipro
{
	/// <summary>
	/// Description of Usuarios.
	/// </summary>
	public class Usuarios
		
	{
		private List<Usuario> _datos;
		public List<Usuario> Datos { get { return _datos;} set { _datos = value;}}
		private String _archivo = @"Usuarios.txt";

		
		public Usuarios()
		{
			_datos = new List<Usuario>();
			_datos.Add(new Usuario("Ajmmjr","Holamundo"));
		}
		
		
		//Creamos primero el metodo de guardar
		public void Guardar()
		{
			//Creando la instancia del archivo
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.OpenOrCreate);
			//Creamos el escritor.
			BinaryWriter _streamDatos = new BinaryWriter(_archivoCreado, Encoding.UTF8);
			
			//ITERANDO DENTRO DE UNA LISTA DE USARIOS
			foreach (Usuario _j in _datos)
			{
				
				ConvertirUsuario(_streamDatos, _j);
			}
			
			_streamDatos.Close();
			
		}
		
		
		//MODIFICAR CON LOS DATOS DE SUS ENTIDADES
			public void ConvertirUsuario(BinaryWriter streameDatos, Usuario x)
		{
			streameDatos.Write(x.NombreUsuario);
			streameDatos.Write(x.ContraseñaUsuario);
		
		}
		
		
		//TRAE LA INFOMARCIOS DESDE ARCHIVO BINARIA Y LA METE EN LA LISTA
		public void Recuperar()
		{
			_datos.Clear();
			
			//La instancia de un archivo
			FileStream _archivoCreado = new FileStream(_archivo,FileMode.Open);
			//Decodificador
			BinaryReader _streamDatos = new BinaryReader(_archivoCreado, Encoding.UTF8);
			
			
			//VERIFICO SI EL ARCHIVO TIENE ALGO
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
            Console.WriteLine("Error de E/S durante la lectura:"+ e.Message);
            // Manejar errores de lectura dentro del bucle, si es necesario
            break; // o puedes optar por continuar, dependiendo de cómo quieras manejar errores
        }
				
			
			
			}
			_streamDatos.Close();}
		
		
	//melary 97yiubx287g87
	
	
		
	//MODIFICAR CON LOS DATOS DE SUS ENTIDADES
			
		private Usuario Leer(BinaryReader x)
		{
			
			Usuario h = new Usuario();
			h.NombreUsuario = x.ReadString();
			h.ContraseñaUsuario = x.ReadString();
		
		
			return h;
		}	

	public Usuario Consultar(string nombre)
        {
            Usuario usuarioBuscado = null;
            if(_datos != null){
            	foreach (Usuario x in _datos)
				{
            		if (x.NombreUsuario == nombre)
	                {
	                    usuarioBuscado = x;
	                    break;
	                }
	            }
            }

            if (usuarioBuscado == null)
            {
                throw new Exception("El curso no se encuentra registrado.");
            }

            return usuarioBuscado;
        }

	public bool existe(String x){
		foreach (Usuario y in _datos) {
			if(y.NombreUsuario == x){
				MessageBox.Show("El usuario ya se encuentra registrado");
				return true;
			}
		}
		return false;
	}
		
	}
}
