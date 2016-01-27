using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            bool greaterAB = (a > b);
            Console.WriteLine(greaterAB); // False

            bool equalA1 = (a == 1);
            Console.WriteLine(equalA1);  // True
        }
    }
}
