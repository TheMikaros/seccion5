using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            int numero = int.Parse(Console.ReadLine());

            MostrarTablaMultiplicar(numero);
            Console.ReadLine();
        }

        static void MostrarTablaMultiplicar(int numero)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + numero * i);
            }
        }
    }
}
