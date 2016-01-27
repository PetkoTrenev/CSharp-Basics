using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            ulong numberOfCakesWanted = ulong.Parse(Console.ReadLine());
            double kgFlourForCake = double.Parse(Console.ReadLine());
            ulong kgAvailableFlour = ulong.Parse(Console.ReadLine());
            ulong amountOfTrufflesAvailable = ulong.Parse(Console.ReadLine());
            ulong priceOfTruffle = ulong.Parse(Console.ReadLine());

            // Calculations
            double amountOfCakes = Math.Floor(kgAvailableFlour / kgFlourForCake);
            ulong TruffleCost = (ulong)amountOfTrufflesAvailable * (ulong)priceOfTruffle;
            

            if (amountOfCakes < numberOfCakesWanted)
            {
                
                double totalFlour = numberOfCakesWanted * kgFlourForCake;
                double kgNeeded = totalFlour - kgAvailableFlour;
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour",Math.Floor(amountOfCakes),kgNeeded);
                 
            }
            else if (amountOfCakes >= numberOfCakesWanted)
            {
                double cakePriceWithoutAddion = TruffleCost / numberOfCakesWanted;
                double cakePriceWithAdditon = cakePriceWithoutAddion * 1.25;
                Console.WriteLine("All products available, price of a cake: {0:f2}", cakePriceWithAdditon);

            }

        }
    }
}
