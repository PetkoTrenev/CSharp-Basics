using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int product = (int)(a * b * c);

            if (product > 0)
            {
                Console.WriteLine("+");
            }
            else if (product < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
