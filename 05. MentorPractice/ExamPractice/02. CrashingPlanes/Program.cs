using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRashingPlanes
{
    class Program
    {
        static void Main(string[] args)
        {
            int xheadquarters = int.Parse(Console.ReadLine());
            int yheadquarters = int.Parse(Console.ReadLine());
            int distanceFromHQ = int.Parse(Console.ReadLine());
            int numberOfPlanes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPlanes; i++)
            {
                int xCurrentPlane = int.Parse(Console.ReadLine());
                int yCurrentPlane = int.Parse(Console.ReadLine());
                //(x - center_x)^2 + (y - center_y)^2 < radius^2
                bool isInRange = Math.Pow(xCurrentPlane - xheadquarters, 2) +
                    Math.Pow(yCurrentPlane - yheadquarters, 2) < Math.Pow(distanceFromHQ,2);
                if (isInRange)
                    Console.WriteLine("You destroyed a plane at [{0},{1}]",xCurrentPlane,yCurrentPlane);

            }

        }
    }
}
