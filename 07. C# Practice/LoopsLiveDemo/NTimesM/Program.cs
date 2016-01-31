using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTimesM
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            int[] numbers = new int[] { 1, 2, 3, 4};

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 10;    // New value for the variable
                Console.WriteLine(numbers[i]);
            }
            
                //For Cycle
            string softUni = "SoftUni is awesome";
            //for (int i = 0; i < softUni.Length; i++)
            //{
                
            //    Console.WriteLine(softUni[i]);
            //}
            Console.WriteLine("-----");

            foreach (int number in numbers)
            {
                //letter == softUni[i];
                Console.WriteLine(number);
            }
           

        }
        
    }
}
