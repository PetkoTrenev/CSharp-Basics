using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Loops
{
    class Loops
    {
        static void Main(string[] args)
        {  
            
            int myVal = 20;
            /*
            // basic while loop
            Console.WriteLine("Basic while() loop: ");
            while (myVal < 20)
            {
                Console.WriteLine("myVal is currently :{0}",myVal);
                // Careful! Always make sure that the loop has a way to exit
                // or you'll end up with an infinite loop
                myVal += 3;

            }
            Console.WriteLine();
            Console.ReadLine(); 
            */
            Console.WriteLine("The do while loop:");
            do
            {
                Console.WriteLine("myVal is currently {0} ", myVal);
                myVal += 3;
            } while (myVal < 20);
            Console.WriteLine();
            Console.ReadLine();
            

        }
    }
}
