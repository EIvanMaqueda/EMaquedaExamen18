using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen18
{
    public class Ejercicio3
    {

        public static void Inversa()
        {
            string cadena = "adcdefg";
            char[] chars= cadena.ToCharArray();
            Array.Reverse(chars);
            cadena = string.Concat(chars);
            Console.WriteLine(cadena);
        }
  


    }
}
