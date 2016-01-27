using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            //Get array size
            int length = array.Length;
            //Declare and create reversed array
            int[] reversed = new int[length];

            //Initialize the reversed array 
            for (int i = 0; i < length; i++)
            {
                int lenght = array.Length;
                reversed[lenght - i - 1] = array[i];
            }
            //Print the reversed array
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(reversed[i] + " ");
            }
        }
    }
}
