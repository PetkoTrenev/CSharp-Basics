using System;

class ModifyBits
{
    static void Main()
    {
        Console.WriteLine("Enter the integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Value of bit [0 or 1]: ");
        int value = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine(result);
        }
        else if (value == 1)
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid value number");
        }

    }
}

