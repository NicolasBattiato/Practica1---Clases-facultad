﻿/*
 * Creado por SharpDevelop.
 * Usuario: nicol
 * Fecha: 25/8/2025
 * Hora: 17:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;


namespace Practica_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Numero numero = new Numero(23);
			Numero numero2 = new Numero(34);
			Numero numero3 = new Numero(45);
			
			Console.WriteLine(numero.sosIgual(numero));
			Console.WriteLine(numero.sosMayor(numero2));
			Console.WriteLine(numero.sosMenor(numero3));
			
			// ------------------------------------------------------
			
			Console.WriteLine("\n----Ejercicio de Pila ----\n");
			
			Pila pila = new Pila();
			
			pila.agregar(numero);
			pila.agregar(numero2);
			pila.agregar(numero3);
			
			Console.WriteLine("En la pila se encuentra un total de " + pila.cuantos() + " elementos");
			Console.WriteLine("En la pila el maximo es: " + ((Numero) pila.maximo()).getValor());
			Console.WriteLine("En la pila el minimo es: " + ((Numero) pila.minimo()).getValor());
			
			Console.WriteLine("\n----Ejercicio de Cola ----\n");
			
			Cola cola = new Cola();
			
			cola.agregar(numero);
			cola.agregar(numero2);
			cola.agregar(numero3);
			
			Console.WriteLine("En la cola se encuentra un total de " + cola.cuantos() + " elementos");
			Console.WriteLine("En la cola el maximo es: " + ((Numero) cola.maximo()).getValor());
			Console.WriteLine("En la cola el minimo es: " + ((Numero) cola.minimo()).getValor());
			
			// -----------------------------------------------------------------
			
			Console.WriteLine("\n----Ejercicio de Pila llenar ----\n");
			
			Pila pila2 = new Pila();
			llenar(pila2);
			Console.WriteLine("Cantidad de elementos en la pila: " + pila2.cuantos());
			
			Console.WriteLine("\n----Ejercicio de Cola llenar ----\n");
			
			Cola cola2 = new Cola();
			llenar(cola2);
			Console.WriteLine("Cantidad de elementos en la cola: " + cola2.cuantos());
			
			// -----------------------------------------
			Console.WriteLine("\n----Ejercicio de Informar----\n");
			Pila pila3 = new Pila();
			llenar(pila3);
			informar(pila3);
			
			// --------------------------------
			
			Pila pila4 = new Pila();
			Cola cola3 = new Cola();
			llenar(pila4);
			llenar(cola3);
			informar(pila4);
			informar(cola3);
			
			// --------------------------------
			
			Pila pilaM = new Pila();
			Cola colaM = new Cola();
			
			IColeccionMultiple multiple = new IColeccionMultiple(pilaM, colaM);
			
			llenar(pilaM);
			llenar(colaM);
			informar(pilaM);
			informar(colaM);
			informar(multiple);
			
			// ver por que se repite informar(multiple) |^|
			
			Pila pilaA = new Pila();
			Cola colaA = new Cola();
			
			IColeccionMultiple multipleAlum = new IColeccionMultiple(pilaA, colaA);
			
			llenarAlumnos(pilaA);
			llenarAlumnos(colaA);
			informar(multipleAlum);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		private static Random random = new Random();
		
		public static void llenar(IColeccionable c){
			
			for (int i = 0; i < 20; i++){
				int valor = random.Next(1,100);
				Numero numero = new Numero(valor);
				c.agregar(numero);
			}
			
		}
		
		public static void informar(IColeccionable c){
			
			Console.WriteLine(c.cuantos());
			Console.WriteLine(((Numero)c.minimo()).getValor());
			Console.WriteLine(((Numero)c.maximo()).getValor());
			
			Console.WriteLine("Ingrese un numero: ");
			int numero_ingresado = int.Parse(Console.ReadLine());
			Numero numero = new Numero(numero_ingresado);
			
			if(c.contiene(numero)){
				Console.WriteLine("El elemento leido esta en la coleccion");
			
			}else{
				Console.WriteLine("El elemento leido no esta en la coleccion");
			}
		}
		
		public static void llenarAlumnos(IColeccionable c){
			
			string[] alumnos = {"Nico", "Martin", "Maria", "Brenda", "Mica", "Maure"};
			
			for(int i = 0; i < 20; i++){
				
				string nombre = alumnos[random.Next(0, alumnos.Length)];
				int dni = random.Next(10000000,99000000);
				int legajo = random.Next(1, 100000);
				int promedio = random.Next(1,10);
				
				Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
				c.agregar(alumno);
				
			}
			
		}
		
		
		
		
		
	}
}