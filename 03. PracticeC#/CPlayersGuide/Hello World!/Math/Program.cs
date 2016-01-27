using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here i declare the variables

            int a;

            // Getting input from the user
            Console.WriteLine("Enter a number");
            a = int.Parse(Console.ReadLine());
            
            // This is how i check for the number to verify it : Odd or Even

            if (a % 2 == 0)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is odd");
        }
    }
}
