using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsEnums
{
    class ConstEnum
    {
        enum Temperatures
        {
            FREEZING = 32,
            LUKEWARM = 65,
            ROOMTEMP = 72,
            HOT = 105,
            BOILING = 215
        }
        static void Main(string[] args)
        {

            /*int myTemp = 65;

            if (myTemp > (int)Temperatures.FREEZING && myTemp < (int)Temperatures.BOILING)
            {
                Console.WriteLine("At this temperature the water is liquid.");
            }
            else
            {
                Console.WriteLine("The water is not liquid");
            }
            Console.ReadLine();
            */

            const int freezingPointDefF = 32;
            const int boilingPointDefF = 212;

            int myTemp = 65;

            if (myTemp > freezingPointDefF && myTemp < boilingPointDefF)
            {
                Console.WriteLine("At this temperature the water is liquid.");
            }
            else
            {
                Console.WriteLine("The water is not liquid");
            }




        }
    }
}
