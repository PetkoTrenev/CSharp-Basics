using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumnRow
{
    class ColumnRow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0;  col < 4;  col++)
                {
                    Console.Write( "{0,3} ",n);
                    n++;
                }
                Console.WriteLine();
            }

            // 0 1 2 3
            // 0 1 2 3
            // 0 1 2 3

        }
    }
}
