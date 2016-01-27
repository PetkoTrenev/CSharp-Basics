using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAndCreatingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "OldModel";
            myNewCar.Model = "Ferrari";
            myNewCar.Year = 2015;
            myNewCar.Color = "MetalCarbon";


            Console.WriteLine("Model of the car: {0}\n Year of production: {1}\n  Color : {2}\n",myNewCar.Model,myNewCar.Year,myNewCar.Color);

            Console.WriteLine("Car's value is : {0:C}", myNewCar.DetermineMarketValue());

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue;

            if (this.Year < 2000)
                carValue = 2000;
            else
                carValue = 2000000;

            return carValue;
        }
    }
    


}
