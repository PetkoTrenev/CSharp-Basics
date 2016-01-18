using System;

class AgeNowAndLater
{
    static void Main()
    {
        DateTime CurrentDate = DateTime.Now;
        Console.Write("Enter your birthday:");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        System.TimeSpan ageNow = CurrentDate - birthday;
        double yourAge;
        yourAge = ageNow.TotalDays / 365.25;
        Console.WriteLine("Your age now is:" + yourAge);
        Console.WriteLine("Your age after 10 years time will be :" + (yourAge + 10)); 
    }
}

