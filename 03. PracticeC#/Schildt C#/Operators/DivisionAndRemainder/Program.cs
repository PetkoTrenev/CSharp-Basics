using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int iremainder,iresult;
            double dresult, dremainder;

            iresult = 10 / 3;
            iremainder = 10 % 3;

            dresult = 10 / 3.0;
            dremainder = 10 % 3.0;

            Console.WriteLine("Integer division {0} , Intger remainder {1}",iresult,iremainder);
            Console.WriteLine();
            Console.WriteLine("Result of double division {0}  and  remainder {1}",dresult,dremainder);
            Console.WriteLine();

            
        }
    }
}
