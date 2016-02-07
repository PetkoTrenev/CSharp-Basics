﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringsFunctionalities
{
    class Program
    {
        static void Main(string[] args)
        {

            string sampleString = "A bunch of random words";

            Console.WriteLine("Is empty or null = " + String.IsNullOrEmpty(sampleString));
            Console.WriteLine("Is empty = " + String.IsNullOrWhiteSpace(sampleString));
            Console.WriteLine("String length " + sampleString.Length);
        }
    }
}
