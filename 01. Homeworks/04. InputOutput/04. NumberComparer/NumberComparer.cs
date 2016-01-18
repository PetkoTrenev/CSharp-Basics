using System;

class NumberComparer
{
    static void Main()
    {
        // Input of the program
        Console.WriteLine("Enter a number for a: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter a number for b: ");
        double b = double.Parse(Console.ReadLine());

        // Output of the program
        Console.WriteLine("greater: {0}",Math.Max(a,b));    

    }
}

