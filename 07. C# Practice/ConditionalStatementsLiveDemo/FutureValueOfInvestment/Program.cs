using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureValueOfInvestment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount = 1000.0m;
            decimal rate_of_return = 0.07M;
            int years = 10;

            Console.WriteLine("Original investment {0:C}",amount);
            Console.WriteLine("Rate of return : "+rate_of_return);
            Console.WriteLine("Over " + years +" years ");

            for (int i = 0; i < years; i++)
            {
                amount = amount + (amount * rate_of_return);
            }
            Console.WriteLine("Future value will be {0:F2}" , amount);

        }
    }
}
