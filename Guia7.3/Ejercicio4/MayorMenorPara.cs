using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class MayorMenorPara
    {
        static void Main(string[] args)
        {
            int mayor = 0;
            int menor = 0;

            for (int i = 1; i<=20; i++)
            {
                Console.WriteLine($"Ingrese el {i}° numero");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > mayor)
                {
                    mayor = num;
                } else if (num < menor)
                {
                    menor = num;
                }
            }
            Console.WriteLine($"El mayor numero ingresado es {mayor}");
            Console.WriteLine($"El menor numero ingresado es {menor}");
        }
    }
}
