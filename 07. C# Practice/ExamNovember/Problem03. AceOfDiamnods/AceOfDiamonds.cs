using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.AceOfDiamnods
{
    class AceOfDiamonds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top
            Console.WriteLine("{0}",new string(('*'), n));
            
            //middle upper part
            for (int i = 0; i < n/2 -1 ; i++)
            {
                Console.WriteLine("*{0}{1}@{1}{0}*",
                    new string('-', (n / 2 - 1) - i),
                    new string('@', i));
            }

            Console.WriteLine("*{0}*", new string('@', n - 2));//3RD PART - STATIC         


            //middle lower part
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                Console.WriteLine("*{0}{1}{0}*",
                    new string('-', i),
                    new string('@', (n - 2 - 2 * i)));

            }

            //bottom
            Console.WriteLine("{0}", new string(('*'), n));
        }
    }
}
