using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlluminatiLockMyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",new string(('.'),n),new string(('#'),n));
            Console.WriteLine("{0}{1}{0}{1}{0}",new string(('.'),n-2),
            new string(('#'), 3));

            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}", new string(('.'), (n-4) - 2 * i),
                new string('#', 2),
                new string('.', 2 + 2 * i),
                new string('#', 1),
                new string('.', n - 2));
            }
            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                    new string('.', 1 + 2 * i),
                    new string('#', 2),
                    new string('.', (n - 3) - 2 * i),
                    new string('#', 1),
                    new string('.', n - 2));
            }
            Console.WriteLine("{0}###{0}###{0}",
                new string('.', n - 2));
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('#', n));     
                
            
        }
    }
}
