using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var guess = 0;

            do
            {
                Console.WriteLine("Enter a number");
                guess = int.Parse(Console.ReadLine());
            }            
            while (guess != 15);
            Console.WriteLine("You guessed it. Congratz");

            //string guess;
            //do
            //{
            //    Console.Write("Guess the number : ");
            //    guess = Console.ReadLine();
            //} while (!guess.Equals("15"));
            //Console.WriteLine("You guessed the number. Congratz.");

        }
    }
}
