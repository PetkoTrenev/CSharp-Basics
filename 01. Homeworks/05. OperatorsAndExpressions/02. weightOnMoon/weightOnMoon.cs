using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your weight on Earth");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        

        Console.WriteLine(weightOnMoon);
    }
}
