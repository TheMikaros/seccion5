using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2- Crear una calculadora , usando funciones de suma, resta, multiplicación y división.
            //    *Se creara un menú por consola, de la siguiente forma:
            // 1 - Suma
            // 2 - Resta
            // 3 - Multiplicación
            // 4 - División
            //Seleccione la opción:
            //dependiendo de la selección, se pedirán 2 números, y usando las funciones creadas, devolverá el resultado por consola

            int seleccion = -1;
          
               

            Console.WriteLine("Introduce el numero 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el numero 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (seleccion)
            {
                case 1: FunSumar(num1, num2);
                    break;
                case 2:
                    FunResta(num1, num2);
                    break;
                case 3:
                    FunMultiplicacion(num1, num2);
                    break;
                case 4:
                    FunDivision(num1, num2);
                    break;
            }

            Console.ReadLine();
        }

        private static void FunDivision(int num1, int num2)
        {
            Console.WriteLine("La divison de " + num1 + " / " + num2 + " es igual a : " + (num1 / num2));
        }

        private static void FunMultiplicacion(int num1, int num2)
        {
            Console.WriteLine("La multiplicacion de " + num1 + " * " + num2 + " es igual a : " + (num1 * num2));
        }

        private static void FunResta(int num1, int num2)
        {
            Console.WriteLine("La resta de " + num1 + " - " + num2 + " es igual a : " + (num1 - num2));
        }

        private static void FunSumar(int num1, int num2)
        {
            Console.WriteLine("La suma de " + num1 + " + " + num2 + " es igual a : " + (num1 + num2));
        }
    }
}
