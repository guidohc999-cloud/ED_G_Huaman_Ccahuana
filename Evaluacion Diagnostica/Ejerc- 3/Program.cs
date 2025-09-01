using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese nota de Examen 1: ");
        double e1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese nota de Examen 2: ");
        double e2  = double.Parse(Console.ReadLine());

        Console.Write("Ingrese nota de Examen 3: ");
        double e3  = double.Parse(Console.ReadLine());

        double promedio = (e1 * 0.3) + (e2 * 0.3) + (e3 * 0.4);

        Console.WriteLine($"Promedio ponderado: {promedio:F2}");


    }
}
