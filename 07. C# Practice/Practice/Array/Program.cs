using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare an array of type string and its filled with variables
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            // Access the second element of the array
            days[1] = "Sunday";
            // pRints the changed item
            Console.WriteLine(days[2]);
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

            //Empty array
            int[] myArray = new int[6];
            //The third element is set to be 15
            myArray[2] = 15;

            Console.WriteLine(myArray[2]);
            
        }
    }
}
