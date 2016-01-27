using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBook.Examples.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the different pieces we need.
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /, or ^):");
            string operation = Console.ReadLine();

            // This will store the result eventually.
            int result;

            // Do something different depending on the operator that the user
            // typed.
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "^":
                    result = (int)Math.Pow(number1, number2);
                    break;
                default: // This is a catch-all, if the operator is unknown.
                    Console.WriteLine("Unrecognized operator: " + operation);
                    result = 0;
                    break;
            }

            Console.WriteLine(number1 + " " + operation + " " + number2 +
                        " = " + result);

            Console.ReadKey();
        }
    }
}