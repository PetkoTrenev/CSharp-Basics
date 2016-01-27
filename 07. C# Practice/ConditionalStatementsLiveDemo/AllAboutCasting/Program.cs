using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            int i;
            byte b;
            char ch;
            uint u;
            short s;
            long l;

            x = 10.0; // or m
            y = 3d;
            double division = x / y;
            Console.WriteLine("The double division is : {0}",division);

            // Cast a double to int , fractional part lost
            i =(int) (x / y);
            Console.WriteLine("Integer outcome {0}",i);
            Console.WriteLine();

            // Cast an int into byte,no data loss.
            i = 255;
            b = (byte)i;
            Console.WriteLine();

            // cast an int into a byte with data loss
            i = 257;
            b = (byte)i;
            Console.WriteLine();






        }
    }
}
