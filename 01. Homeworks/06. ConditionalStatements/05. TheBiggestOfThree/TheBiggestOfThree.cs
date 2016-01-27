using System;

class TheBiggestOfThree
{
    static void Main()
    {
        Console.Write("Enter a first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter a second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter a third number : ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number of these three is  : " + firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number of these three is  : " + secondNumber);
        }
        else
        {
            Console.WriteLine("The biggest number of these three is  : " + thirdNumber);
        }
    }
}

