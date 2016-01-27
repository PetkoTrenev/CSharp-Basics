using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StarConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
