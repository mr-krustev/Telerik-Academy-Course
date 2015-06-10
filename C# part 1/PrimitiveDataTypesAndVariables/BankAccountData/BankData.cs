/*
Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/


using System;

class BankData
{
    static void Main()
    {
        string firstName = "Charlie ";
        string middleName = "Fcking ";
        string lastName = "Chaplin";
        object fullName = firstName + middleName + lastName;

        decimal balance = 250.25m;
        string bankName = "Banka DSK";
        string IBAN = "BG80 BNBG 9661 1020 3456 78 ";

        long creditCard = 56859684038506;
        long anotherCreditCard = 13880385839596;
        long theLastCreditCard = 29385830538593;

        Console.WriteLine(new string('-', 40) + "\n" + "Hello, Mr." + fullName);
        Console.WriteLine(new string('-', 40) + "\n" + "Your balance is: " + balance + "lv");
        Console.WriteLine("Your bank: " + bankName);
        Console.WriteLine("IBAN: " + IBAN);
        Console.WriteLine(new string('-', 40) + "\n" + "Your first credit card number: " + creditCard);
        Console.WriteLine("Your second credit card number: " + anotherCreditCard);
        Console.WriteLine("Your third credit card number: " + theLastCreditCard);
        Console.WriteLine(new string('-', 40) + "\nThank you for choosing us!");

        Console.ReadLine();
    }
}

