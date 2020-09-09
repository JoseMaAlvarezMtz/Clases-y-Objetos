using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencia3
{
    class Estudiante
    {
        protected int matricula;
        protected string nombre;
        protected int edad;
        protected string password;
        protected double CuotaEscolar;

        public Estudiante()
        {
            matricula = 1666476;
            nombre = "Jose Alvarez";
            edad = 22;
            password = Password.GenerarPassword();
            CuotaEscolar = 2000;
        }

        public Estudiante(int matricula, string nombre, int edad, double CoutaEscolar)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.edad = AsignarEdad(edad);
            password = Password.GenerarPassword();
            this.CuotaEscolar = CoutaEscolar;
        }

        public int AsignarEdad(int E)
        {
            if (E <= 14)
            {
                E = 15;
            }
            else if (E >= 91)
                {
                    E = 90;
                }
           
            return E;
        }

        public virtual string MostrarDatos( )
        {
            string mensaje = "Nombre del estudiante: " + this.nombre + "\n Edad: " + this.edad + "\n Matricula: " + this.matricula + "\n Password: " + this.password+"\n Cuota: "+this.CuotaEscolar;
            return mensaje;
        }
        public virtual void AsignarBeca(int porcentaje)
        {
            double descuento;
            descuento = (double)porcentaje / 100;
            //Console.WriteLine(descuento);
            descuento = CuotaEscolar * descuento;
            //Console.WriteLine(descuento);
            this.CuotaEscolar = CuotaEscolar - descuento;
            //Console.WriteLine(CuotaEscolar);
            //Console.ReadLine();
        }
       
    }


}
