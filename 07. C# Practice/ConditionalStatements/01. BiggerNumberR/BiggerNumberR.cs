using System;

class BiggerNumberR
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double biggerNumber = firstNumber;

        if (secondNumber > firstNumber)
        {
            biggerNumber = secondNumber;
        }
        Console.WriteLine(biggerNumber);
    }
}

