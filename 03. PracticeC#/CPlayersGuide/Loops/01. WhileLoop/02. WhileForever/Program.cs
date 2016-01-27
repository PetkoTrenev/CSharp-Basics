using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WhileForever
{
    class Program
    {
        static void Main(string[] args)
        {
            questionsAsked();
            
        }

        static void questionsAsked()
        {
            // This is a forever loop
            while (true)
            {
                // Prints to the console the question in brackets
                Console.WriteLine("What is your question :? ");
                string input = Console.ReadLine();   // Gathers input from the user

                if (input == "quit" || input == "exit")   // Checks whether the user has typed "quit" or "exit" to end
                    break;
            }
        }
    }
}
