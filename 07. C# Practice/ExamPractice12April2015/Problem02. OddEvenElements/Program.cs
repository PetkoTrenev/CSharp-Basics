using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.OddEvenElements
{
    class Program
    {
        static void Main(string[] args)
        {
            double oddSum = 0;
            decimal oddMin = decimal.MaxValue;
            decimal oddMax = decimal.MinValue;

            double evenSum = 0;
            decimal evenMin = decimal.MaxValue;
            decimal evenMax = decimal.MinValue;

            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');
            if (input == "")
            {
                // Known issue: split on empty string returns 1 token ""
                inputNumbers = new string[0];
            }
            bool odd = true;
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                decimal number = decimal.Parse(inputNumbers[i]);
                if (odd)
                {
                    oddSum += (double)number;
                    oddMin = Math.Min(oddMin, number);
                   // Console.WriteLine(oddMin);
                    oddMax = Math.Max(oddMax, number);
                    //Console.WriteLine(oddMax);
                }
                else
                {
                    evenSum += (double)number;
                    evenMin = Math.Min(evenMin, number);
                    //Console.WriteLine(evenMin);
                    evenMax = Math.Max(evenMax, number);
                    //Console.WriteLine(evenMax);
                }
                odd = !odd;
            }
            if (inputNumbers.Length == 0)
            {
                Console.WriteLine(
                    "OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            }
            else if (inputNumbers.Length == 1)
            {
                Console.WriteLine(
                    "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No",
                    (double)oddSum, (double)oddMin, (double)oddMax);
            }
            else
            {
                Console.WriteLine(
                    "OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                    (double)oddSum, (double)oddMin, (double)oddMax,
                    (double)evenSum, (double)evenMin, (double)evenMax);
            }


        }
    }
}
