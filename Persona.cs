/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 31/8/2025
 * Hora: 17:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica_1
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona : IComparable
	{
		private string nombre;
		private int dni;
		
		public Persona(string n, int d)
		{
			this.nombre = n;
			this.dni = d;
		}
		
		public string getNombre(){
			
			return nombre;
		}
		
		public void setNombre(string nombre){
			
			this.nombre = nombre;
		}
		
		public int getDni(){
			
			return dni;
		}
		
		public void setDni(int dni){
			
			this.dni = dni;
			
		}
		
		public bool sosIgual(IComparable n){
			
			if(nombre == ((Persona)n).getNombre()){
				return true;
			}
			return false;
			
		}
		
		public bool sosMenor(IComparable n){
			return true;
		}
		
		public bool sosMayor(IComparable n){
			
			return true;
			
		}
		
		
		
	}
}
