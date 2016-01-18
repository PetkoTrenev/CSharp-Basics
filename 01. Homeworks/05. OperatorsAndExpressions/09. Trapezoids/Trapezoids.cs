using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = ((a + b) / 2) * height;

        Console.WriteLine(area);

    }
}

