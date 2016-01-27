using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            string firstName = "Petko";
            string lastName = "Trenev";
            Console.WriteLine("Hello {0}",firstName);

            string fullName = firstName + " " + lastName;
            Console.WriteLine("My full name is {0}.I am {1} years old ", fullName, age);
       

            
        }
    }
}
