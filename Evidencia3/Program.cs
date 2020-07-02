using System;
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
            double CuotaEscolar = 0.0;
            string op;
            bool validar = false;
            bool Servicio = false;
            for (int i =0; i<n; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingresa la matricula del estudiante #" + (i + 1) + ": ");
                matricula = ComprobarNumero(Console.ReadLine());
                Console.WriteLine("Ingresa el nombre del estudiante #" + (i + 1) + ": ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la edad del estudiante #" + (i + 1) + ": ");
                edad = ComprobarNumero(Console.ReadLine());
                Console.WriteLine("Ingresa la cuota escolar del estudiante #" + (i + 1) + ": ");
                CuotaEscolar = double.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("El estudiante esta cursando licenciatura(l) o Posgrado(p).\n Ingresa L para Licenciatura.\n Ingresa P para Posgrado. \n Ingresa (N) si esta opcion no aplica.");
                    op = Console.ReadLine();
                    if (op == "l" || op == "L")
                    {
                        op = "l";
                    }
                    if (op == "p" || op == "P")
                    {
                        op = "p";
                    }
                    if (op == "n" || op == "N")
                    {
                        op = "n";
                    }
                    switch (op)
                    {
                        case "l":
                            arreglo[i] = new EstudianteLicenciatura();
                            Servicio = Licenciatura();
                            if (Servicio)
                            {
                                arreglo[i] = new EstudianteLicenciatura(matricula, nombre, edad, CuotaEscolar, Servicio);
                            }
                            validar = true;
                            break;

                        case "p":
                            arreglo[i] = new EstudiantePosgrado();
                            int SNI;
                            Console.WriteLine("Ingresa nivel de SNI:");
                            SNI = ComprobarNumero(Console.ReadLine());
                            arreglo[i] = new EstudiantePosgrado(matricula, nombre, edad, CuotaEscolar, SNI);
                            validar = true;
                            break;

                        case "n":
                            validar = true;
                            break;
                        default:
                            Console.WriteLine("Opcion no valida.");
                            validar = false;
                            break;
                    }
                } while (!validar);    

                
                /*if (Console.ReadLine() == "si")
                {
                    arreglo[i] = new EstudianteLicenciatura();
                    Console.WriteLine("Servicio:");
                    if (Console.ReadLine() == "s")
                    {
                        arreglo[i] = new EstudianteLicenciatura(matricula, nombre, edad, CuotaEscolar, Servicio);
                    }
                   
                }*/
                //arreglo[i] = new  Estudiante(matricula,nombre,edad,CuotaEscolar);

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

        public static int ComprobarNumero(string numero)
        {
            int Numero=0;
            bool salida = false;
            try
            {
                 Numero = int.Parse(numero);
            }catch(Exception Ex)
            {
                do
                {
                    Console.WriteLine("No se ingreso un dato numerico. Favor de volver a ingresar un dato numerico.");
                    Console.ReadLine();
                    //Console.Clear();
                    Console.WriteLine("Ingresa un dato numerico: ");
                    salida = int.TryParse(Console.ReadLine(), out Numero);
                } while (!salida);
            }
            
            return Numero;
        }

        public static bool Licenciatura()
        {
            bool valor = false;
            Console.WriteLine("¿Tiene Servicio? Si (s) No (n): ");
            if (Console.ReadLine() == "s")
            {
                valor = true;
            }
            else
            {
                valor = false;
            }
            return valor;
        }
    }
}
