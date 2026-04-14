using System;

namespace GuiaArreglosForeach
{
    class EjerciciosLinealesForeach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("    GUÍA DE EJERCICIOS: BUCLE FOREACH Y STRINGS   ");
            Console.WriteLine("==================================================\n");

            // ---------------------------------------------------------
            // EJERCICIO 1: Inicialización directa y lectura básica
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 1: LISTADO BÁSICO CON FOREACH ---");
            string[] colores = { "Rojo", "Verde", "Azul", "Amarillo", "Morado" };
            
            Console.WriteLine("Mis colores favoritos son:");
            foreach (string color in colores)
            {
                Console.WriteLine("- " + color);
            }
            
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 2: Búsqueda de un elemento específico
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 2: BUSCANDO EN EL ARREGLO ---");
            
            string[] inventario = { "Teclado", "Mouse", "Monitor", "Cables" };
            string articuloBuscado = "Monitor";
            bool encontrado = false;

            Console.WriteLine("Buscando '" + articuloBuscado + "' en el inventario...");
            
            foreach (string articulo in inventario)
            {
                if (articulo == articuloBuscado)
                {
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("¡Artículo encontrado en el inventario!");
            }
            else
            {
                Console.WriteLine("El artículo no está disponible.");
            }

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 3: Contar elementos bajo una condición
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 3: FILTRANDO ELEMENTOS ---");
            
            string[] palabras = { "Sol", "Estrella", "Luna", "Galaxia", "Luz" };
            int palabrasLargas = 0;

            Console.WriteLine("Buscando palabras con más de 4 letras...");
            
            foreach (string palabra in palabras)
            {
                if (palabra.Length > 4)
                {
                    Console.WriteLine("Encontrada: " + palabra);
                    palabrasLargas++;
                }
            }

            Console.WriteLine("Total de palabras largas: " + palabrasLargas);

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 4: Concatenación de cadenas
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 4: ARMANDO UNA ORACIÓN ---");
            
            string[] fragmentos = { "Hoy", "es", "un", "gran", "día", "para", "programar." };
            string oracionCompleta = "";

            foreach (string fragmento in fragmentos)
            {
                oracionCompleta += fragmento + " "; 
            }

            Console.WriteLine("La oración formada es:");
            Console.WriteLine(oracionCompleta);

            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();

            // ---------------------------------------------------------
            // EJERCICIO 5: Uso de foreach con otros tipos (char)
            // ---------------------------------------------------------
            Console.WriteLine("--- EJERCICIO 5: RECORRIENDO CARACTERES ---");
            
            char[] vocales = { 'A', 'E', 'I', 'O', 'U' };
            
            Console.WriteLine("Las vocales del abecedario son:");
            
            foreach (char vocal in vocales)
            {
                Console.Write(vocal + " - ");
            }

            Console.WriteLine("\n\n¡Ejercicios finalizados! Presione Enter para salir.");
            Console.ReadLine();
        }
    }
}