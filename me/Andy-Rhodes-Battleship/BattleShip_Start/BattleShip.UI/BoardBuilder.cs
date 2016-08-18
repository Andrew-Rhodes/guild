using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    public class BoardBuilder
    {
        public string[,] DisplayBoard = new string[10, 10];

        public void ShipPlacementUpdate(Board board)
        {
            foreach (Ship ship in board.Ships)
            {
                if (ship == null)
                {
                    break;
                }
                foreach (Coordinate coord in ship.BoardPositions)
                {
                    Console.Clear();
                    DisplayBoard[coord.YCoordinate - 1, coord.XCoordinate - 1] = "";

                    Console.Write("     1    2    3    4    5    6    7    8    9    10\n");
                    Console.WriteLine();

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {

                            if (DisplayBoard[i, j] == null)
                            {
                                DisplayBoard[i, j] = "~";
                            }
                            else
                            {
                                DisplayBoard[coord.YCoordinate - 1, coord.XCoordinate - 1] = "S";
                            }
                        }
                    }

                    for (int i = 0; i <= 9; i++)
                    {
                        string letter = Char.ConvertFromUtf32(i + 65);
                        Console.Write(letter.PadRight(5));

                        for (int j = 0; j <= 9; j++)
                        {
                            if (DisplayBoard[i, j] == "S")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }

                            Console.Write(DisplayBoard[i, j] + "    ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        Console.WriteLine();
                        Console.WriteLine();

                    }
                }
            }
        }

        public void StarterBoard()
        {
            Console.Write("     1    2    3    4    5    6    7    8    9    10\n");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (DisplayBoard[i, j] == null)
                    {
                        DisplayBoard[i, j] = "~";
                    }
                    else
                    {
                        DisplayBoard[i, j] = "~";
                    }
                }
            }

            for (int i = 0; i <= 9; i++)
            {
                string letter = Char.ConvertFromUtf32(i + 65);
                Console.Write(letter.PadRight(5));

                for (int j = 0; j <= 9; j++)
                {
                    Console.Write(DisplayBoard[i, j] + "    ");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void PlayerShotBoard(Board board)
        {
            foreach (Coordinate coord in board.ShotHistory.Keys)
            {
                Console.Clear();
                DisplayBoard[coord.YCoordinate - 1, coord.XCoordinate - 1] = "";

                Console.Write("     1    2    3    4    5    6    7    8    9    10\n");
                Console.WriteLine();

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {

                        if (DisplayBoard[i, j] == null)
                        {
                            DisplayBoard[i, j] = "~";
                        }
                        else if (board.ShotHistory.ContainsKey(new Coordinate(coord.XCoordinate, coord.YCoordinate)))
                        {
                            switch (board.ShotHistory[new Coordinate(coord.XCoordinate, coord.YCoordinate)])
                            {

                                case ShotHistory.Hit:
                                    DisplayBoard[coord.YCoordinate - 1, coord.XCoordinate - 1] = "H";
                                    break;

                                case ShotHistory.Miss:
                                    DisplayBoard[coord.YCoordinate - 1, coord.XCoordinate - 1] = "M";
                                    break;
                            }
                        }
                    }
                }

                for (int i = 0; i <= 9; i++)
                {
                    string letter = Char.ConvertFromUtf32(i + 65);
                    Console.Write(letter.PadRight(5));

                    for (int j = 0; j <= 9; j++)
                    {

                        if (DisplayBoard[i, j] == "H")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (DisplayBoard[i, j] == "M")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }

                        Console.Write(DisplayBoard[i, j] + "    ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.WriteLine();
                    Console.WriteLine();

                }
            }
        }
    }
}