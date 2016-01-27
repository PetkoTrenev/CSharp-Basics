using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Decisions
    {   
        static void Main(string[] args)
        {
            //    Console.WriteLine("Please type something and press the Enter key : ");
            //    string userValue;
            //    userValue = Console.ReadLine();
            //    Console.WriteLine("You typed : " + userValue);
            int userValue = 2;
            string message = (userValue == 1) ? "boat" : "car";
            Console.WriteLine("{1} - {0}", userValue, message);
        }
    }
}
