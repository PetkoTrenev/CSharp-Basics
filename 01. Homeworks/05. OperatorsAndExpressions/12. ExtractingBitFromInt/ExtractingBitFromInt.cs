using System;

//Write an expression that extracts from given integer n the value of given bit at index p. 

class ExtractingBitFromInt

{
    static void Main()
    {
        Console.WriteLine("Enter the integer number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit:");
        int p = int.Parse(Console.ReadLine());

        int shiftedNumber = number >> p;
        int bitAtThisPosition = shiftedNumber & 1;
        string binaryNumber = Convert.ToString(number, 2).PadLeft(16, '0');

        Console.WriteLine(binaryNumber);
        Console.WriteLine(bitAtThisPosition);
    }
}

