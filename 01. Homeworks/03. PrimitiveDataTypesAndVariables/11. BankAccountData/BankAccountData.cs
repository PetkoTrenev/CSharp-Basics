using System;

//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name, IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        Console.Write("Enter first name of the account: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter middle name of the account:");
        string middleName = Console.ReadLine();
        Console.Write("Enter last name of the account:");
        string lastName = Console.ReadLine();
        Console.Write("Enter avaivable amount of money:");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("Enter bank name: ");
        string bankName = Console.ReadLine();
        Console.Write("Enter IBAN: ");
        string IBAN = Console.ReadLine();
        Console.Write("First credit card number:");
        string firstCreditCard = Console.ReadLine();
        Console.Write("Second credit card number:");
        string secondCreditCard = Console.ReadLine();
        Console.Write("Third credit card number:");
        string thirdCreditCard = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("First name:{0}", firstName);
        Console.WriteLine("Middle name:{0}", middleName);
        Console.WriteLine("Last name:{0}", lastName);
        Console.WriteLine("Balance:{0}", balance);
        Console.WriteLine("Bank name:{0}", bankName);
        Console.WriteLine("IBAN: {0}", IBAN);
        Console.WriteLine("First credit card:{0}", firstCreditCard);
        Console.WriteLine("Second credit card:{0}", secondCreditCard);
        Console.WriteLine("Third credit card:{0}", thirdCreditCard);
    }
}
