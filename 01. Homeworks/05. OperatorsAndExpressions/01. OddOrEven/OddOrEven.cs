using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number :");
        int n = int.Parse(Console.ReadLine());

        if ( n % 2 == 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}

