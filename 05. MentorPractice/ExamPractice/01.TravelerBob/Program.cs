using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TravelerBob
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            string yearType = Console.ReadLine();
            int contractMonths = int.Parse(Console.ReadLine());
            int familyMonths = int.Parse(Console.ReadLine());

            int normalMonths = 12 - contractMonths - familyMonths;
            int weeksInMonth = 4;

            double contractTravelsIsPerMonth = 3 * weeksInMonth;
            double familyTravelPerMonth = 4; // 2*(3-1)
            double normalTravelsPerMonth = contractMonths * 3d / 5d;
            
            //Check the year if the year is leap or normal

            //Calculate travels

            //Output
        }
    }
}
