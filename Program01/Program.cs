namespace Program02;

class Program
{
    static void Main(string[] args)
    {
        //Ejercicio 1
        Console.WriteLine("--- PRESUPUESTO DE HARDWARE ---");

        Console.Write("Ingresa el modelo del procesador (ej: i5-14400F): ");
        string cpu = Console.ReadLine();

        Console.Write("Cantidad de memoria RAM (en GB): ");
        int ram = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el precio de la placa de video (ej: 350000,50): ");
        double precioGpu = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- RESUMEN DE TU SETUP ---");
        Console.WriteLine("Procesador elegido: " + cpu);
        Console.WriteLine("Memoria RAM: " + ram + "GB");
        Console.WriteLine("Precio GPU: $" + (precioGpu)); 

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();


        //Ejercicio 2
        Console.WriteLine("--- ESTADÍSTICAS FACEIT CS2 ---");

        Console.Write("Ingresa tu nickname: ");
        string nickname = Console.ReadLine();

        Console.Write("Cantidad de Kills (Bajas): ");
        int kills = int.Parse(Console.ReadLine());

        Console.Write("Cantidad de Deaths (Muertes): ");
        double deaths = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- REPORTE DE PARTIDA ---");
        Console.WriteLine("Jugador: " + nickname);
        Console.WriteLine("Diferencia de Kills/Deaths: " + (kills - deaths));
        Console.WriteLine("Tu K/D Ratio es: " + (kills / deaths));

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();

        //Ejercicio 3
        Console.WriteLine("--- REGISTRO CANINO ---");

        Console.Write("Nombre de tu perro (ej: Eida, Tango): ");
        string perro = Console.ReadLine();

        Console.Write("Edad actual (en años): ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Peso actual en kg (ej: 25,5): ");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- FICHA ACTUALIZADA ---");
        Console.WriteLine("Paciente: " + perro);
        Console.WriteLine("Edad en meses: " + (edad * 12) + " meses");
        Console.WriteLine("Peso objetivo para el próximo mes (+0,5kg): " + (peso + 0.5) + " kg");

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();


        //Ejercicio 4
        Console.WriteLine("--- COTIZADOR DE PROYECTO WORDPRESS ---");

        Console.Write("Nombre del cliente o proyecto: ");
        string proyecto = Console.ReadLine();

        Console.Write("Horas estimadas de desarrollo: ");
        int horas = int.Parse(Console.ReadLine());

        Console.Write("Costo de tu hora de trabajo (ej: 8500,50): ");
        double costoHora = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- PRESUPUESTO GENERADO ---");
        Console.WriteLine("Proyecto: " + proyecto);
        Console.WriteLine("Tiempo de entrega estimado: " + (horas / 4) + " días (trabajando 4hs/día)");
        Console.WriteLine("Costo total del desarrollo: $" + (horas * costoHora));

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();


        //Ejercicio 5
        Console.WriteLine("--- SISTEMA DE NOTAS UTN ---");

        Console.Write("Nombre de la materia (ej: Programación 3): ");
        string materia = Console.ReadLine();

        Console.Write("Nota del primer parcial (1 a 10): ");
        int parcial1 = int.Parse(Console.ReadLine());

        Console.Write("Nota del segundo parcial (1 a 10): ");
        int parcial2 = int.Parse(Console.ReadLine());

        double promedio = (parcial1 + parcial2) / 2.0; // El 2.0 asegura que el resultado tenga decimales

        Console.WriteLine("\n--- ESTADO ACADÉMICO ---");
        Console.WriteLine("Materia: " + materia);
        Console.WriteLine("Suma total de puntos: " + (parcial1 + parcial2));
        Console.WriteLine("Tu promedio final es: " + promedio);

        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();
    }
}