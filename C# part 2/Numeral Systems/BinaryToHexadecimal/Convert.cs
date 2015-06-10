/*
Problem 6. Binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Convert
{
    static int zeroToAdd = 0;

    static void AddZero(int numberLength)
    {
         int neededZeroes = numberLength % 4;

        switch (neededZeroes)
        {
            case 1: zeroToAdd = 3; break;
            case 2: zeroToAdd = 2; break;
            case 3: zeroToAdd = 1; break;
            default:
                zeroToAdd = 0;
                break;
        }
    }

    static void Main()
    {
        long binaryNumber = long.Parse(Console.ReadLine());
        int numberLength = binaryNumber.ToString().Length;
        AddZero(numberLength);

        string binaryToStr = binaryNumber.ToString().PadLeft(numberLength + zeroToAdd, '0');      
        string hexadecimalNumber = "";

        for (int i = 0; i < binaryToStr.Length; i += 4)
        {
            string tempString = "";
            for (int j = i; j < 4 + i; j++)
            {
                tempString += binaryToStr[j];
            }
            switch (tempString)
            {
                case "0000": hexadecimalNumber += "0"; break;
                case "0001": hexadecimalNumber += "1"; break;
                case "0010": hexadecimalNumber += "2"; break;
                case "0011": hexadecimalNumber += "3"; break;
                case "0100": hexadecimalNumber += "4"; break;
                case "0101": hexadecimalNumber += "5"; break;
                case "0110": hexadecimalNumber += "6" ; break;
                case "0111": hexadecimalNumber += "7" ; break;
                case "1000": hexadecimalNumber += "8" ; break;
                case "1001": hexadecimalNumber += "9" ; break;
                case "1010": hexadecimalNumber += "A" ; break;
                case "1011": hexadecimalNumber += "B" ; break;
                case "1100": hexadecimalNumber += "C" ; break;
                case "1101": hexadecimalNumber += "D" ; break;
                case "1110": hexadecimalNumber += "E" ; break;
                case "1111": hexadecimalNumber += "F" ; break;
                default:
                    break;
            }
        }

        Console.WriteLine("In Hexadecimal: {0}", hexadecimalNumber);
    }
}

