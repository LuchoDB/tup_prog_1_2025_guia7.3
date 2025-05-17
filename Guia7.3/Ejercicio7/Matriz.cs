using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Matriz
    {
        static void Main(string[] args)
        {
            float may_prom = -1;
            float men_prom = 99;
            int grupoMayProm = -2;
            int grupoMenProm = 5;

            for (int j = 1; j <= 4; j++)
            {
                Console.WriteLine($"Grupo N° {j}");
                int cant_val = 0;
                float suma = 0;
                float prom = 0;
                for (int i = 1; i <= 6; i++)
                {
                    Console.WriteLine($"Ingrese el {i}° valor");
                    int val = Convert.ToInt32(Console.ReadLine());
                    suma += val;
                    cant_val++;
                }
                prom = suma / cant_val;

                if (prom > may_prom)
                {
                    may_prom = prom;
                    grupoMayProm = j;
                }
                else if (prom < men_prom)
                {
                    men_prom = prom;
                    grupoMenProm = j;

                }
                Console.Clear();
            }

            Console.WriteLine($"Mayor Promedio: {may_prom:0.00}");
            Console.WriteLine($"Grupo con mayor promedio: {grupoMayProm}");
            Console.WriteLine($"Menor Promedio: {men_prom:0.00}");
            Console.WriteLine($"Grupo con menor promedio: {grupoMenProm}");
        }
    }
}
