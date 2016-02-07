using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.TorrentPirate
{
    class Program
    {
        static void Main(string[] args)
        {
            int downloadData = int.Parse(Console.ReadLine());
            int priceOfCinema = int.Parse(Console.ReadLine());
            int bitchMoney = int.Parse(Console.ReadLine());

            double downloadTime =  (double)downloadData / 2 / 60 / 60;
            //downloadTime = Math.Round(downloadTime,4);
            double priceForDownload = downloadTime * bitchMoney;
            //priceForDownload = Math.Round(priceForDownload, 2);
            double numberOfDownloadedMovies = (double)downloadData / 1500;
            double cinemaPrice = numberOfDownloadedMovies * priceOfCinema;


            if (cinemaPrice >= priceForDownload)
            {
                Console.WriteLine("mall -> {0:0.00}lv", priceForDownload);
            }
            else
            {
                Console.WriteLine("cinema -> {0:0.00}lv", cinemaPrice);
            }
            //if (priceForDownload > cinemaPrice)
            //{
            //    Console.WriteLine("cinema -> {0:0.00}lv", cinemaPrice);
            //}
            //else
            //{
            //    Console.WriteLine("mall -> {0:0.00}lv", priceForDownload);
            //}

        }
    }
}
