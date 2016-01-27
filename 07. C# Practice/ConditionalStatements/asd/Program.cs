using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool check = int.TryParse(Console.ReadLine(), out a);
            if ((check == true) && (a >= 1 && a <= 7))
            {
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
    }
}
