using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1 → Sumar");
        Console.WriteLine("2 → Restar");
        Console.WriteLine("3 → Multiplicar");
        Console.WriteLine("4 → Dividir");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Resultado: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("Resultado: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("Resultado: " + (num1 * num2));
                break;
            case 4:
                if (num2 != 0)
                    Console.WriteLine("Resultado: " + (num1 / num2));
                else
                    Console.WriteLine("Error: No se puede dividir entre cero");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}