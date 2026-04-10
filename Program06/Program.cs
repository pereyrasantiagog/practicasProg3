using System;

namespace Programa06_Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- BLOQUE DE CONSTANTES (Valores fijos) ---

            const string MONEDA = "USD";
            
            const double IVA = 0.16; // 16% de impuesto

            const int ENVIO_GRATIS_MINIMO = 50; 

            const int CODIGO_EXITO = 200;

            const string MSG_BIENVENIDA = "Bienvenido a TechShop. Todos los precios en: ";

            double precioProducto = 45.99;
            double totalConIva = precioProducto * (1 + IVA);
            bool calificaEnvioGratis = precioProducto >= ENVIO_GRATIS_MINIMO;

            Console.WriteLine("=== SISTEMA DE VENTAS ===");
            Console.WriteLine(MSG_BIENVENIDA + MONEDA);
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Precio: {precioProducto} {MONEDA}");
            Console.WriteLine($"Impuesto aplicado ({IVA * 100}%): {precioProducto * IVA:F2} {MONEDA}");
            Console.WriteLine($"Total a pagar: {totalConIva:F2} {MONEDA}");
            
            Console.WriteLine("\n--- VERIFICACIÓN DE ENVÍO ---");
            Console.WriteLine($"Monto mínimo para envío gratis: {ENVIO_GRATIS_MINIMO} {MONEDA}");
            Console.WriteLine($"¿Tiene envío gratis?: {calificaEnvioGratis}");

            Console.WriteLine("\n--- ESTADO FINAL ---");
            Console.WriteLine("Operación finalizada con código: " + CODIGO_EXITO);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}