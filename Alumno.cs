﻿/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 31/8/2025
 * Hora: 17:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica_1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
	{
		private int legajo;
		private int promedio;
		
		public Alumno(string nombre, int dni, int legajo, int promedio): base(nombre, dni)
		{
			this.legajo = legajo;
			this.promedio = promedio;
		}
		
		public int getLegajo(){
			
			return legajo;
		}
		
		public void setLegajo(int legajo){
			
			this.legajo = legajo;
		}
		
		public int getPromedio(){
			
			return promedio;
		}
		
		public void setPromedio(int promedio){
			
			this.promedio = promedio;
		}
		
		
		
		
	}
}
