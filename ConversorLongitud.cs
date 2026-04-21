using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione la unidad de origen:");
        Console.WriteLine("1 → Metros");
        Console.WriteLine("2 → Pies");
        Console.WriteLine("3 → Centímetros");
        Console.WriteLine("4 → Pulgadas");
        int origen = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor a convertir: ");
        double valor = double.Parse(Console.ReadLine());

        double metros = 0;

        // Convertir a metros
        switch (origen)
        {
            case 1:
                metros = valor;
                break;
            case 2:
                metros = valor * 0.3048;
                break;
            case 3:
                metros = valor / 100;
                break;
            case 4:
                metros = valor * 0.0254;
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        Console.WriteLine("Seleccione la unidad de destino:");
        Console.WriteLine("1 → Metros");
        Console.WriteLine("2 → Pies");
        Console.WriteLine("3 → Centímetros");
        Console.WriteLine("4 → Pulgadas");
        int destino = int.Parse(Console.ReadLine());

        double resultado = 0;

        // Convertir desde metros
        switch (destino)
        {
            case 1:
                resultado = metros;
                break;
            case 2:
                resultado = metros / 0.3048;
                break;
            case 3:
                resultado = metros * 100;
                break;
            case 4:
                resultado = metros / 0.0254;
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}