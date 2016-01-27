using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    // Only one Petko !!!
    //abstract class Petko
    //{
    //    private static string name = "Petko";
    //    public  static string alias = "Trenev";
    //    private static int age = 24;
    //}

    class Program
    {
        
        static void Main()
        {
            // Preserve current console text color
            ConsoleColor oldColor = Console.ForegroundColor;
            
            // using my function
            TellPeopleWhatProgramThisIs();

            // Create random number object
            Random randomObject = new Random();


            // Loop Forever!!!!
            while (true)
            {
                string questionString = GetQuestionFromUser();

                int numerOfSecondsToSleep = randomObject.Next(5) + 1;
                Console.WriteLine("Thinking about your answer , stand by....");
                Thread.Sleep(numerOfSecondsToSleep * 1000);

                if (questionString.ToLower() == "you suck")
                {
                    Console.WriteLine("You suck even more !");
                    break;
                }
                if (questionString.Length == 0)
                {
                    Console.WriteLine("You need to type a question dude!");
                    continue;       // Continue means that you break out of the while loop but you start the code at the beginning
                }

                // See if the user typed quit
                if (questionString.ToLower() == "exit")
                {
                    break;
                }
                // Get a random number
                int randomNumber = randomObject.Next(4);

                // Use random number to determine response
                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("No");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Hell NO !");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("OMG YES !");
                            break;
                        }
                }
            }
            // Drop it right here if u hit quit
            //Cleaning up
            Console.ForegroundColor = oldColor;
        }

        // Here we can find the greeting 
        static void TellPeopleWhatProgramThisIs()
        { 
            // Change console text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("M");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("agic 8 ball (by Petko Trenev)");
        }

        /// This function will return the text the user types
        static string GetQuestionFromUser()
        {
            // This block of code will ask the user for question
            // and store the question text in questionString variable
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question ?: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string questionString = Console.ReadLine();

            return questionString;

        }

    }
}
