using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedFor
{
    class NestingFors
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; i < 20; j++)
                {
                    for (int k = 0; i < 20; k++)
                    {
                        Console.WriteLine("i : {0} , j : {1} , k : {2} ",i,j,k);
                    }
                }
            }
        }
    }
}
