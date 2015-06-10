using System;

class MyAge
{
    static void Main()
    {
        Console.Write("Enter your birth date(i.e. 28.04.1994): ");
        DateTime BirthDay = DateTime.Parse(Console.ReadLine());
        int age = (int)((DateTime.Now - BirthDay).TotalDays / 365.242199);
        Console.WriteLine("You are " + age + " year(s) old!");
        Console.WriteLine("After ten years you will be at the age of " + (age + 10) + ".");

        Console.ReadLine();

    }
}

