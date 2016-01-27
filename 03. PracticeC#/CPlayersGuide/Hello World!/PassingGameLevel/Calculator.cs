using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator

{
    class Calculator

    {
        static void Main(string[] args)
        {
            // Declaring Variables
            double firstNumber;
            double secondNumber;
            
            string mathOperation;
            
            // Gather input from the user:
            Console.WriteLine("Welcome to my calculator 1.0\n");
            Console.Write("Enter first number : ");
            firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose ’+’ for addition,\n’-’ for subtraction,\n’*’ for multiplication,\n’/’ for division,\n’%’ for remainder,\n '^' for power");
            mathOperation = Console.ReadLine();

            double answer;
            switch (mathOperation)
            {
                case "+":
                    answer = firstNumber + secondNumber;
                   // Console.WriteLine("Result : " + answer);
                    break;
                case "-":
                    answer = firstNumber - secondNumber;
                   // Console.WriteLine("Result : " + answer);
                    break;
                case "*":
                    answer = firstNumber * secondNumber;
                   // Console.WriteLine("Result : " + answer);
                    break;
                case "/":
                    answer = firstNumber / secondNumber;
                    //Console.WriteLine("Result : " + answer);
                    break;
                case "%":
                    answer = firstNumber % secondNumber;
                    //Console.WriteLine("Result : " + answer);
                    break;
                case "^":
                    answer = (double)Math.Pow(firstNumber, 2);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            

            Console.ReadKey();
        }
   }
       

}