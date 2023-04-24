using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen18
{
    public class Ejercicio4
    {
        class triangulo
        {
            public double Base { get; set; }
            public double Altura { get; set; }
            
            public float baseT, altura;
            public float área()
            {
                return (baseT * altura) / 2;
            }
            public object achatar(triangulo triangulo)
            {
                triangulo.Altura = triangulo.Altura * .90;
                return triangulo;

            }

        }

        

    }
}
