using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un carácter: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if ("aeiouAEIOU".IndexOf(c) >= 0)
        {
            Console.WriteLine("Es una vocal");
        }
        else if (char.IsDigit(c))
        {
            Console.WriteLine("Es un dígito");
        }
        else
        {
            Console.WriteLine("No es vocal ni dígito");
        }
    }
}