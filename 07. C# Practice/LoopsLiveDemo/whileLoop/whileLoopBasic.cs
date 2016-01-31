using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    class whileLoopBasic
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number < 10)
            {
                Console.WriteLine(number);
                number++;
            }
        }
    }
}
