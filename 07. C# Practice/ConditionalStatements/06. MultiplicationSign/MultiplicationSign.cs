using System;

class MultiplicationSign
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());
            int result = (int)(firstNumber * secondNumber * thirdNumber);

            if (result > 0)
            {
                Console.WriteLine("+");
            }
            else if (result < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }



