using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter length of the line: ");
        int n =Math.Abs( int.Parse(Console.ReadLine()));
        long firstNumber = 0;
        long secondNumber = 1;
        long nextNumber = new int();
        //Console.WriteLine("First {0} of Fibonacci numbers", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(firstNumber + " ");
            nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
        Console.WriteLine();
    }
}

