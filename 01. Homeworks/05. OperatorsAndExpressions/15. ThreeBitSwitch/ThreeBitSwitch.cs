using System;

    class ThreeBitSwitch
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            long a = 7;
            long mask = (a << p)
                 //TODO: Make the mask needed to invert 3 bits at position p
                 ;
            long result = mask ^ n;
            //TODO: Use the ^ (XOR) operation with the number and the mask to get the result
            ;
            Console.WriteLine(result);
            string binary = Convert.ToString(result, 2);
            Console.WriteLine(binary);
        }
    }

