using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen18
{
    public class Ejercicio1
    {
        public class empleado {
            public string Nombre { get; set; }
            public string Codigo { get; set; }
            public string PuestoTrabajo { get; set; }
            public double SueldoBase { get; set; }
            public superior Superior { get; set; }
            public grupo Oficina { get; set; }
        }

        public class superior {
            public int IdSuperior { get; set; }
        }

        public class grupo {
            public string NombreOficina { get; set; }
            public int CodigoArea { get; set; }
            public int MyProperty { get; set; }
            public List<empleado> Empleado { get; set; }
        }
    }
}
