﻿using System;

class SwitchCase
{
    static void Main(string[] args)
    {
        int number = 6;
        switch (number)
        {
            case 1:
            case 4:
            case 6:
            case 8:
            case 10:
                Console.WriteLine("The number is not prime!"); break;
            case 2:
            case 3:
            case 5:
            case 7: Console.WriteLine("The number is prime!"); break;
            default: Console.WriteLine("Unknown number!"); break;
        }
    }
}

