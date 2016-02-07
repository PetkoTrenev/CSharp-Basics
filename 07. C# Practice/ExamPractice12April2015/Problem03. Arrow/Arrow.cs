using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //top part part of the base
            Console.WriteLine("{0}{1}{0}",
                new string('.',n/2),
                new string('#',n));

            //base of arrow    
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', n / 2),
                    new string('.', n - 2));
            }
            // static base of the blade of the arrow
            Console.WriteLine("{0}{1}{0}",
                new string('#', n / 2 + 1),
                new string('.',n-2));

            // the blade of the arrow
            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('.', i+1),
                    new string('#', 1),
                    new string('.', (2 * n - 1) - 4 -(i * 2 )));
            }
            Console.WriteLine("{0}#{0}",
                new string('.',n-1));
        }
    }
}
