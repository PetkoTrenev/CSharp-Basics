using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = 10;
            Console.WriteLine(x);
            if (x == 10)
            {
                int y = 20; //known only for the block

                //x and y are both known 
                Console.WriteLine("{0} and {1} :",x,y);
                x = y * 2;
            }
            //Console.WriteLine(y);
            Console.WriteLine(x);
        }
    }
}
