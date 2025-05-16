using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Encuesta
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Quisiera completar una breve encuesta? 1.Si|2.No");
            int vota = Convert.ToInt32(Console.ReadLine());

            int op_Pos = 0;
            int op_Neg = 0;
            int op_Neutro = 0;
            int encuestados = 0;
            int total_op = 0;

            do
            {
                encuestados++;
                Console.WriteLine("Muchas gracias por participar de esta encuesta.");
                Console.WriteLine("Por favor, ingrese una de las siguientes opciones para compartir su opinion");
                Console.WriteLine("0. Positiva");
                Console.WriteLine("1. Negativa");
                Console.WriteLine("2. Indeciso");

                Console.WriteLine("¿Que opina de tomar mate en clase?");
                int opinion = Convert.ToInt32(Console.ReadLine());
                switch (opinion)
                {
                    case 0:
                        op_Pos++;
                        total_op++;
                        break;
                    case 1:
                        op_Neg++;
                        total_op++;
                        break;
                    case 2:
                        op_Neutro++;
                        total_op++;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                Console.Clear();

                Console.WriteLine("¿Que opina de tener que pasar al pizarron");
                opinion = Convert.ToInt32(Console.ReadLine());
                switch (opinion)
                {
                    case 0:
                        op_Pos++;
                        total_op++;
                        break;
                    case 1:
                        op_Neg++;
                        total_op++;
                        break;
                    case 2:
                        op_Neutro++;
                        total_op++;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                Console.Clear();

                Console.WriteLine("¿Que opina de rendir parciales en computadora");
                opinion = Convert.ToInt32(Console.ReadLine());
                switch (opinion)
                {
                    case 0:
                        op_Pos++;
                        total_op++;
                        break;
                    case 1:
                        op_Neg++;
                        total_op++;
                        break;
                    case 2:
                        op_Neutro++;
                        total_op++;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                Console.Clear();

                Console.WriteLine("¿Hay que registrar otro encuestado? 1.Si|2.No");
                vota = Convert.ToInt32(Console.ReadLine());
            } while (vota != 2);

            Console.Clear();

            if (encuestados > 0)
            {
                Console.WriteLine($"Cantidad de encuestados: {encuestados} personas");
                Console.WriteLine($"Porcentaje positivo: {(op_Pos/total_op)*100}%");
                Console.WriteLine($"Porcentaje negativo: {(op_Neg / total_op) * 100}%");
                Console.WriteLine($"Porcentaje indecisos: {(op_Neutro / total_op) * 100}%");
            }
            else
            {
                Console.WriteLine("No se registraron encuestados");
            }

        }
    }
}
