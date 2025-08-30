using System;

class Ejercicio1
{
    static void Main()
    {
        Console.Write("Ingrese su año de nacimiento: ");
        int anioNacimiento = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el año actual: ");
        int anioActual = int.Parse(Console.ReadLine());

        int edad = anioActual - anioNacimiento;

        Console.WriteLine($"Tu edad es: {edad}");

        if (edad >= 18)
            Console.WriteLine("Eres mayor de edad.");
        else
            Console.WriteLine("Eres menor de edad.");
    }
}

