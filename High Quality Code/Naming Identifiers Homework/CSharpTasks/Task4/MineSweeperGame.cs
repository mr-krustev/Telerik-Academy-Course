namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MineSweeperGame
    {
        public const int GameFieldRows = 5;
        public const int GameFieldCols = 10;

        public static void Main(string[] args)
        {
            string currentCommand = string.Empty;

            char[,] gameField = CreateGameField();
            char[,] bombs = FillGameFieldWithBombs();

            int currentScore = 0;
            bool stepOnBomb = false;

            var highScores = new List<HighScore>(6);

            int row = 0;
            int col = 0;

            bool flag = true;
            const int MAX = 35;
            bool flag2 = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Lets play a game of MineSweeper. Try your best to find all spots without a mine!");
                    Console.WriteLine("Command 'top' shows Highscore, 'restart' starts a new game, 'exit' exits te game!");
                    PrintField(gameField);
                    flag = false;
                }

                Console.Write("Select a column and a row separated by space(ex. \'1 2\'): ");
                currentCommand = Console.ReadLine().Trim();

                if (currentCommand.Length >= 3)
                {
                    if (int.TryParse(currentCommand[0].ToString(), out row) &&
                    int.TryParse(currentCommand[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        currentCommand = "turn";
                    }
                }

                switch (currentCommand)
                {
                    case "top":
                        HighScores(highScores);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        bombs = FillGameFieldWithBombs();
                        PrintField(gameField);
                        stepOnBomb = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Thanks for playing! Goodbye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PlayerTurn(gameField, bombs, row, col);
                                currentScore++;
                            }

                            if (MAX == currentScore)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                PrintField(gameField);
                            }
                        }
                        else
                        {
                            stepOnBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (stepOnBomb)
                {
                    PrintField(bombs);

                    Console.Write("\nBOOOOOOM! You died humbly with {0} points. " + "\nProvide your nickname: ", currentScore);
                    string nickname = Console.ReadLine();

                    HighScore playerSore = new HighScore(nickname, currentScore);
                    if (highScores.Count < 5)
                    {
                        highScores.Add(playerSore);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].Score < playerSore.Score)
                            {
                                highScores.Insert(i, playerSore);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.OrderBy(player => player.Score).ThenBy(player => player.Name);
                    HighScores(highScores);

                    gameField = CreateGameField();
                    bombs = FillGameFieldWithBombs();
                    currentScore = 0;
                    stepOnBomb = false;
                    flag = true;
                }

                if (flag2)
                {
                    Console.WriteLine("\nCongratulations! You found all spaces without bombs!");
                    PrintField(bombs);

                    Console.WriteLine("Provide your nickname: ");
                    string imeee = Console.ReadLine();

                    var playerScore = new HighScore(imeee, currentScore);

                    highScores.Add(playerScore);
                    HighScores(highScores);

                    gameField = CreateGameField();
                    bombs = FillGameFieldWithBombs();
                    currentScore = 0;
                    flag2 = false;
                    flag = true;
                }
            }
            while (currentCommand != "exit");
        }

        private static void HighScores(List<HighScore> scores)
        {
            Console.WriteLine("\nTo4KI:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, scores[i].Name, scores[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscores currently!\n");
            }
        }

        private static void PlayerTurn(char[,] gameField, char[,] bombs, int row, int col)
        {
            char amountOfBombs = GetBombsCount(bombs, row, col);
            bombs[row, col] = amountOfBombs;
            gameField[row, col] = amountOfBombs;
        }

        private static void PrintField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            char[,] board = new char[GameFieldRows, GameFieldCols];
            for (int i = 0; i < GameFieldRows; i++)
            {
                for (int j = 0; j < GameFieldCols; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] FillGameFieldWithBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!r3.Contains(asfd))
                {
                    r3.Add(asfd);
                }
            }

            foreach (int i2 in r3)
            {
                int kol = i2 / cols;
                int red = i2 % cols;
                if (red == 0 && i2 != 0)
                {
                    kol--;
                    red = cols;
                }
                else
                {
                    red++;
                }

                gameField[kol, red - 1] = '*';
            }

            return gameField;
        }

        private static void FillFieldWithBombsCount(char[,] field)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char numberOfBombs = GetBombsCount(field, i, j);
                        field[i, j] = numberOfBombs;
                    }
                }
            }
        }

        private static char GetBombsCount(char[,] field, int row, int col)
        {
            int count = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString()); // Is this parsing even needed?
        }
    }
}
