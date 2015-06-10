/*
Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/

using System;

class Program
{
    static void Main()
    {

       
        string firstName = "Stamat";
        string lastName = "Trabadarov";
        byte age = 35;
        string gender = "Male";
        long personalIDNumber = 8009123475;
        long uniqueEmployeeNumber = 265612461234;

        Console.WriteLine(new string('-', 40) + "\nFirst Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName + "\n");
        Console.WriteLine(new string('-', 40) + "\nAge: " + age);
        Console.WriteLine("Gender: " + gender + "\n");
        Console.WriteLine(new string('-', 40) + "\nPersonal ID number: " + personalIDNumber);
        Console.WriteLine("Unique Employee Number: " + uniqueEmployeeNumber + "\n");



        Console.ReadLine();
    }
}