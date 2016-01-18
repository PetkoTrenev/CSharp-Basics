using System;

class DivisionFiveSeven
{
    static void Main()
    {
        
            Console.WriteLine("Enter a number :");
            int N = int.Parse(Console.ReadLine());
            bool isDivisible = (N % 5 == 0) && (N % 7 == 0) && N != 0;
            Console.WriteLine(isDivisible);    
                  
    }
}

