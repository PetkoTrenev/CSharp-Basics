using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparinngDoubles
{
    class CompareDoubles
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber;
            double thirdNumber;

            Console.WriteLine("Enter first number : ");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter first number : ");
            secondNumber = double.Parse(Console.ReadLine());

            thirdNumber = firstNumber + secondNumber;
            Console.WriteLine("The result is : "+thirdNumber);
        }
    }
}
