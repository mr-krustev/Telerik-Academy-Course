using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Data;

namespace _11.FallingRocks
{

    class FallingROcks              // This is a copied version. So far on my game I have the gamefield and the player(able to move).
                                    // I have put it, so you would be able to see one way to make it work.
    {
        static void WriteOnPosition(int x, int y, char symbol, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        static void WriteStringOnPosition(int x, int y, string Message, ConsoleColor color = ConsoleColor.White)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(Message);
        }

        struct Rock
        {
            public int x;
            public int y;
            public ConsoleColor color;
            public char symbol;
        }

        struct Dwarf
        {
            public int x1;
            public int x2;
            public int x3;
            public int y;
            public ConsoleColor color;
            public char firstSymbol;
            public char secondSymbol;
            public char thirdSymbol;
        }

        static void Main(string[] args)
        {

            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 60;

            char[] rockSymbols = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
            String[] lightColorNames = { "Cyan", "Gray", "Green", "Magenta", "Red", "White", "Yellow" };
            char randomRockSymbol;
            int rockWidth;

            string userName;
            int score = 0;
            
            int playfildWidth = 35;
            Dwarf dwarf = new Dwarf();
            int lives = 3;
            
            bool lifeTaken = false;
            dwarf.x1 = 23;
            dwarf.x2 = 24;
            dwarf.x3 = 25;
            dwarf.y = Console.WindowHeight - 1;
            dwarf.firstSymbol = '(';
            dwarf.secondSymbol = '0';
            dwarf.thirdSymbol = ')';
            dwarf.color = ConsoleColor.White;


            Random randomGenerator = new Random();
            List<Rock> Rocks = new List<Rock>();

            while (true)
            {
                Rock newRock = new Rock();
                ConsoleColor consoleColor = new ConsoleColor();

                string randomColorName = lightColorNames[randomGenerator.Next(lightColorNames.Length)];
                consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), randomColorName);

                rockWidth = randomGenerator.Next(1, 5);
                randomRockSymbol = rockSymbols[randomGenerator.Next(rockSymbols.Length)];
                newRock.color = consoleColor;
                newRock.x = randomGenerator.Next(0, playfildWidth - 1);
                newRock.y = 0;
                newRock.symbol = randomRockSymbol;

                for (int i = 0; i < rockWidth; i++)
                {
                    Rocks.Add(newRock);
                    if (newRock.x < playfildWidth - 1) { newRock.x++; }
                } if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true); while (Console.KeyAvailable) { Console.ReadKey(true); } if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.x1 - 1 >= 0)
                        {
                            dwarf.x1--;
                            dwarf.x2--;
                            dwarf.x3--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.x3 + 1 <= playfildWidth - 1)
                        {
                            dwarf.x1++;
                            dwarf.x2++;
                            dwarf.x3++;
                        }
                    }
                }

                List<Rock> newList = new List<Rock>();
                for (int i = 0; i < Rocks.Count; i++)
                {
                    Rock oldRock = Rocks[i];
                    Rock rock = new Rock();
                    rock.x = oldRock.x;
                    rock.y = oldRock.y + 1;
                    rock.symbol = oldRock.symbol;
                    rock.color = oldRock.color;
                    if ((rock.x == dwarf.x1 || rock.x == dwarf.x2 || rock.x == dwarf.x3) && rock.y == dwarf.y)
                    {
                        if (lifeTaken == false)
                        {
                            lives--;
                            lifeTaken = true;
                        }
                        rock.symbol = 'x';
                        rock.color = ConsoleColor.Red;

                    }
                    if (rock.y < Console.WindowHeight)
                    {
                        newList.Add(rock);
                    }
                }

                Rocks = newList;
                Console.Clear();

                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    WriteOnPosition(playfildWidth, i, '|', ConsoleColor.Yellow);
                }
                WriteOnPosition(dwarf.x1, dwarf.y, dwarf.firstSymbol, dwarf.color);
                WriteOnPosition(dwarf.x2, dwarf.y, dwarf.secondSymbol, dwarf.color);
                WriteOnPosition(dwarf.x3, dwarf.y, dwarf.thirdSymbol, dwarf.color);

                foreach (Rock rock in Rocks)
                {
                    WriteOnPosition(rock.x, rock.y, rock.symbol, rock.color);
                }

                if (lifeTaken)
                {
                    Rocks.Clear();
                    Thread.Sleep(300);
                }
                WriteStringOnPosition(playfildWidth + 10, Console.WindowHeight - 29, "Lives:");
                WriteStringOnPosition(playfildWidth + 17, Console.WindowHeight - 29, Convert.ToString(lives));
                
                WriteStringOnPosition(playfildWidth, Console.WindowHeight - 26, Convert.ToString(score));

                if (lives < 1)
                {
                    

                    DataTable NamesScoresTable = new DataTable();
                    NamesScoresTable.Columns.Add("Names");
                    NamesScoresTable.Columns.Add("Scores");

                    string[] scores = System.IO.File.ReadAllLines("scoring.txt");
                    int i;
                    for (i = 0; i < scores.Length; i++) { string[] nameAndScore = scores[i].Split(':'); DataRow row = NamesScoresTable.NewRow(); row["Names"] = nameAndScore[0]; row["Scores"] = nameAndScore[1]; NamesScoresTable.Rows.Add(row); } DataView dataView = NamesScoresTable.DefaultView; dataView.Sort = "Scores desc"; DataTable sortedTable = dataView.ToTable(); int printPosition = 0; DataRow[] rows = sortedTable.Select(string.Empty); WriteStringOnPosition(playfildWidth + 2, Console.WindowHeight - 20, "Game over!", ConsoleColor.Red); WriteStringOnPosition(playfildWidth + 2, Console.WindowHeight - 13, "Score statistics:", ConsoleColor.Green); foreach (DataRow row in rows)
                    {
                        string scoreInfo; if (printPosition > 8)
                        {
                            scoreInfo = String.Format("{0}.{1}{2}", printPosition + 1, row["Names"].ToString().PadRight(9, ' '), Convert.ToString(int.Parse(row["Scores"].ToString())).PadLeft(9, ' '));
                            WriteStringOnPosition(playfildWidth + 2, Console.WindowHeight - 12 + printPosition, scoreInfo);
                        }
                        else
                        {
                            scoreInfo = String.Format("{0}.{1}{2}", printPosition + 1, row["Names"].ToString().PadRight(10, ' '), Convert.ToString(int.Parse(row["Scores"].ToString())).PadLeft(9, ' '));
                            WriteStringOnPosition(playfildWidth + 2, Console.WindowHeight - 12 + printPosition, scoreInfo);
                        }
                        printPosition++;
                        if (printPosition > 9)
                        {
                            break;
                        }
                    }
                    break;
                }

                lifeTaken = false;
                score++;
                Thread.Sleep(150);
            }
            WriteStringOnPosition(playfildWidth + 2, Console.WindowHeight - 19, "Press any key to exit.");
            Console.ReadKey();
        }
    }
}