using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el sector del estadio:");
        Console.WriteLine("1 → Palco (Q300.00)");
        Console.WriteLine("2 → Tribuna (Q100.00)");
        Console.WriteLine("3 → Preferencia (Q50.00)");
        Console.WriteLine("4 → Generales (Q30.00)");

        int opcion = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de entradas: ");
        int cantidad = int.Parse(Console.ReadLine());

        double precio = 0;

        switch (opcion)
        {
            case 1:
                precio = 300;
                break;
            case 2:
                precio = 100;
                break;
            case 3:
                precio = 50;
                break;
            case 4:
                precio = 30;
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        double total = precio * cantidad;

        Console.WriteLine("Total a pagar: Q" + total);
    }
}