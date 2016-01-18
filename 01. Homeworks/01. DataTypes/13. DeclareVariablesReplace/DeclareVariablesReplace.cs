using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DeclareVariablesReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            int oldA = 5;
            a = b;
            b = oldA;

            Console.WriteLine("The value of a is : {0}, the value of b is : {1}",a,b);
        }
    }
}
