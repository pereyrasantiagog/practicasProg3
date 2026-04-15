using System;

namespace Practica_En_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidades = 20;
            string[] nombres = new string[cantidades];
            int[] edades = new int[cantidades];

            for (int i = 0; i < cantidades; i++)
            {
                Console.Write("Ingrese el nombre de la persona " + (i + 1) + ": ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese la edad de " + nombres[i] + ": ");
                edades[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < cantidades; i++)
            {
                Console.Write($"{nombres[i]} tiene {edades[i]} años");
                if(edades[i] >30)
                {
                    Console.WriteLine("- Puede pasar");
                }
                else
                {
                    Console.WriteLine("- NO puede pasar");
                }
            }

            Console.WriteLine("\nPresione Enter para finalizar el programa...");
            Console.ReadLine();
        }
    }

}