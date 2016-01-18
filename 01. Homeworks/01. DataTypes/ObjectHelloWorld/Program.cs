using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string var1 = "Hello";
            string var2 = "World";

            object var3 = var1 + " " + var2;

            Console.WriteLine(var3);

        }

    }
}
