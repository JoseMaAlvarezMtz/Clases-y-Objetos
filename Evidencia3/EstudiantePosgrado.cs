using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencia3
{
    class EstudiantePosgrado : Estudiante
    {
        private int NivelSNI;

        public EstudiantePosgrado () : base()
        {
            NivelSNI = 0;
        }

        public EstudiantePosgrado (int matricula, string nombre, int edad, double CuotaEscolar, int NivelSNI): base ( matricula, nombre, edad, CuotaEscolar)
        {
            NivelSNI = ComprobarNivelSNI(NivelSNI);
            this.NivelSNI = NivelSNI;
            if ( NivelSNI==1 || NivelSNI == 2)
            {
                AsignarBeca(15);
            }
            else if (NivelSNI == 3)
            {
                AsignarBeca(30);
            }
        }

        public int ComprobarNivelSNI(int Nivel)
        {
            bool Comprobacion = false;
            do
            {
                if(Nivel >= 0 && Nivel <= 3)
                {
                    Comprobacion = true;
                }
                else
                {
                    Console.WriteLine("Nivel de SNI no valido favor de volver a capturar: ");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Nivel de SNI: ");
                    Comprobacion = int.TryParse(Console.ReadLine(), out Nivel);
                }
            } while (!Comprobacion);
            return Nivel;
        }

        public override void AsignarBeca(int porcentaje)
        {
            base.AsignarBeca(porcentaje);
        }

        public override string MostrarDatos()
        {
            string texto;
            texto = base.MostrarDatos()+"\n Nivel SNI: "+this.NivelSNI;
            return texto;
        }
    }
}
