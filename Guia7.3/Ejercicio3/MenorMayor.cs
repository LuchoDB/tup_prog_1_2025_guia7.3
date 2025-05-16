using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class MenorMayor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero o ingrese -1 para salir");
            int num = Convert.ToInt32(Console.ReadLine());
            int mayor = num;
            int menor = num;
            int cant = 0;

            while (num != -1 && num>=0 && num <= 100)
            {
                cant++;
                if (num > mayor)
                {
                    mayor = num;
                } else if (num < menor)
                {
                    menor = num;
                }
                Console.WriteLine("Ingrese otro numero o ingrese -1 para salir");
                num = Convert.ToInt32(Console.ReadLine());
            }

            if (cant > 0)
            {
                Console.WriteLine($"El mayor numero ingresado es {mayor}");
                Console.WriteLine($"El menor numero ingresado es {menor}");
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros");
            }
        }
    }
}
