using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int product = 1;
            for (int i = 1,sum = 0, product = 1; i <= 10; i++)
            {
                sum += i;
                product *= i;
                Console.WriteLine("On the {0} line the results are : ",i);
                Console.WriteLine("The sum is : {0}  The product is : {1}\n", sum, product);
            }
            //Console.WriteLine("The sum is : {0}  The product is : {1}",sum,product);
        }
    }
}
