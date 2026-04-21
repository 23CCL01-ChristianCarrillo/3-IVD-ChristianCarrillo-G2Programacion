using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("----- MENÚ -----");
        Console.WriteLine("1 → Hamburguesa");
        Console.WriteLine("2 → Pizza");
        Console.WriteLine("3 → Pollo frito");
        Console.WriteLine("4 → Ensalada");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Usted pidió: Hamburguesa");
                break;
            case 2:
                Console.WriteLine("Usted pidió: Pizza");
                break;
            case 3:
                Console.WriteLine("Usted pidió: Pollo frito");
                break;
            case 4:
                Console.WriteLine("Usted pidió: Ensalada");
                break;
            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}