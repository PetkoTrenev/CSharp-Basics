using System;

class Play_with_Int_Double_String
{
    static void Main()
    {
        Console.WriteLine("Please choose a type :\n 1 --> int\n 2 --> double\n 3 --> string ");

        ConsoleKeyInfo keyReaded = Console.ReadKey();
        
        switch (keyReaded.Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("\tYou pressed 1");
                Console.Write("Please enter an integer:");
                int myInt = int.Parse(Console.ReadLine());
                myInt += 1;
                Console.WriteLine(myInt);
                break;
            case ConsoleKey.D2:
                Console.WriteLine("\tYou pressed 2");
                Console.WriteLine("Please enter a double:");
                double myDouble = double.Parse(Console.ReadLine());
                myDouble +=1d;
                Console.WriteLine(myDouble);
                break;
            case ConsoleKey.D3:
                Console.WriteLine("\tYou pressed 3");
                Console.WriteLine("Please enter a string:");
                string myString = Console.ReadLine();
                Console.WriteLine(myString + "*");
                break;
            default:
                Console.WriteLine("Wrong input");
                break;
        }

    }
}

