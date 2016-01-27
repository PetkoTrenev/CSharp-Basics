using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.3455d;
            Console.WriteLine(Math.Round(a));
            Console.WriteLine(Math.Round(a,3));
            Console.WriteLine(Math.Ceiling(a));
            Console.WriteLine(Math.Floor(a));
        }
    }
}
