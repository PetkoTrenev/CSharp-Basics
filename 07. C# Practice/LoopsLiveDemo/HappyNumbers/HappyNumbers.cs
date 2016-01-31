using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumbers
{
    class HappyNumbers
    {
        static void Main(string[] args)
        {
            for (int thousands = 1; thousands <= 9; thousands++)
            {
                for (int hundreds = 0; hundreds <= 9; hundreds++)
                {
                    for (int tens = 0; tens <= 9; tens++)
                    {
                        for (int numbers = 0; numbers <= 9; numbers++)
                        {
                            // Checking if the numbers we found are "happy"
                            if ((thousands + hundreds) == (tens + numbers))
                            {
                                Console.WriteLine(" " + thousands + " " + hundreds +
                                   " " + tens + " " + numbers);
                            }
                        }
                    }
                }
            }
        }
    }
}
