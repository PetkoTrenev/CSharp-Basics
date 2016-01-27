using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // This declares a variable of type int and sets it to 54
            int numberThatCausesProblems = 54;

            // This sets a loop in which there is a variable being changed by 1
            #region        For Loop
            /*for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i); // Prints out to the console the variable i

                // This thing makes the program to stop when the 54 is reached to break out of the loop
                if (i == numberThatCausesProblems)
                    break;
            }
            */
            #endregion
            for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                continue;
                Console.WriteLine(i);
            }
        }
    }
}
