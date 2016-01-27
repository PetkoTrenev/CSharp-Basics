using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if(age >= 5 && age <=7)
            {
                Console.WriteLine("Go to elementary school");
            }
            else if (age > 7 && age <= 13)
            {
                Console.WriteLine("Go to middle school");
            }
            else if (age > 15 && age < 25)
            {
                Console.WriteLine("Go to high school");
            }

            else 
            {
                Console.WriteLine("You shouldn't work");
            }

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");
                    break;
                default:
                    Console.WriteLine("Child");
                    break;
            }
       

        }
    }
}
