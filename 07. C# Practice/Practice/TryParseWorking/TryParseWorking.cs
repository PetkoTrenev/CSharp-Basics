using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseWorking
{
    class TryParseWorking
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int myValue;
            bool parseSuccess = int.TryParse(str, out myValue);
            Console.WriteLine(parseSuccess ? "The square of the input number is : "+Math.Pow(myValue,2) : "Wrong Input couldn't parse it");
        }
    }
}
