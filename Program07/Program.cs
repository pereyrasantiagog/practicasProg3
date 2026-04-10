using System;

namespace Programa07_GameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- BLOQUE DE CONSTANTES DE MOTOR ---

            const decimal GRAVEDAD_TIERRA = 9.81m;

            const int MAX_JUGADORES = 64;

            const char ICONO_VIDA = '♥';

            const string SERVIDOR_REGION = "LATAM-01";

            const bool MODO_DIOS = true;


            // --- EJECUCIÓN DEL SISTEMA ---

            Console.WriteLine(">>> INICIALIZANDO MOTOR DE JUEGO <<<");
            Console.WriteLine($"Conectando a: {SERVIDOR_REGION}");
            Console.WriteLine($"Capacidad del servidor: {MAX_JUGADORES} usuarios.");

            Console.WriteLine("\n--- ESTADO DEL PERSONAJE ---");
            Console.WriteLine($"Salud actual: 100 {ICONO_VIDA}");
            Console.WriteLine($"Gravedad del mundo: {GRAVEDAD_TIERRA} m/s²");
            
            Console.WriteLine("¿El jugador es inmortal?: " + (MODO_DIOS ? "SÍ (Modo Debug)" : "NO"));

            decimal pesoObjeto = 10.5m;
            decimal fuerzaCaida = pesoObjeto * GRAVEDAD_TIERRA;
            Console.WriteLine($"Fuerza de impacto de objeto (10.5kg): {fuerzaCaida:N2} Newtons");

            Console.WriteLine("\nPresiona ENTER para cerrar el motor.");
            Console.ReadLine();
        }
    }
}