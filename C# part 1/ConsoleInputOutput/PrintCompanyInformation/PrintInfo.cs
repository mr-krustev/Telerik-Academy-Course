/*
Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;

class PrintInfo
{
    static void Main()
    {
        Console.Write("Please enter your company's name: ");
        string companyName = Console.ReadLine();

        Console.Write("Please enter your company's adress: ");
        string companyAdress = Console.ReadLine();

        Console.Write("Please enter your company's phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Please enter your company's fax number");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Please enter your company's website: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Please enter manager's first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Please enter manager's second name: ");
        string managerLastName = Console.ReadLine();
        string companyManager = managerFirstName + managerLastName;

        Console.Write("Please enter manager's age: ");
        int managerAge = 0;
        bool isManagerAge = int.TryParse(Console.ReadLine(), out managerAge);

        Console.Write("Please enter manager's phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        

        if (isManagerAge)
        {
            Console.Clear();
            Console.WriteLine(new string('-', 40) + "\nCompany name: {0} \nCompany Adress: {1} \nCompany Phone Number: {2}", companyName, companyAdress, companyPhoneNumber);
            Console.WriteLine("Company Fax Number: {0} \nCompany Website: {1}", companyFaxNumber, companyWebSite);
            Console.WriteLine(new string ('-', 40) + "\nManager's name: {0} \nManager Age: {1} \nManager Phone Number: {2}", companyManager, managerAge, managerPhoneNumber);
        }
        else
        {
            Console.WriteLine("You have provided invalid input for manager's age!");
        }

    }
}

