﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethdos
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myValue =  superSecretFormula();
            string myValue = superSecretFormula("sunshine");
            Console.WriteLine(myValue);
            Console.ReadLine();

        }

        private static string superSecretFormula()
        {
            // some cool stuff here
            return ("Hello World !");
        }

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello,{0}", name);
        }
    }
}
