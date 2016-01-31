using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentinelLoop
{
    class SentinelLoop
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (true) // Executes until End is written
            {
                if (command == "end")
                {
                    break;
                }
                Console.WriteLine("{0}**",command);
                command = Console.ReadLine();
            }
        }
    }
}
