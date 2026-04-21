using System;

class Program
{
    static void Main()
    {
        const double precioBase = 650;
        const double IVA = 0.12;

        double precioIVA = precioBase * (1 + IVA);

        Console.Write("Ingrese la cantidad de impresoras: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione la forma de pago:");
        Console.WriteLine("1 → Efectivo (10%)");
        Console.WriteLine("2 → Tarjeta de crédito (5%)");
        Console.WriteLine("3 → Vale de regalo (15%)");
        int opcion = int.Parse(Console.ReadLine());

        double subtotal = cantidad * precioIVA;
        double descuento = 0;
        string formaPago = "";

        switch (opcion)
        {
            case 1:
                descuento = subtotal * 0.10;
                formaPago = "Efectivo";
                break;
            case 2:
                descuento = subtotal * 0.05;
                formaPago = "Tarjeta de crédito";
                break;
            case 3:
                descuento = subtotal * 0.15;
                formaPago = "Vale de regalo";
                break;
            default:
                Console.WriteLine("Opción inválida");
                return;
        }

        double total = subtotal - descuento;

        Console.WriteLine("\n--- DETALLE DE PAGO ---");
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Precio unitario con IVA: Q" + precioIVA);
        Console.WriteLine("Total sin descuento: Q" + subtotal);
        Console.WriteLine("Forma de pago: " + formaPago);
        Console.WriteLine("Descuento: Q" + descuento);
        Console.WriteLine("Total a pagar: Q" + total);
    }
}