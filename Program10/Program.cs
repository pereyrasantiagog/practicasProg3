using System;

namespace GuiaArreglosFor
{
    class EjerciciosLinealesFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("   GUÍA DE EJERCICIOS: USO DE .LENGTH Y FOR       ");
            Console.WriteLine("==================================================\n");

            // ---------------------------------------------------------
            // EJERCICIO 1: Uso básico de .Length y bucle for
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 1: ITERACIÓN CLÁSICA ---");
            
            int[] temperaturas = { 22, 24, 19, 30, 27, 21 };
            int cantidadTemps = temperaturas.Length;
            
            Console.WriteLine("Registros de temperatura (" + cantidadTemps + " días):");
            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine("Día " + (i + 1) + ": " + temperaturas[i] + "°C");
            }
            
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 2: Acumulación de valores usando for
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 2: CALCULAR UN PROMEDIO ---");
            
            double[] notas = { 8.5, 7.0, 9.2, 6.8, 10.0 };
            double sumaNotas = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                sumaNotas += notas[i];
            }

            double promedio = sumaNotas / notas.Length;
            
            Console.WriteLine("Cantidad de notas: " + notas.Length);
            Console.WriteLine("Suma total: " + sumaNotas);
            Console.WriteLine("El promedio es: " + promedio);

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 3: Búsqueda del valor máximo (o mínimo)
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 3: ENCONTRAR EL VALOR MÁXIMO ---");
            
            int[] puntajes = { 45, 89, 12, 104, 74, 99, 34 };
            
            int puntajeMaximo = puntajes[0];
            int posicionMaximo = 0;

            for (int i = 1; i < puntajes.Length; i++)
            {
                if (puntajes[i] > puntajeMaximo)
                {
                    puntajeMaximo = puntajes[i];
                    posicionMaximo = i; 
                }
            }

            Console.WriteLine("El puntaje más alto fue: " + puntajeMaximo);
            Console.WriteLine("Se encontró en el índice: " + posicionMaximo);

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 4: Modificación condicional de elementos
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 4: ACTUALIZANDO DATOS CON FOR ---");
            
            double[] precios = { 50.0, 120.0, 90.0, 200.0 };
            
            Console.WriteLine("Aplicando un 10% de recargo a los productos que cuesten más de 100...");

            for (int i = 0; i < precios.Length; i++)
            {
                if (precios[i] > 100.0)
                {
                    precios[i] = precios[i] * 1.10; // Aumentamos 10%
                    Console.WriteLine("Índice " + i + " modificado. Nuevo precio: $" + precios[i]);
                }
                else
                {
                    Console.WriteLine("Índice " + i + " sin cambios: $" + precios[i]);
                }
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 5: Iteración inversa (de atrás hacia adelante)
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 5: RECORRIDO A LA INVERSA ---");
            
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            
            Console.WriteLine("Días de la semana en orden inverso:");
            for (int i = dias.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("Índice " + i + ": " + dias[i]);
            }

            Console.WriteLine("\n\n¡Ejercicios finalizados! Presione Enter para salir.");
            Console.ReadLine();
        }
    }
}