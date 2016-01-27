using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TheBetterMusicProduce
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables
            int numberOfAlbumsEU = int.Parse(Console.ReadLine());
            decimal priceEuro = decimal.Parse(Console.ReadLine());
            int numberOfAlbumsNA = int.Parse(Console.ReadLine());
            decimal priceDollars = decimal.Parse(Console.ReadLine());
            int numberOfAlbumsSA = int.Parse(Console.ReadLine());
            decimal pricePesos = decimal.Parse(Console.ReadLine());
            int numberOfConcert = int.Parse(Console.ReadLine());
            decimal profitEuro = decimal.Parse(Console.ReadLine());

            // Converting each price into levas
            decimal profitFromAlbumEU = numberOfAlbumsEU * priceEuro * (decimal)1.94;
            decimal profitFormAlbumNA = numberOfAlbumsNA * priceDollars * (decimal)1.72;
            decimal profitFromAlbumSA = numberOfAlbumsSA * pricePesos / (decimal)332.74;

            decimal totalProfitFromAlbums = profitFormAlbumNA + profitFromAlbumEU + profitFromAlbumSA;

            totalProfitFromAlbums -= totalProfitFromAlbums * 35/100M;
            
            totalProfitFromAlbums -= totalProfitFromAlbums * 20/100M;
            

            decimal profitFromConcert = numberOfConcert * profitEuro * 1.94M;

            if (profitFromConcert > 100000)
            {
                profitFromConcert -= profitFromConcert * 15 / 100;
            }
         
            if (totalProfitFromAlbums > profitFromConcert)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.",totalProfitFromAlbums);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.",profitFromConcert );
            }
        }
    }
}
