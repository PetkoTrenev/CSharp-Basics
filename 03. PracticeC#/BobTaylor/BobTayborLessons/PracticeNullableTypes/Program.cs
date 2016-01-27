using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num;
            num = null;

            Console.WriteLine(num);
            num += 5;

            Console.WriteLine(num);
            num = 10;

            Console.WriteLine(num);
        }

    }
}
