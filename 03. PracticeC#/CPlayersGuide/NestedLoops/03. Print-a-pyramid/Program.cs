using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Print_a_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            char space = ' ';

            Console.WriteLine("Please enter a number for n : ");
            int NumberOfRows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= NumberOfRows; i++)
            {
                for (int j = NumberOfRows - i; j >= 1 ; j++)
                {
                    Console.Write(space);
                }
                    for (int k = 1; k <= (i*2)-1; k++)
                    {
                     Console.Write(star);
                }
                Console.WriteLine();
            }
        }
    }
}
