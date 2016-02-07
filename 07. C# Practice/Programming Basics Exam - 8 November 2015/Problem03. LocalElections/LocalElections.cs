using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.LocalElections
{
    class LocalElections
    {
        static void Main(string[] args)
        {
            int candidates = int.Parse(Console.ReadLine());
            int chosenOne = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            // Top part
            Console.WriteLine(new string('.', 13));

            // The logic for the cube
            for (int i = 1; i <= candidates; i++)
            {
                Console.WriteLine("...+{0}+...", new string('-', 5));

                if (i == chosenOne)
                {
                    if (symbol.ToLower() == "x")
                    {
                        Console.WriteLine(@"...|.\./.|...");
                        Console.WriteLine("{1}.|..{0}..|...",
                            symbol.ToUpper(),i.ToString().PadLeft(2,'0'));
                        Console.WriteLine(@"...|./.\.|...");
                    }
                    else
                    {
                        Console.WriteLine(@"...|\.../|...");
                        Console.WriteLine(@"{0}.|.\./.|...",i.ToString().PadLeft(2,'0'));
                        Console.WriteLine(@"...|..{0}..|...",symbol.ToUpper(),i.ToString());

                    }
                }
                else
                {
                    Console.WriteLine(@"...|.....|...");
                    Console.WriteLine(@"{0}.|.....|...",i.ToString().PadLeft(2,'0'));
                    Console.WriteLine(@"...|.....|...");
                }
                Console.WriteLine("...+{0}+...", new string('-', 5));
                Console.WriteLine(new string('.', 13));
            }
        }
    }
}
