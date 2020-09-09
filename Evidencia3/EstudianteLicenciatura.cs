using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencia3
{
    class EstudianteLicenciatura : Estudiante
    {
        private bool RealizarServicio;

        public EstudianteLicenciatura() : base()
        {
            RealizarServicio = false;
        }

        public EstudianteLicenciatura(int matricula, string nombre, int edad, double CuotaEscolar, bool RealizarServicio) : base(matricula, nombre, edad, CuotaEscolar)
        {
            this.RealizarServicio = RealizarServicio;
            if (RealizarServicio)
            {
                AsignarBeca(15);
            }
        }

        public override void AsignarBeca(int porcentaje)
        {
            base.AsignarBeca(porcentaje);
        }

        public override string MostrarDatos()
        {
            string texto;
            texto = base.MostrarDatos();
            if (RealizarServicio)
            {
                texto = texto + "\n Servicio : Si";
            }
            else
            {
                texto = texto + "\n Servicio : No";
            }
            return texto;
        }
    }
}
