using System;

namespace GuiaArreglos
{
    class EjerciciosLineales
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("       GUÍA DE EJERCICIOS LINEALES CON ARREGLOS   ");
            Console.WriteLine("==================================================\n");

            // ---------------------------------------------------------
            // EJERCICIO 1: Declaración, asignación manual y lectura
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 1: FUNDAMENTOS BÁSICOS ---");
            
            int[] edades = new int[3]; 
            edades[0] = 25;
            edades[1] = 30;
            edades[2] = 22;
            
            Console.WriteLine("Edad en índice 0: " + edades[0]);
            Console.WriteLine("Edad en índice 1: " + edades[1]);
            Console.WriteLine("Edad en índice 2: " + edades[2]);
            
            Console.WriteLine("\nPresione Enter para continuar al siguiente ejercicio...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 2: Inicialización directa y bucle FOR
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 2: INICIALIZACIÓN DIRECTA Y FOR ---");
            string[] nombres = { "Ana", "Luis", "Carlos", "Marta" };
            
            Console.WriteLine("Lista de nombres usando un bucle for:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Índice " + i + ": " + nombres[i]);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 3: Bucle FOREACH (como sugería tu apunte)
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 3: LECTURA CON FOREACH ---");
            
            double[] precios = { 10.50, 25.99, 5.75, 100.00 };
            
            Console.WriteLine("Listado de precios:");
            foreach (double precio in precios)
            {
                Console.WriteLine("$" + precio);
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 4: Operaciones matemáticas con arreglos
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 4: SUMA DE ELEMENTOS ---");
            
            int[] puntajes = { 85, 90, 78, 92, 88 };
            int sumaTotal = 0;

            foreach (int punto in puntajes)
            {
                sumaTotal += punto;
            }

            Console.WriteLine("Cantidad de evaluaciones: " + puntajes.Length);
            Console.WriteLine("La suma total de los puntajes es: " + sumaTotal);

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 5: Modificación masiva de elementos
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 5: MODIFICANDO EL ARREGLO ---");
            
            int[] numerosBase = { 1, 2, 3, 4, 5 };
            
            Console.WriteLine("Multiplicando cada número por 10...");
            for (int i = 0; i < numerosBase.Length; i++)
            {
                numerosBase[i] = numerosBase[i] * 10;
                Console.WriteLine("Nuevo valor en índice " + i + ": " + numerosBase[i]);
            }

            Console.WriteLine("\n¡Ejercicios finalizados! Presione Enter para salir.");
            Console.ReadLine();
        }
    }
}