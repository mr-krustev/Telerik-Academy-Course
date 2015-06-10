/*
Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Fill
{
    static int counter = 1;

    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {

                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void ClearMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 0;
            }
        }
    }

    static void FillMatrixTypeA(int[,] matrix)
    {
        ClearMatrix(matrix);
        for (int col = 0; col < matrix.GetLength(1); col++)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = counter;
                counter++;
            }
        }
        counter = 1;
    }

    static void FillMatrixTypeB(int[,] matrix)
    {
        ClearMatrix(matrix);

        int upOrDown = 0;
        int col = 0;

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (upOrDown > 1)
            {
                upOrDown--;
                for (int j = upOrDown; j > -1; j--)
                {
                    matrix[j, col] = counter;
                    counter++;
                    upOrDown--;
                }
                col++;
            }
            else if (upOrDown < 1)
            {
                upOrDown = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[j, col] = counter;
                    counter++;
                    upOrDown++;
                }
                col++;
            }
        }

        counter = 1;
    }

    static void FillMatrixTypeC(int[,] matrix)
    {
        ClearMatrix(matrix);

        int arraySize = matrix.GetLength(0);

        int row = arraySize - 1, col = 0, data = 0;

        for (int i = 0; i < arraySize; i++)
        {
            do
            {
                data++;
                if (row < 0) row = 0;
                matrix[row, col] = data;
                row++;
                col++;
            } while (row < arraySize);

            row -= col + 1;
            col = 0;
        }

        row = 0;
        col = 1;
        for (int i = 0; i < arraySize - 1; i++)
        {
            do
            {
                data++;
                matrix[row, col] = data;
                row++;
                col++;
            } while (col < arraySize);

            col -= row - 1;
            row = 0;
        }
    }

    static void FillMatrixTypeD(int[,] matrix)
    {
        ClearMatrix(matrix);

        string direction = "down";

        int currentRow = 0;
        int currentCol = 0;

        int matrixSize = matrix.GetLength(0);

        for (int i = 1; i <= matrixSize * matrixSize; i++)
        {
            matrix[currentRow, currentCol] = i;

            if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "right")
            {
                currentCol++;
            }

            if (direction == "down" && (currentRow >= matrixSize || matrix[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol++;
                direction = "right";
            }
            else if (direction == "right" && (currentCol >= matrixSize || matrix[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow++;
                direction = "down";
            }

        }

        counter = 1;
    }

    static void Main()
    {
        Console.Write("Enter size of matrix: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[,] arrayMatrix = new int[arraySize, arraySize];

        FillMatrixTypeA(arrayMatrix);
        PrintMatrix(arrayMatrix);

        Console.WriteLine();
        Console.WriteLine();

        FillMatrixTypeB(arrayMatrix);
        PrintMatrix(arrayMatrix);


        Console.WriteLine();
        Console.WriteLine();

        FillMatrixTypeD(arrayMatrix);
        PrintMatrix(arrayMatrix);

        

        Console.WriteLine();
        Console.WriteLine();

        FillMatrixTypeC(arrayMatrix);
        PrintMatrix(arrayMatrix);

    }
}

