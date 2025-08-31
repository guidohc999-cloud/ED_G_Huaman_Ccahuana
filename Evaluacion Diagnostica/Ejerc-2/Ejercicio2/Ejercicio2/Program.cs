using System;

class Ejercicio2
{
    static void Main()
    {
        Console.Write("ingrese un numero entero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
            Console.WriteLine("El mumero es par.");
        else
            Console.WriteLine("El es impar.");

        if (numero % 3 == 0)
            Console.WriteLine("Es multiplo de 3.");
            Console.WriteLine("Es multiplo de 5.");
    }
}
