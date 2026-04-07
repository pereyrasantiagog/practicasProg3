namespace Programa02;

class Program
{
    static void Main(string[] args)
    {
        // EJEMPLO 1: CANTIDADES FÍSICAS O COMPONENTES
        Console.WriteLine("--- BLOQUE 1: ENTEROS PARA CANTIDADES ---");
        
        int memoriaRam = 16;
        
        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Ideal para cantidades exactas, cosas que no se pueden partir a la mitad.");
        Console.WriteLine("   Memoria RAM instalada: " + memoriaRam + " GB");
        
        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
        Console.Clear();


        // EJEMPLO 2: ESTADÍSTICAS Y PUNTAJES
        Console.WriteLine("--- BLOQUE 2: ENTEROS EN VIDEOJUEGOS ---");
        
        int eloFaceit = 1550;
        
        Console.WriteLine("2. TIPO ENTERO (int):");
        Console.WriteLine("   Muy usado para llevar el registro de puntajes, niveles o rankings.");
        Console.WriteLine("   Puntos de ELO actuales: " + eloFaceit);
        
        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
        Console.Clear();


        // EJEMPLO 3: ESPECIFICACIONES TÉCNICAS
        Console.WriteLine("--- BLOQUE 3: ENTEROS PARA HARDWARE ---");
        
        int hzMonitor = 165;
        
        Console.WriteLine("3. TIPO ENTERO (int):");
        Console.WriteLine("   Sirve para valores técnicos que siempre son números redondos.");
        Console.WriteLine("   Tasa de refresco del monitor: " + hzMonitor + " Hz");
        
        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
        Console.Clear();


        // EJEMPLO 4: CONTADORES ACADÉMICOS
        Console.WriteLine("--- BLOQUE 4: ENTEROS COMO CONTADORES ---");
        
        int materiasPromocionadas = 4;
        
        Console.WriteLine("4. TIPO ENTERO (int):");
        Console.WriteLine("   Perfecto para contar cuántas veces ocurre algo (como aprobar).");
        Console.WriteLine("   Materias promocionadas en la UTN: " + materiasPromocionadas);
        
        Console.WriteLine("\nPresiona ENTER para continuar.");
        Console.ReadLine();
        Console.Clear();


        // EJEMPLO 5: MEDICIÓN DE TIEMPO
        Console.WriteLine("--- BLOQUE 5: ENTEROS PARA PLAZOS ---");
        
        int diasDesarrollo = 14;
        
        Console.WriteLine("5. TIPO ENTERO (int):");
        Console.WriteLine("   Útil para definir plazos de entrega en días u horas de un proyecto web.");
        Console.WriteLine("   Días estimados para finalizar la página: " + diasDesarrollo + " días");
        
        Console.WriteLine("\nPresiona ENTER para cerrar el programa.");
        Console.ReadLine();
    }
}