using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// NameSpace
namespace SuperCoolApplication
{
    // Class 
    class Program
    {
        // Function
        static void Main(string[] args)    
        {
            PrintFooToScreen100Times();
            Console.WriteLine("Hello type a number,any number");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            
            
            if (keyInfo.KeyChar == 'a')
            {
                Console.WriteLine("\nThat is not a number");
            }
            else
            {
                Console.WriteLine("\nDid u type : {0}", keyInfo.KeyChar.ToString());
            }
            
        }
        
        //ALl this function does is print foo to the screen
        static void PrintFooToScreen()
        {
            Console.WriteLine("Foo");
        }
        /// <summary>
        /// This function uses the previous function * 100 times
        /// </summary>
        static void PrintFooToScreen100Times()
        {
            for (int counter = 0;counter <= 100; counter++)
            {
                PrintFooToScreen();
            }
        }
    }
}
