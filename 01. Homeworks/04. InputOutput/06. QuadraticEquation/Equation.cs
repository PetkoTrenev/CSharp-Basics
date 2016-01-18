using System;

class Equation
{
    static void Main(string[] args)
    {
        Console.Write("a : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b : ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c : ");
        double c = double.Parse(Console.ReadLine());
        double x1;
        double x2;

        double discriminant = Math.Pow(b, 2) - (4 * a * c);

        if (discriminant > 0)
        {
            x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
   
            Console.WriteLine("x1 = {0}; x2 = {1}",x1,x2);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("No real roots");
        }
        else if (discriminant == 0)
        {
            x1=(-b + Math.Sqrt(discriminant)) / 2 * a;
            x2=(-b + Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("There is only one solution",x1 == x2);
        }
        Console.ReadLine();
            
    }
}

