/*
Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/


using System;

class getRekt
{
    static void Main()
    {
        Console.Write("Please write the width of your rectangle: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write(new string('-', 40) + "\nPlease write the height of your rectangle: ");
        double height = double.Parse(Console.ReadLine());
       
        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine(new string('-',40) + "\nThe perimeter of your rectangle is: {0}", perimeter);
        Console.WriteLine("\nThe area of your rectangle is: {0}", area);

        Console.ReadLine();
    }
}

