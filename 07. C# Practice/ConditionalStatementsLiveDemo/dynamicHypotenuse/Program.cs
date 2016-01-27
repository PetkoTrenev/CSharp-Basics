using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicHypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1 = 4.0;
            double s2 = 5.0;

            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.Write("Hypotenuse of a triangle with sides " + s1 + " by " + s2 + " is ");
            Console.WriteLine("{0:#.###}.",hypot);
        }
    }
}
