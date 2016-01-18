using System;

//Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables(mind adding an interval between). Declare a third string variable and initialize it with the value of the object variab le(you should perform type casting).

class StringsAndObjects
{
    static void Main()
    {
        String a = "Hello";
        String b = "World";
        Object d = a + "  " + b;
        String c = (string) d;
    }
}

