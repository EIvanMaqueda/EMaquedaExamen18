using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen18
{
    public class Ejercicio6
    {
        public static void Instancia() {
            Ejercicio5.persona persona = new Ejercicio5.persona();
            persona.Nombre = "Juan";
            persona.Edad = 15;
            persona.Peso = 50;
            
            Console.WriteLine(persona.CambiaNombre());
            Console.WriteLine(persona.calcula());

            Console.ReadKey();
        }
    }
}
