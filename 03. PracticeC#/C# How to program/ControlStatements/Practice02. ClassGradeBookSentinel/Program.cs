using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02.ClassGradeBookSentinel
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int gradeCounter;
            int grade;
            double average;

            total = 0;
            gradeCounter = 0;

            Console.WriteLine("Enter a grade or -1 to quit: ");
            grade = int.Parse(Console.ReadLine());

            while(grade != -1)
            {
                Console.Write("Enter grade or -1 to quit: ");
                grade = Convert.ToInt32(Console.ReadLine());
                total = total + grade;
                gradeCounter++;
            }
            // The termination phase
            if (gradeCounter != 0)
            {
                average = total / gradeCounter;
                // display the total and average (with two digits of precision) 
                Console.WriteLine("\nTotal of the {0} grades entered is {1}",gradeCounter, total);
            }
            else
            {
                Console.WriteLine("No grades were entered");
                    
            }

        }
    }
}
