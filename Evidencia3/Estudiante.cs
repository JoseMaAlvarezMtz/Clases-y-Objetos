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
        protected double CoutaEscolar;

        public Estudiante()
        {
            matricula = 1666476;
            nombre = "Jose Alvarez";
            edad = 22;
            password = Password.GenerarPassword();
        }

        public Estudiante(int matricula, string nombre, int edad)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.edad = AsignarEdad(edad);
            password = Password.GenerarPassword();
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

        public string MostrarDatos( )
        {
            string mensaje = "Nombre del estudiante: " + this.nombre + "\n Edad: " + this.edad + "\n Matricula: " + this.matricula + "\n Password: " + this.password;
            return mensaje;
        }
    }
}
