using System;

class MultiplificationSign

{
    static void Main()
    {
        Console.WriteLine("Enter three numbers");

        Console.Write("Enter first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number : ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double multiplication = firstNumber * secondNumber * thirdNumber;

        if (multiplication > 0)
        {
            Console.WriteLine("+");
        }
        else if (multiplication < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("0");
        }

    }
}
