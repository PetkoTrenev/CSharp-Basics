using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b;

            b = false;
            Console.WriteLine("b is "+ b);

            b = true;
            Console.WriteLine("b is " + b);

            // A bool controls the if statement
            if (b)
            {
                Console.WriteLine("True");
            }
            b = false;
            if (b)
            {
                Console.WriteLine("This will not get executed");
            }
        }
    }
}
