using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceOfDiamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            string top = new string('*', n);
            Console.WriteLine(top);

            //Middle
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("*{0}{1}{0}*",new string ('-',(n/2)-i),
                new string('@',((i*2+1)-2)));                 
            }
            for (int i = 1; i < n/2-1; i++)
            {
                Console.WriteLine("*{0}{1}{0}*",new string('-',i),
                    new string('@',(n / 2 - i)*2 -1));
            }
            //Bottom 
            Console.WriteLine(top);
        }
    }
}
