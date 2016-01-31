using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedFor2
{
    class NestingFors
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)   // Defines the number of outer iterations (rows)
            {
                for (int col = 1; col <= row; col++)  // Goes through each of the elements in the column
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();  // Wrapping
            }
        }
    }
}
