using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen18
{
    public class Ejercicio5
    {
        public class persona {
            public string Nombre { get; set; }
            public short Edad { get; set; }
            public double Peso { get; set; }

            public string CambiaNombre() {
                Nombre = "Hola " + Nombre;
                return Nombre;
            } 
            public double calcula() {
                return Edad * Peso;
            } 

        }
    }
}
