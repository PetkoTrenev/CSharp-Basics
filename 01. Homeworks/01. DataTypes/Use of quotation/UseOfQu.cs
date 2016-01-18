using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.

namespace Use_of_quotation
{
    class UseOfQu
    {
        static void Main(string[] args)
        {
            string var1 =@"The ""use"" of quotations causes difficulties.";
            string var2 = "The \"use\" of quotations causes difficulties";

            Console.WriteLine(var1);
            Console.WriteLine(var2);
        }

    }
}
