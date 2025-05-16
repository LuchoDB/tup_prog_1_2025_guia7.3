using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class PromedioVarios
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un num o pulse 0 para salir");
            int num = Convert.ToInt32(Console.ReadLine());

            int suma = 0;
            double cant = 0;

            while (num!= 0)
            {
                suma += num;
                cant++;
                Console.WriteLine("Ingrese un num o pulse 0 para salir");
            }

            if (cant > 0)
            {
                double prom = suma / cant;
                Console.WriteLine($"El promedio de los numero es {prom}");
            }
            else
            {
                Console.WriteLine("No se ingresaron numeros");
            }

        }
    }
}
