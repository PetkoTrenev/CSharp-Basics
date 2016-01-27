using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a greeting message. After all, why not?
            Console.WriteLine("Welcome to Cylinder Calculator 1.0!\n");

            // declare all the variables:
            double height;
            double radius;
            double pi;
            double volumeCylinder;
            double surfaceAreaCylinder;

            // Gets input from the user :

            Console.Write("Enter the height of the cylinder : ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Enter the radius of the base : ");
            radius = double.Parse(Console.ReadLine());

            // The volume of the cylinder
            pi = 3.14f;
            volumeCylinder = pi * radius * radius * height;

            // The surface area of the cylinder

            surfaceAreaCylinder = 2 * pi * radius * (radius + height);

            // This is the output :
            Console.WriteLine("The volume of the cylinder is : {0}  cubic units",volumeCylinder);
            Console.WriteLine("The surface area of the cylinder si : " + surfaceAreaCylinder + " square units");
            Console.ReadLine();    
        }
    }
}
