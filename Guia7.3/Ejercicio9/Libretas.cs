using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Libretas
    {
        static void Main(string[] args)
        {
            float mayor_nota = 0;
            float menor_nota = 11;
            int libreta_mayor = 0;
            int libreta_menor = 0;
            string nombre_mayor = "";
            string nombre_menor = "";

            Console.WriteLine("Ingrese los alumnos a analizar");
            int alumnos = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= alumnos; i++)
            {
                Console.WriteLine($"Ingrese el nombre del {i}° alumno");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese la nota del {i}° alumno");
                int nota = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ingrese el numero de libreta del {i}° alumno");
                int libreta = Convert.ToInt32(Console.ReadLine());
                if (nota > mayor_nota)
                {
                    mayor_nota = nota;
                    libreta_mayor = libreta;
                    nombre_mayor = nombre;
                }
                else if (nota < menor_nota)
                {
                    menor_nota = nota;
                    libreta_menor = libreta;
                    nombre_menor = nombre;
                }
            }

            Console.WriteLine($"La mayor nota fue conseguida por {nombre_mayor}, sacó {mayor_nota} y su numero de libreta es {libreta_mayor}");
            Console.WriteLine($"La menor nota fue conseguida por {nombre_menor}, sacó {menor_nota} y su numero de libreta es {libreta_menor}");
        }
    }
}
