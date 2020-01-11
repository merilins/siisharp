using System;
using System.Collections.Generic;

namespace trips_traps_trull
{
    class Program
    {
        public string player = "X";

        string[][] boardContent = new string[3][];

        public void createBoard()
        {
            boardContent[0] = new string[3] { " ", " ", " " };
            boardContent[1] = new string[3] { " ", " ", " " };
            boardContent[2] = new string[3] { " ", " ", " " };
            drawBoard(boardContent);
        }

        public void drawBoard(string[][] boardContent)
        {
            Console.Clear();
            Console.WriteLine("Mängujuhend: Sisesta rida ja veerg kujul RIDA VEERG (3 2).");
            Console.WriteLine($" {boardContent[0][0]} | {boardContent[0][1]} | {boardContent[0][2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {boardContent[1][0]} | {boardContent[1][1]} | {boardContent[1][2]}");
            Console.WriteLine("-----------");
            Console.WriteLine($" {boardContent[2][0]} | {boardContent[2][1]} | {boardContent[2][2]}");

        }

        public void chooseTurn()
        {
            
            if (player == "X")
            {
                player = "O";
            } else
            {
                player = "X";
            }
            Console.WriteLine($"Mängija {player} kord.");
            checkWinner();
            getInput();
        }

        public void getInput()
        {
                if (Array.Exists(boardContent[0], element => element == " ") || Array.Exists(boardContent[1], element => element == " ") || 
                    Array.Exists(boardContent[2], element => element == " "))
                {

                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        System.Environment.Exit(1);
                    }

                    string[] colRow = input.Split(" ");

                    int col = Int32.Parse(colRow[1]) - 1;
                    int row = Int32.Parse(colRow[0]) - 1;

                    insertIntoBoard(col, row);
                    
                } else { 
                Console.WriteLine("Mäng lõppes! Jäite viiki!");
            }
        }

        public void checkWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (boardContent[i][0] == "X" && boardContent[i][1] == "X" && boardContent[i][2] == "X")
                {
                    Console.WriteLine($"Mängija {boardContent[i][0]} võitis!");
                    System.Environment.Exit(1);
                }
                else if (boardContent[i][0] == "O" && boardContent[i][1] == "O" && boardContent[i][2] == "O")
                {
                    Console.WriteLine($"Mängija {boardContent[i][0]} võitis!");
                    System.Environment.Exit(1);
                }
            }
            if ((boardContent[0][0] == "O" && boardContent[1][1] == "O" && boardContent[2][2] == "O") || (boardContent[0][0] == "X" && boardContent[1][1] == "X" && boardContent[2][2] == "X"))
            {
                Console.WriteLine($"Mängija {boardContent[0][0]} võitis!");
                System.Environment.Exit(1);
            }
            else if ((boardContent[0][2] == "O" && boardContent[1][1] == "O" && boardContent[2][0] == "O") || (boardContent[0][2] == "X" && boardContent[1][1] == "X" && boardContent[2][0] == "X"))
            {
                Console.WriteLine($"Mängija {boardContent[0][2]} võitis!");
                System.Environment.Exit(1);
            }
            else if ((boardContent[0][0] == "O" && boardContent[1][0] == "O" && boardContent[2][0] == "O") || (boardContent[0][0] == "X" && boardContent[1][0] == "X" && boardContent[2][0] == "X")) {
                Console.WriteLine($"Mängija {boardContent[0][0]} võitis!");
                System.Environment.Exit(1);
            }
            else if((boardContent[0][1] == "O" && boardContent[1][1] == "O" && boardContent[2][1] == "O") || (boardContent[0][1] == "X" && boardContent[1][1] == "X" && boardContent[2][1] == "X")) {
                Console.WriteLine($"Mängija {boardContent[0][1]} võitis!");
                System.Environment.Exit(1);
            }
            else if((boardContent[0][2] == "O" && boardContent[1][2] == "O" && boardContent[2][2] == "O") || (boardContent[0][2] == "X" && boardContent[1][2] == "X" && boardContent[2][2] == "X"))
            {
                Console.WriteLine($"Mängija {boardContent[0][2]} võitis!");
                System.Environment.Exit(1);
            }

        }

        public void insertIntoBoard(int col, int row)
        {
            if(row == 0)
            {
                boardContent[0][col] = player;
            }
            else if(row == 1)
            {
                boardContent[1][col] = player;
            }
            if(row == 2)
            {
                boardContent[2][col] = player;
            }

            drawBoard(boardContent);
            chooseTurn();
        }

        public void Begin()
        {
            createBoard();
            Console.WriteLine($"Mängija {player} alustab.");
            getInput();
        }




        static void Main(string[] args)
        {
            Program tic = new Program();
            tic.Begin();
        }
    }
}

