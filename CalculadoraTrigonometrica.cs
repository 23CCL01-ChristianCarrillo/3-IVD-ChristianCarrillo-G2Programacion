using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el ángulo en grados: ");
        double angulo = double.Parse(Console.ReadLine());

        // Convertir a radianes
        double radianes = angulo * Math.PI / 180;

        Console.WriteLine("Seleccione la función:");
        Console.WriteLine("1 → Seno");
        Console.WriteLine("2 → Coseno");
        Console.WriteLine("3 → Tangente");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Seno: " + Math.Sin(radianes));
                break;
            case 2:
                Console.WriteLine("Coseno: " + Math.Cos(radianes));
                break;
            case 3:
                Console.WriteLine("Tangente: " + Math.Tan(radianes));
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}