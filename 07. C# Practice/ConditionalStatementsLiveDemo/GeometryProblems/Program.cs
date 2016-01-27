using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            double theta; // angle in radians

            for ( theta = 0.1; theta < 0.5; theta = theta + 0.1)
            {
                Console.WriteLine("Sine of " + theta + " is " + Math.Sin(theta));
                Console.WriteLine("Cosine of " + theta + " is " + Math.Cos(theta));
                Console.WriteLine("Tangent of " + theta + " is " + Math.Tan(theta));
                Console.WriteLine();    
            }
        }
    }
}
