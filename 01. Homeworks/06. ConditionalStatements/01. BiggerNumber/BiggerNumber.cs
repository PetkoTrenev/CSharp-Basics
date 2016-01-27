using System;

class BiggerNumber

{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = firstNumber;

        if (secondNumber > firstNumber)
        {
            thirdNumber = secondNumber;
        }
        else
        {
            thirdNumber = firstNumber;
        }
        Console.WriteLine(thirdNumber);
    }

}

