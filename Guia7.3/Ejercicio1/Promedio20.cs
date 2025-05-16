using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Promedio20
    {
        static void Main(string[] args)
        {
            int suma = 0;
            double cant = 0;

            for (int i = 1 ; i<=20; i++)
            {
                Console.WriteLine($"Ingrese el numero {i}");
                int num = Convert.ToInt32(Console.ReadLine());
                suma += num;
                cant++;
                
            }
            double promedio = suma / cant;
            Console.WriteLine($"El promedio de los 20 numeros es: {promedio}");
        }
    }
}
