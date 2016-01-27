using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IllimunatiLock
{
    class Program
    {
        static void Main(string[] args)
        {
            // First rows are equal 
            int n = int.Parse(Console.ReadLine());
            //Top
            string firstAndLastRow = new string('.', n) + new string('#', n) + 
                new string('.', n);
            Console.WriteLine(firstAndLastRow);

            //Middle part
            for (int i = 0; i < n/2; i++)
            {
                string firstLoop = new string('.', (n - 2) - 2 * i) + new string('#', 2) +
                    new string('.', i * 2) + new string('#', 1) + new string('.', n - 2)
                    + new string('#', 1) + new string('.', i * 2) + new string('#', 2) +
                    new string('.', (n - 2) - 2 * i);
                Console.WriteLine(firstLoop);
                   
            }
            for (int i = 0; i < n/2; i++)
            {
                string secondLoop = new string('.', 1 + (i * 2)) + new string('#', 2) +
                    new string('.', (n - 3) - (i * 2)) + new string('#', 1) + new string('.', n - 2) +
                    new string('#', 1) + new string('.', (n - 3) - i * 2) + new string('#', 2) +
                    new string('.', 1 + (i * 2));

                Console.WriteLine(secondLoop);
            }
            Console.WriteLine(firstAndLastRow);
        }
    }
}
