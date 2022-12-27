using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.


            Console.WriteLine("Introduce el cambio del dia Dollar a Euro");
            float cambio = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce los dolares a convertir:");
            int dolares = Convert.ToInt32(Console.ReadLine());

            ConvertDollartoEuro(dolares, cambio);
        }

        public static void ConvertDollartoEuro(int dll, float cambio)
        {
            Console.WriteLine(dll + " Dollares equivale a " + dll*cambio +  " Euros");
        }
    }
}
