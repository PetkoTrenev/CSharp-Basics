using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseArray
{
    class reverseArray
    {
        static void Main(string[] args)
        {
            int[] forward = { 1, 2, 3, 4, 5 };

            //get array size
            int length = forward.Length;

            //Declare and make the new array with the reversed values same size
            int[] reversed = new int[length];

            // Initialize the whole reversed array with values
            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = forward[index];
                
            }

            //Printing the reversed array
            for (int index = 0; index < length; index++)
            {
                Console.Write(reversed[index] + " ");
            }
            Console.WriteLine();
        }
    }
}
