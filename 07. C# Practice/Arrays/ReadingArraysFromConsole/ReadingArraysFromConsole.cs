using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingArraysFromConsole
{
    class ReadingArraysFromConsole
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int index = 0; index < n; index++)
            {
                myArray[index] = int.Parse(Console.ReadLine()); 

            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
