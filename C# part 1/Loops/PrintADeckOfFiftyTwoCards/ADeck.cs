/*
Problem 4. Print a Deck of 52 Cards

Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
*/


using System;
using System.Linq;

class ADeck
{
    static void Main()
    {
        string[] highCards = new string[4] { "J", "Q", "K", "A" };

        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine("{0} of spades, {0} of hearts, {0} of diamonds, {0} of clubs", i);
        }
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("{0} of spades, {0} of hearts, {0} of diamonds, {0} of clubs", highCards[i]);
        }

    }
}

