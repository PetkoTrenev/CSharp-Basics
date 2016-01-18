using System;

class ThirdDigitSeven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int secondNumber = number / 100;        
        bool thirdDigit = secondNumber % 10 == 7;
        
        Console.WriteLine(thirdDigit);
    }
}

