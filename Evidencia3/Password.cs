using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidencia3
{
    static class Password
    {
        public static string GenerarPassword()
        {
            Random rdn = new Random();
            string permitidos = "abcdefghijklmnopqrstuvwxyz1234567890";
            int largo = permitidos.Length;
            char letra;
            int longitud = 8;
            string Pass = string.Empty;
            for (int i = 0; i < longitud; i++)
            {
                letra = permitidos[rdn.Next(largo)];
                Pass += letra.ToString();
            }
            return Pass;
        }

    }
}
