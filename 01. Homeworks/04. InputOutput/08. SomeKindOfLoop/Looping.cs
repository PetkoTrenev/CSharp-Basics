using System;

class Looping
{
    static void Main(string[] args)
    {
        Console.WriteLine("numbers");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("sum");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

