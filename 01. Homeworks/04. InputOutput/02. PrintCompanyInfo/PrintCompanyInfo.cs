using System;

//A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.Write a program that reads the information about a company and its manager and prints it back on the console.


class PrintCompanyInfo
{
    static void Main()
    {
        // Input
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        // Printing to the console the company information
        Console.Write("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\n",companyName,companyAddress,phoneNumber,faxNumber,webSite);
   
        // Printing to the console manager information
        Console.Write("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName,managerLastName,managerAge,managerPhone);
        Console.ReadLine();
        
       

    }
}

