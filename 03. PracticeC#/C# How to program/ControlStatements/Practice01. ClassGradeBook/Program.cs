using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01.ClassGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;                  // sum of the grades entered by the user
            int gradeCounter;           // number of grades to be entered next
            int grade;                 // grade entered  by the user
            int average;               // The average of the grades

            // initialization phase
            total = 0;                
            gradeCounter = 1;

            while(gradeCounter <= 10)
            {
                Console.WriteLine("Enter a grade for the student : ");
                grade = int.Parse(Console.ReadLine());
                total += grade;
                gradeCounter++;
            }
            Console.WriteLine("The average grade is : {0}",total / 10);



        }
    }
}
