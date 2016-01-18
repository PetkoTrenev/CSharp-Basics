using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DailyCalorieIntake
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightInPounts = double.Parse(Console.ReadLine());
            double heightInInches = double.Parse(Console.ReadLine());
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long workoutsPerWeek = long.Parse(Console.ReadLine());

            decimal BMR = 0;
            decimal weightInKilograms = (decimal)(weightInPounts / 2.2);
            decimal heightInCentimeters = (decimal)(heightInInches * 2.54);
            decimal DCI = 0;

            if (gender == 'm')
            {
                //BMR = 66.5 + (13.75 x weight in kg) +(5.003 x height in cm) – (6.755 x age in years)
                BMR = 66.5M + (13.75M * weightInKilograms) + (5.003M * heightInCentimeters) - (6.755M *(decimal)age);
                
            }
            else if (gender == 'f')
            {
                //Women: BMR = 655 + (9.563 x weight in kg) +(1.850 x height in cm) – (4.676 x age in years)
                BMR = 655M + (9.563M * weightInKilograms) + (1.850M * heightInCentimeters) - (4.676M *(decimal)age);
                
            }
            switch (workoutsPerWeek)
            {
                
                case 1:
                case 2:
                case 3:
                    DCI = BMR * 1.375M;
                    break;
                case 4:
                case 5:
                case 6:
                    DCI = BMR * 1.55M;
                    break;
                case 7:
                case 8:
                case 9:
                    DCI = BMR * 1.725M;
                    break; 
                default:
                    DCI = BMR * 1.9M;
                    break;
            }   
            if (workoutsPerWeek < 1)
            {
                
                    DCI = BMR * 1.2M;
            }

            Console.WriteLine(Math.Floor(DCI));

        }
    }
}
