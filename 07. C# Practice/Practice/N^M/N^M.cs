using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_M
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            long product = 1;
            int number = n;

            do
            {
                product *= number;
                number++;
            }
            while (number <= m);
            Console.WriteLine(product);
        }
    }
}
