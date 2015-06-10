/*
Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindingSequence
{
    static int bestSequence = 0;
    static string element = "";

    static void FillStringArray(string[,] inputText)
    {
        for (int rows = 0; rows < inputText.GetLength(0); rows++)
        {
            for (int cols = 0; cols < inputText.GetLength(1); cols++)
            {
                Console.Write("The string on position[{0},{1}] is: ", rows, cols);
                inputText[rows, cols] = Console.ReadLine();
            }
        }
    }

    static void CheckForBiggestSequence(string[,] inputText)
    {
        for (int currentRow = 0; currentRow < inputText.GetLength(0); currentRow++)
        {
            for (int currentCol = 0; currentCol < inputText.GetLength(1); currentCol++)
            {
                int currentSequence = 0;


                for (int i = currentRow + 1; i < inputText.GetLength(0); i++)      // Checks vertuically.
                {
                    if (inputText[i, currentCol] == inputText[currentRow, currentCol])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        break;
                    }

                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        element = inputText[currentRow, currentCol];
                    }
                }

                currentSequence = 0;

                for (int i = currentCol + 1; i < inputText.GetLength(1); i++)      // Checks horizontally.
                {
                    if (inputText[currentRow, i] == inputText[currentRow, currentCol])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        break;
                    }

                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        element = inputText[currentRow, currentCol];
                    }
                }

                currentSequence = 0;

                for (int i = currentCol, j = currentRow; (i < inputText.GetLength(1) - 1) && (j < inputText.GetLength(0) - 1); i++, j++) // Checks diagonally down.
                {
                    if (inputText[j, i] == inputText[j + 1, i + 1])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        break;
                    }

                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        element = inputText[currentRow, currentCol];
                    }
                }

                currentSequence = 0;

                for (int i = currentRow, j = currentCol; i - 1 >= 0 && j + 1 < inputText.GetLength(1) - 1; i--, j++)   // Checks diagonally up.
                {
                    if (i - 1 >= 0 && j + 1 < inputText.GetLength(1) && inputText[j, i] == inputText[i - 1, j + 1])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        break;
                    }

                    if (currentSequence > bestSequence)
                    {
                        bestSequence = currentSequence;
                        element = inputText[currentRow, currentCol];
                    }
                }
            }
        }
    }

    static void PrintMatrix(string[,] inputText)
    {
        Console.WriteLine("Your matrix: ");
        for (int i = 0; i < inputText.GetLength(0); i++)
        {
            for (int j = 0; j < inputText.GetLength(1); j++)
            {
                Console.Write("{0,5}", inputText[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Please define the size of the matrix! N*M. \nRows = ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Cols = ");
        int M = int.Parse(Console.ReadLine());

        string[,] inputText = new string[N, M];
        FillStringArray(inputText);

        CheckForBiggestSequence(inputText);

        Console.Clear();
        PrintMatrix(inputText);

        Console.WriteLine(new string('-',40) + "\nBest sequence: ");
        for (int i = 0; i < bestSequence + 1; i++)
        {
            if (i + 1 < bestSequence + 1)
            {
                Console.Write(element + ", ");
            }
            else
            {
                Console.WriteLine(element);
            }
            
        }

    }
}
