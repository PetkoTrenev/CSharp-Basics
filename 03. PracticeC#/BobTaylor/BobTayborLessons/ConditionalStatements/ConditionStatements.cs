using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class ConditionStatements
    {
        static void Main(string[] args)
        {
            int theVal = 53;

            if (theVal <= 50)
            {
                Console.WriteLine("The first value less than 50");
            }
            else if (theVal == 51)
            {
                Console.WriteLine("The val is 51");
            }
            else
            {
                Console.WriteLine("There are no values");
            }


        }
    }
}
