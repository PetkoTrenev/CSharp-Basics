using System;

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (n >= 1 && n <= 100)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }                
            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine("false");
        }        
    }
}

