using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunLight
{
    class SunLight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top of the sun
            Console.WriteLine("{0}*{0}",new string('.',((n*2)-(n/2)-1)));

            //sunrays
            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}{1}{2}*{2}{1}{0}",
                    new string('.',i+1),
                    new string('*',1),
                    new string('.',(n*3/2)-2-i)    //(n*2/2)-i-2 
                    );
            }
            //The holder of the beam
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', n),
                    new string('*',n)
                    );
            }
            // The base of the beam
            Console.WriteLine("{0}", new string('*',n*3));

            //the other part of the holder of the beam
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', n),
                    new string('*', n)
                    );
            }
            for (int i = 1; i <= n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                    new string('.',n- i),
                    new string('.',n/2+i-1)
                    );
            }
            Console.WriteLine("{0}*{0}", new string('.', ((n * 2) - (n / 2) - 1)));
        }
    }
}
