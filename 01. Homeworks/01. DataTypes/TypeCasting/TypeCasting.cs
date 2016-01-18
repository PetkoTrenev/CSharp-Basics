using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).
namespace TypeCasting
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            string var1 = "Hello";
            string var2 = "World";

            object obj = var1 + " " + var2;
            string var3 =  (string)obj;

            Console.WriteLine(var3);


        }
    }
}
