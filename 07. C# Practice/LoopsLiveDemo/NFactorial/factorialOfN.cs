using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFactorial
{
    class factorialOfN
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            int index = 0;
            while (number > 0)  //|| (number < 0)    // 4 * 3 * 2 * 1 or // 1*2*3*4
            {
                factorial *= number;

                number--;
            }
            Console.WriteLine("{0}",factorial);
        }
    }
}
