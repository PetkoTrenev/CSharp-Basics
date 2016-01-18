using System;

public static void Main()
    {
        long start = long.Parse(Console.ReadLine());
        long end = long.Parse(Console.ReadLine());
        int p = 0;
        for (long i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine(p);
    }

