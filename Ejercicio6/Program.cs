using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número (0 para finalizar): ");
            int numero = int.Parse(Console.ReadLine());
            int numeroMasAlto = numero;
            int numeroMasBajo = numero;
            int cantidadNumeros = 0;

            while (numero != 0)
            {
                cantidadNumeros++;

                if (numero > numeroMasAlto)
                {
                    FunMasAlto(ref numeroMasAlto, numero);
                }
                if (numero < numeroMasBajo)
                {
                    FunMasBajo(ref numeroMasBajo, numero);
                }

                Console.Write("Ingresa otro número (0 para finalizar): ");
                numero = int.Parse(Console.ReadLine());
            }

            if (cantidadNumeros > 0)
            {
                MostrarResultados(numeroMasAlto, numeroMasBajo, cantidadNumeros);
            }
            else
            {
                Console.WriteLine("No se ha introducido ningún número.");
            }

            Console.ReadLine();
        }//end main

        private static void FunMasBajo(ref int numeroMasBajo, int numero)
        {
            numeroMasBajo = numero;
        }

        private static void FunMasAlto(ref int numeroMasAlto, int numero)
        {
            numeroMasAlto = numero;
        }

        public static void MostrarResultados(int numeroMasAlto, int numeroMasBajo, int cantidadNumeros)
        {
            Console.WriteLine("Número más alto: " + numeroMasAlto);
            Console.WriteLine("Número más bajo: " + numeroMasBajo);
            Console.WriteLine("Diferencia entre el mayor y el menor: " + (numeroMasAlto - numeroMasBajo));
            Console.WriteLine("Cantidad de números introducidos: " + cantidadNumeros);
        }
    }
}
