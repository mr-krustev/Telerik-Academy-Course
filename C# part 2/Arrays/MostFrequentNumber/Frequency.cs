/*
Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
*/

using System;
using System.Linq;

class Frequency
{
    
    static int[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
    static int[] index = new int[input.Max() + 1];
    static int[] frequency = new int[input.Max() + 1];
    static int[] numbers = new int[input.Max() + 1];
    static int counter = 0;

    static public void FrequentNumber(int[] input)
    {
       

        for (int i = 0; i < input.Length; i++)
        {
            frequency[input[i]]++; // input[i] represents a number from 0 to 9, which are the indexes of frequency[]. The index with most value will be shown.
        }
      

       for (int i = 0; i < input.Max() + 1; i++)
       {
           if (frequency[i] == frequency.Max())
           {
               numbers[counter] = frequency[i];
               index[counter] = i;
               counter++;
           }
       }
    }

    static void Main()
    {
        

        FrequentNumber(input);

        for (int i = 0; i < counter ; i++)
        {
            Console.WriteLine(index[i] + "({0} times)", numbers[i]);
        }
        
    }
}

