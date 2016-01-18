using System;

class PointInCircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int radius = 2;
        bool isInCircle = Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2);
        Console.WriteLine(isInCircle);


    }
}

