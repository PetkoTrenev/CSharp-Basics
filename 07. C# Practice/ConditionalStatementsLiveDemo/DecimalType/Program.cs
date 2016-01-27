using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 19.95m;
            decimal discount = 0.15m;
            decimal discounted_price = price - (price * discount);
            char ch = '\t';
            Console.WriteLine("asd"+ ch +"amd");

            Console.WriteLine("{0:C}",discounted_price);
        }
    }
}
