namespace Methods.LoverOfThree
{
    using System;
    using System.Collections.Generic;

    public class LoverOfThree
    {
        private static string direction;

        private static void Main()
        {
            int[,] field = GetField();
            int numberOfMoves = int.Parse(Console.ReadLine());
            List<string[]> moves = new List<string[]>();

            int playerIndexRow = field.GetLength(0) - 1;
            int playerIndexCol = 0;

            long playerScore = 0;

            for (int i = 0; i < numberOfMoves; i++)
            {
                var inputMove = Console.ReadLine().Split(' ');

                moves.Add(inputMove);
            }

            foreach (var move in moves)
            {
                for (int i = 0; i < int.Parse(move[1]) - 1; i++)
                {
                    int rowBeforeMovement = playerIndexRow;
                    int colBeforeMovement = playerIndexCol;

                    switch (move[0])
                    {
                        case "RU":
                        case "UR":
                            playerIndexRow -= 1;
                            playerIndexCol += 1;
                            break;

                        case "LU":
                        case "UL":
                            playerIndexRow -= 1;
                            playerIndexCol -= 1;
                            break;

                        case "DL":
                        case "LD":
                            playerIndexRow += 1;
                            playerIndexCol -= 1;
                            break;

                        case "RD":
                        case "DR":
                            playerIndexRow += 1;
                            playerIndexCol += 1;
                            break;
                        default:
                            break;
                    }

                    try
                    {
                        playerScore += field[playerIndexRow, playerIndexCol];
                        field[playerIndexRow, playerIndexCol] = 0;
                    }
                    catch (IndexOutOfRangeException)
                    {
                        playerIndexRow = rowBeforeMovement;
                        playerIndexCol = colBeforeMovement;
                        break;
                    }
                }
            }

            Console.WriteLine(playerScore);
        }

        private static int[,] GetField()
        {
            var fieldDimension = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(fieldDimension[0]);
            int cols = int.Parse(fieldDimension[1]);
            var matrix = new int[rows, cols];

            int currentColValue = 3;
            int currentRowValue = 3;

            for (int currentRow = rows - 1; currentRow >= 0; currentRow--)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    if (currentRow == rows - 1 && currentCol == 0)
                    {
                        matrix[currentRow, currentCol] = 0;
                        continue;
                    }

                    if (currentRow == rows - 1)
                    {
                        matrix[currentRow, currentCol] = currentColValue;
                        currentColValue += 3;
                        continue;
                    }

                    if (currentCol == 0)
                    {
                        matrix[currentRow, currentCol] = currentRowValue;
                        currentRowValue += 3;
                        continue;
                    }

                    matrix[currentRow, currentCol] = matrix[currentRow + 1, currentCol] + 3;
                }
            }

            return matrix;
        }
    }
}