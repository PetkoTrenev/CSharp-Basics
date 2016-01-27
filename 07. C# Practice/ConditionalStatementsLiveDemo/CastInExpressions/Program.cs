using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastInExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            for ( n = 1.0; n <= 10; n++)
            {
                Console.WriteLine("The square root of {0} is {1}",n,Math.Sqrt(n));
                Console.WriteLine("The whole number part is : {0} ",(int)(Math.Sqrt(n)));
                Console.WriteLine("The fractional part is : {0}",Math.Sqrt(n)-(int)(Math.Sqrt(n)));
                Console.WriteLine();
            }
        }
    }
}
