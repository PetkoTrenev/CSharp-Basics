using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem02.DetectiveBoev
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string encryptedMessage = Console.ReadLine();
            int sumOfDigits = 0;

            byte[] secretBytes = Encoding.ASCII.GetBytes(secretWord);
            for (int i = 0; i < secretBytes.Length; i++)
            {
                sumOfDigits += secretBytes[i];
                //Console.Write(secretBytes[i] + " ");
            }
            //Console.WriteLine("\n" +   sumOfDigits);

            int sumOfDigitsFirst = sumOfDigits % 10;
            int sumOfDigitsSecond = (sumOfDigits /10) % 10;
            int sumOfDigitsThird = (sumOfDigits / 100) % 10;
            int sumOfDigitsFourth = (sumOfDigits / 1000) % 10;
            int sumOfDigitsFifth = (sumOfDigits / 10000) % 10;

            int mask = sumOfDigitsFirst + sumOfDigitsSecond + sumOfDigitsThird + sumOfDigitsFourth + sumOfDigitsFifth;
            //Console.WriteLine("mask is "+mask);
            
            byte[] encryptedBytes = Encoding.ASCII.GetBytes(encryptedMessage);

            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                
                if (encryptedBytes[i] % mask == 0)
                {
                    encryptedBytes[i] += (byte)mask;
                }
                else
                {
                    encryptedBytes[i] -= (byte)mask;
                }
                //Console.Write(encryptedBytes[i] + " ");

            }
            byte[] reversedArrayBytes = new byte[encryptedBytes.Length];
            Array.Reverse(encryptedBytes,0,encryptedBytes.Length);
            string myString = Encoding.ASCII.GetString(encryptedBytes);
            Console.WriteLine(myString);
            ////byte[] reversedArray = new byte[];
            ////Array.Reverse(reversedArrayBytes);
            //foreach (var token in reversedArrayBytes)
            //{
            //    Console.Write(token);
            ////}
            //for (int i = encryptedBytes.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(encryptedBytes[i] + " ");
            //}
        }
    }
   
}
