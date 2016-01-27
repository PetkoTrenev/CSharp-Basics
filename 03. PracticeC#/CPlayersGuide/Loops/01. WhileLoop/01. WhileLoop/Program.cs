using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int playersNumber;

            do
            {
                Console.WriteLine("Enter a number between 0 and 10 :");
                string playersResponse = Console.ReadLine();
                playersNumber = Convert.ToInt32(playersResponse);
            }
            while (playersNumber < 0 || playersNumber > 10);
        }
    }
}
