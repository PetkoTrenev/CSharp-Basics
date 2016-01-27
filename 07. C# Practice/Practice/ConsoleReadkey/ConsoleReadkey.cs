using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadkey
{
    class ConsoleReadkey
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("The special character was enter with : " + key.Modifiers);
            Console.WriteLine("The char you enter  is: " + key.KeyChar);
            Console.WriteLine("The chars Unicode representation :" + key.Key);
        }
    }
}
