using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir al usuario que ingrese un importe
            Console.WriteLine("Ingresa un importe en euros:");
            double importe = Convert.ToDouble(Console.ReadLine());
                
            // Desglosar el importe en billetes y monedas
            DesglosarImporte(importe);
        }

        static void DesglosarImporte(double importe)
        {
            // Arrays con los valores de los billetes y monedas disponibles
            int[] billetes = { 500, 200, 100, 50, 20, 10, 5 };
            double[] monedas = { 2, 1, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01 };

            // Desglosar el importe en billetes
            Console.WriteLine("Billetes:");
            for (int i = 0; i < billetes.Length; i++)
            {
                int cantidad = (int)(importe / billetes[i]);
                if (cantidad > 0)
                {
                    importe -= cantidad * billetes[i];
                    Console.WriteLine(cantidad + " de " + billetes[i] + " euros");
                }
            }

            Console.WriteLine("Monedas:");
            for (int i = 0; i < monedas.Length; i++)
            {
                int cantidad = (int)(importe / monedas[i]);
                if (cantidad > 0)
                {
                    importe -= cantidad * monedas[i];
                    Console.WriteLine(cantidad + " de " + monedas[i] + " euros");
                }
            }
        }
    }
}
