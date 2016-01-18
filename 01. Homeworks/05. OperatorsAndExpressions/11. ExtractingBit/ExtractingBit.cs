using System;


class ExtractingBit
{
    static void Main()
    {
        Console.WriteLine("Enter the unsigned integer number:");
        uint number = uint.Parse(Console.ReadLine());
        int p = 3;
        uint shiftNumber = number >> p;
        uint bitThree = shiftNumber & 1;

        // Converts the number to be binary
        string binary = Convert.ToString(number, 2).PadLeft(16 ,'0'); 
          
        Console.WriteLine("{0}", binary);
        Console.WriteLine(bitThree);


    }
}

