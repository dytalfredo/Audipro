/*
 * Created by SharpDevelop.
 * User: dytal
 * Date: 13/2/2025
 * Time: 10:54 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Audipro
{
	/// <summary>
	/// Description of Singleton.
	/// </summary>
	public sealed class Singleton
	{
		private static Singleton instance = new Singleton();
		
		public static Singleton Instance {
			get {
				return instance;
			}
		}
		
		private Singleton()
		{
		}
	}
}
