using System;

namespace EjemplosBooleanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 5 USOS PRÁCTICOS DE BOOLEANOS --- \n");

            int edad = 20;
            bool esMayorDeEdad = edad >= 18;
            Console.WriteLine($"1. ¿Es mayor de edad? {esMayorDeEdad}");

            bool estaConectado = false;
            Console.WriteLine($"2. Estado del servidor: {(estaConectado ? "Online" : "Offline")}");

            bool tieneUsuario = true;
            bool tienePasswordCorrecto = true;
            bool puedeEntrar = tieneUsuario && tienePasswordCorrecto; // Operador AND
            Console.WriteLine($"3. ¿Acceso concedido?: {puedeEntrar}");

            int stockActual = 0;
            bool hayInventario = stockActual > 0;
            Console.WriteLine($"4. ¿Hay productos disponibles?: {hayInventario}");

            bool esClienteNuevo = false;
            bool aplicarRegaloBienvenida = !esClienteNuevo; // Si NO es nuevo, es cliente antiguo
            Console.WriteLine($"5. ¿Recibe regalo de fidelidad?: {aplicarRegaloBienvenida}");

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
        }
    }
}