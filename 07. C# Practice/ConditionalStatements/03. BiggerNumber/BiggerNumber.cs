using System;

//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. Examples:

class BiggerNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a second number : ");
        double b = double.Parse(Console.ReadLine());


        if (a > b)
        {
            Console.Write("{0} {1}", b, a);
        }
        else
        {
            Console.Write("{0} {1}", a, b);
        }
        Console.ReadLine();
    }
}

