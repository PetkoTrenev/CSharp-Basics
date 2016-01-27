using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class TryParse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string str = Console.ReadLine();
            int myValue;

            bool parseSuccess = int.TryParse(str, out myValue);
            Console.WriteLine(parseSuccess ? 
              "The square of the given number is " + Math.Pow(myValue,2) : "Couldnt parse it");

        }
    }
}
