using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen18
{
    public class Ejercicio2
    {
        //-------------Codigo Original-----------------

        //public void metodoA(int[], int pos)
        //{
        //    int sum = 0;
        //    while (i = pos)
        //    {
        //        sum = sum + vec[1];
        //    }
        //    return sum;
        //}


        //correcion
        public int metodoA(int[] vec, int pos)//declarar el nombre del arreglo------Para poder regresar un valor no se puede dejar en void 
        {
            int sum = 0;
            int i = 0;//declar la variable i
            while (i == pos)//falta un "="
            {
                sum = sum + vec[i];//si lo que se desea es sumar todos los valores del arreglo no se puede dejar en 1 en su lugar se coloca i ya que este es un valor dinamico
                i = i + 1;//incremantar la variable i de lo contrario es un bucle infinito
            }
            return sum;
        }
    }
}
