using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**********
//**********
//**********
//**********
//**********
namespace _03.FunkyFor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Complicated for
            /*for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // This makes it wrap around to the beginning again.
            } */
            #endregion 
            for (int row = 0; row < 10; row++)
            {                
                for (int column = 0; column < row+1; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
