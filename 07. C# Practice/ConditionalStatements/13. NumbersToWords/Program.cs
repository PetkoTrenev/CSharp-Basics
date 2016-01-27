using System;

static class NumberString
{
    static string[] _words =
    {
    "zero",
    "one",
    "two",
    "three",
    "four",
    "five",
    "six",
    "seven",
    "eight",
    "nine",
    "ten"
    };

    public static string GetString(int value)
    {
        // See if the number can easily be represented by an English word.
        // ... Otherwise, return the ToString result.
        if (value >= 0 &&
        value <= 10)
        {
            return _words[value];
        }
        return value.ToString();
    }
}

class Program
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine(NumberString.GetString(value));
        // Call the GetString method to get number words.
        ////Console.WriteLine(NumberString.GetString(0));
        //Console.WriteLine(NumberString.GetString(5));
        //Console.WriteLine(NumberString.GetString(10));
        //Console.WriteLine(NumberString.GetString(100));
    }
}