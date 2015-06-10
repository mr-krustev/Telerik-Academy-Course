/*
Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindSum
{
    static int bestSum = int.MinValue;
    static int bestBeginningRow = 0;
    static int bestBeginningCol = 0;

    static void PrintMatrix(int[,] matrix, int maxRow, int maxCol, int beginningRow = 0, int beginningCol = 0)
    {
        for (int row = beginningRow; row < maxRow; row++)
        {
            for (int col = beginningCol; col < maxCol; col++)
            {
                Console.Write("{0,1} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

    }

    static void FillMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Number[{0}, {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(new string('-',40));
        }
    }

    static void SearchBiggestSum(int[,] matrix)
    {
        for (int currentRow = 0; currentRow < matrix.GetLength(0) - 2; currentRow++)
        {
            int sum = 0;
            for (int currentCol = 0; currentCol < matrix.GetLength(1) - 2; currentCol++)
            {
                sum += matrix[currentRow, currentCol] + matrix[currentRow, currentCol + 1] + matrix[currentRow, currentCol + 2]
                    + matrix[currentRow + 1, currentCol] + matrix[currentRow + 1, currentCol + 1] + matrix[currentRow + 1, currentCol + 2]
                    + matrix[currentRow + 2, currentCol] + matrix[currentRow + 2, currentCol + 1] + matrix[currentRow + 2, currentCol + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestBeginningRow = currentRow;
                    bestBeginningCol = currentCol;
                }
            }
        }
    }


    static void Main()
    {
        Console.WriteLine("Creating a matrix N x M. Both inputs should be >= 3.\n" + new string('-',40));
        Console.Write("Enter size N of matrix: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Eter size M of matrix: ");
        int M = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, M];

        if (N >= 3 && M >= 3)
        {

            Console.WriteLine(new string('-',40) + "\nFill the matrix: ");
            FillMatrix(matrix);
            Console.Clear();

            SearchBiggestSum(matrix);

            Console.WriteLine("Your matrix: ");
            PrintMatrix(matrix, matrix.GetLength(0), matrix.GetLength(1));

            Console.WriteLine("Best 3x3 platform is: ");
            PrintMatrix(matrix, bestBeginningRow + 3, bestBeginningCol + 3, bestBeginningRow, bestBeginningCol);
        }
        else
        {
            Console.WriteLine(new string('-',40));
            Console.WriteLine("Both inputs should be more or equal to 3 to find a 3x3 platform!");
        }



    }
}

