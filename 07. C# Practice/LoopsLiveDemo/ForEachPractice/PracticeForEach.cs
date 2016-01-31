using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachPractice
{
    class PracticeForEach
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 19 };     // Initializing the array with variables
            foreach (int i in numbers)   // That is the way to access each of the numbers in the array
            {
                Console.WriteLine(" " + i);
            }
            Console.WriteLine();

            string[] towns = { "Sofia", "Plovdiv", "Varna", "Burgas" };
            foreach (string town in towns)
            {
                Console.WriteLine(" " + town);
            }
        }
    }
}
