using System;

class PointInCirOutsideRect
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;
        bool isInCircle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= Math.Pow(radius, 2);
        bool isInRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);
        
        
        if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        
    }
}
