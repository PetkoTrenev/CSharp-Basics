using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfweek
{
    class Program
    {
        static void Main()
        {
            string value = Console.ReadLine();
            int myValue = int.Parse(Console.ReadLine());


            // ... Switch on the string.
            switch (myValue)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                //case "squash":
                //Console.WriteLine("SQUASH");
                //break;
                //case "turnip":
                //    Console.WriteLine("TURNIP");
                //    break;
                default:
                    Console.WriteLine("WI");
                    break;
            }
        }

    }
}


