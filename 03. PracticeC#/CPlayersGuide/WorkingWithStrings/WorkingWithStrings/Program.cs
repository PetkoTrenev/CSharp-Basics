using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleString = "A String";

            Console.WriteLine("Is Empty : " + String.IsNullOrEmpty(sampleString));
            Console.WriteLine("Is Empty : " + String.IsNullOrWhiteSpace(sampleString));
            Console.WriteLine("String lenght " + sampleString.Length);
            Console.WriteLine("String type {0}",sampleString.GetTypeCode());

            Console.WriteLine("Finding word " + sampleString.IndexOf("String"));
            Console.WriteLine("Pulling the found word : "+ sampleString.Substring(2,6));

            string[] names = new string[] { "Matt", "Joe", "Filo", "Venci" };
            Console.WriteLine("Name list : " + String.Join(",",names));
        }
    }
}
