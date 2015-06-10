/*
Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class GetMaxArea
{
    static int[,] matrix;

    private static void FillMatrixByText(StreamReader readText)
    {
        using (readText)
        {
            int matrixSize = int.Parse(readText.ReadLine());
            matrix = new int[matrixSize, matrixSize];
            int[] numbers;
            int row = 0;
            string line = readText.ReadLine();

            while (line != null)
            {
                numbers = line.Split(new char[] { ' ', }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                
                for (int col = 0; col < numbers.Length; col++)
                {
                    matrix[row, col] = numbers[col];
                }
                row++;
                line = readText.ReadLine();
            }
        }
    }

    static void Main()
    {
        StreamReader readText = new StreamReader(@"..\..\Text.txt");

        FillMatrixByText(readText);
        
        int sum = 0;
        int GreatestSum = int.MinValue;
        int GreatestEleRow = int.MinValue;
        int GreatestEleCol = int.MinValue;
       
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {    
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                if (sum > GreatestSum)
                {
                    GreatestSum = sum;
                    GreatestEleRow = row;
                    GreatestEleCol = col;
                }
            }
        }

        Console.WriteLine("Sum: {0}", GreatestSum);

        for (int row = GreatestEleRow; row < GreatestEleRow+2; row++)
        {
            for (int col = GreatestEleCol; col < GreatestEleCol + 2; col++)
            {
                Console.Write(matrix[row, col] +" ");
            }
            Console.WriteLine();
        }


    }
}

