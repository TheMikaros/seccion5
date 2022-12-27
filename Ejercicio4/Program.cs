using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter;
            do
            {
                Console.WriteLine("Precion una tecla: ");
                caracter = Console.ReadKey().KeyChar;

                if (EsNumero(caracter))
                {
                    Console.WriteLine("El carácter "+ caracter +" es una cifra numérica.");
                }
                else if (EsVocal(caracter))
                {
                    Console.WriteLine("El carácter "+ caracter +" es una vocal.");
                }
                else if (EsConsonante(caracter))
                {
                    Console.WriteLine("El carácter  "+ caracter +" es una consonante.");
                }
                else
                {
                    Console.WriteLine("El carácter "+ caracter +" no es ni una cifra numérica ni una letra del alfabeto.");
                }
            } while (caracter != '`');
        }

        public static bool EsNumero(char caracter)
        {
            return Char.IsDigit(caracter);
        }

        public static bool EsVocal(char caracter)
        {
            caracter = Char.ToLower(caracter);
            return caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u';
        }

        public static bool EsConsonante(char caracter)
        {
            return Char.IsLetter(caracter) && !EsVocal(caracter);
        }
    }
}
