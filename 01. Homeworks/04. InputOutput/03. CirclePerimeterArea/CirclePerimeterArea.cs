using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.WriteLine("Enter a number for the radius of the circle: ");
        double r = double.Parse(Console.ReadLine());

        double circlePerimeter = 2 * Math.PI * r;
        double circleArea = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("{0:0.00}",circlePerimeter);
        Console.WriteLine("{0:0.00}",circleArea);
    }
}

