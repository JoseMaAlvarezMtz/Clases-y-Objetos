﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencia3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prueba = false;
            int n = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingresa la cantidad de alumnos a capturar:");
                prueba = int.TryParse(Console.ReadLine(), out n);
            } while (!prueba);

            Estudiante[] arreglo = new Estudiante[n];
            int matricula = 0;
            string nombre="";
            int edad= 0;
            for(int i =0; i<n; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingresa la matricula del estudiante #" + (i + 1) + ": ");
                matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el nombre del estudiante #" + (i + 1) + ": ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la edad del estudiante #" + (i + 1) + ": ");
                edad = int.Parse(Console.ReadLine());
                arreglo[i] = new  Estudiante(matricula,nombre,edad);
            }
            Console.Clear();
            Console.WriteLine("Datos de los alumnos: ");
            string mensaje;
  
            for(int i = 0; i < n; i++)
            {
                mensaje = arreglo[i].MostrarDatos();
                Console.WriteLine(mensaje);
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
