using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsLiveDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSnowing = bool.Parse(Console.ReadLine());
            bool isTomorrowSnowing = bool.Parse(Console.ReadLine());

            bool isSnowingThisWeek = (isSnowing && isTomorrowSnowing);
                
            Console.WriteLine(isSnowing);
                
        }
    }
}
