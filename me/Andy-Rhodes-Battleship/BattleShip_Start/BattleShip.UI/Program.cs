using System;
using System.ComponentModel;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StartMenu mainMenu = new StartMenu();
            mainMenu.StartGame();
            Console.Clear();

            GameFlow newGameFlow = new GameFlow();
            BoardBuilder statBoardBuilder = new BoardBuilder();

            //getting player names
            Player player1 = newGameFlow.GettingPlayerOneName();
            Player player2 = newGameFlow.GettingPlayerTwoName();

            //gameflow
            string input = "";
            do
            {
                int gameRounds = 2;
                string playingPlayer;
                int victory = 0;


                //Place Ships
                Console.WriteLine("{0} place your ships", player1.Name);
                player1.PlayerBoard = newGameFlow.PlacingPlayersPieces(player1);


                Console.Clear();
                Console.WriteLine("{0} place your ships", player2.Name);
                player2.PlayerBoard = newGameFlow.PlacingPlayersPieces(player2);


                Console.Clear();

                do
                {
                    if (gameRounds%2 == 0)
                    {
                        if (gameRounds == 2)
                        {
                            statBoardBuilder.StarterBoard();
                        }

                        gameRounds++;
                        playingPlayer = player1.Name;
                        victory = newGameFlow.FireAShot(player1, player2, gameRounds);
                    }

                    else
                    {
                        if (gameRounds == 3)
                        {
                            statBoardBuilder.StarterBoard();
                        }

                        gameRounds++;
                        playingPlayer = player2.Name;
                        victory = newGameFlow.FireAShot(player2, player1, gameRounds);
                    }

                } while (victory != 1);


                Console.WriteLine("Want to play again? Press \"Q\" to quit");
                input = Console.ReadLine().ToUpper();

            } while (input != "Q");

            Console.WriteLine("Thanks for playing!!!");

            Console.ReadLine();
        }
    }
}


