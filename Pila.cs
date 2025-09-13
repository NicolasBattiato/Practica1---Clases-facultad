/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 26/8/2025
 * Hora: 18:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_1
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila : IColeccionable
	{
		private List<IComparable> numeros ;
		
		
		public Pila()
		{
			this.numeros = new List<IComparable>();
		}
		
		public int cuantos()
		{
			return this.numeros.Count;
		}
		
		public IComparable minimo()
		{
			if (this.numeros.Count == 0){
				return null;
			}
			IComparable minimo = this.numeros[0];
			foreach (IComparable numero in this.numeros){
				if (numero.sosMenor(minimo)){
					minimo = numero;
				}
			}
			return minimo;
		}
		
		public IComparable maximo()
		{
			if (this.numeros.Count == 0){
				return null;
			}
			IComparable maximo = this.numeros[0];
			foreach (IComparable numero in this.numeros){
				if (numero.sosMayor(maximo)){
					maximo = numero;
				}
			}
			return maximo;
		}
		
		public void agregar(IComparable c)
		{
			this.numeros.Add(c); // Castear
		}
		
		public bool contiene(IComparable c)
		{
			foreach (IComparable numero in this.numeros){
				if (numero.sosIgual(c)){
					return true;
				}
			}
			return false;
		}		
		
	}
}
