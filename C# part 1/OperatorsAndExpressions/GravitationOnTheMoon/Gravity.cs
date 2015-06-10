/*
Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/


using System;

class Gravity
{
    static void Main()
    {
        Console.WriteLine("Enter your weight on Earth: ");          // You might need to use coma instead of dot when entering your weight.
        double weightOnEarth = double.Parse(Console.ReadLine());    // To change that you can go to: Control Panel->Clock, Language 
        double weightOnMoon = ((double)0.17 * weightOnEarth);       // Region->Region->Formats->Additional settings->Decimal symbol

        Console.WriteLine("Your weight on the Moon would be: {0}", weightOnMoon);

        Console.ReadLine();
    }
}

