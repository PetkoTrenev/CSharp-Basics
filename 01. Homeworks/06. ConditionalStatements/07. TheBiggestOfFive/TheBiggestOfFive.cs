using System;

class TheBiggestOfFive
{
    static void Main()
    {
        Console.Write("Enter a first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter a second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter a third number : ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter a fourth number : ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter a fifth number : ");
        double fifthNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber &&
            firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            Console.WriteLine("The biggest number of these three is  : " + firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber &&
            secondNumber > fourthNumber && secondNumber > fifthNumber)
        {
            Console.WriteLine("The biggest number of these three is  : " + secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber &&
            thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine("The biggest number of these three is  : " + thirdNumber);
        }
        else if (fourthNumber > firstNumber && fourthNumber > secondNumber &&
            fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            Console.WriteLine("The biggest number of these three is  : " + fourthNumber);
        }
        else
        {
            Console.WriteLine("The biggest number of these three is  : " + fifthNumber);
        }

    }
}

