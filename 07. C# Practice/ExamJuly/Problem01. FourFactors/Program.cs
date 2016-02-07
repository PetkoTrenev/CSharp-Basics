using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.FourFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            uint FG = uint.Parse(Console.ReadLine());
            uint FGA = uint.Parse(Console.ReadLine());
            uint threePoints = uint.Parse(Console.ReadLine());
            uint TOV = uint.Parse(Console.ReadLine());
            uint ORB = uint.Parse(Console.ReadLine());
            uint ODRB = uint.Parse(Console.ReadLine());
            uint FT = uint.Parse(Console.ReadLine());
            uint FTA = uint.Parse(Console.ReadLine());

            double eFGpercentage = ((FG+0.5*threePoints)/ FGA) ;
            double TOVpercentage = (TOV) / (FGA + 0.44 * FTA + TOV);
            double ORBpercentage = (ORB / (double)(ORB + ODRB));
            double FTpercentage = (FT / (double)FGA);

            Console.WriteLine("eFG% {0:f3}",eFGpercentage);
            Console.WriteLine("TOV% {0:f3}",TOVpercentage);
            Console.WriteLine("ORB% {0:f3}",ORBpercentage);
            Console.WriteLine("FT% {0:f3}",FTpercentage);
        }
    }
}
