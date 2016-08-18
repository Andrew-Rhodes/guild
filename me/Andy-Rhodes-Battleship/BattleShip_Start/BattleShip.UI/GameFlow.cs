using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;

namespace BattleShip.UI
{
    public class GameFlow
    {
        public Player GettingPlayerOneName()
        {
            Console.Write("Enter the name of player one...");

            Player player1 = new Player()
            {
                Name = Console.ReadLine(),
            };
            return player1;
        }

        public Player GettingPlayerTwoName()
        {
            Console.Write("Enter the name of player two...");

            Player player2 = new Player()
            {
                Name = Console.ReadLine(),
            };
            return player2;
        }

        public Board PlacingPlayersPieces(Player playerPlacingShips)
        {
            Board playersBoard = new Board();
            CoordinateTranslate translate = new CoordinateTranslate();
            PlaceShipRequest request = new PlaceShipRequest();
            BoardBuilder blankBoard = new BoardBuilder();


            Console.Clear();
            blankBoard.StarterBoard();


            for (var i = 0; i <= 4; i++)
            {

                blankBoard.ShipPlacementUpdate(playersBoard);

                switch (i)
                {
                    case 0:
                        request.ShipType = ShipType.Destroyer;
                        break;
                    case 1:
                        request.ShipType = ShipType.Submarine;
                        break;
                    case 2:
                        request.ShipType = ShipType.Cruiser;
                        break;
                    case 3:
                        request.ShipType = ShipType.Battleship;
                        break;
                    case 4:
                        request.ShipType = ShipType.Carrier;
                        break;
                }


                bool goodPlace = false;
                do
                {
                    //coordinate validation
                    string playerMove = "";
                    bool coordinateValidatebool = false;
                    do
                    {
                        Console.Write("{0}, Enter the starting coordinates to place your {1} : ",
                            playerPlacingShips.Name, request.ShipType);

                        playerMove = Console.ReadLine();

                        coordinateValidatebool = translate.CoordinateValidate(playerMove);

                        if (coordinateValidatebool == false)
                        {
                            Console.WriteLine("Please enter a valid coordinate...\n");
                        }

                    } while (coordinateValidatebool != true);


                    //    translating staring ship position
                    var myCoordinate = translate.TranslteCoordinate(playerMove);
                    request.Coordinate = myCoordinate;



                    //   enter a valid direction
                    bool boolDirection = false;
                    do
                    {
                        //   prompt for direction
                        Console.Write("What direction would you like the ship? : ");

                        //  reading player input
                        string direction = Console.ReadLine()?.ToUpper();
                        Console.WriteLine();

                        switch (direction)
                        {
                            case "UP":
                                request.Direction = ShipDirection.Up;
                                boolDirection = true;
                                break;

                            case "DOWN":
                                request.Direction = ShipDirection.Down;
                                boolDirection = true;
                                break;

                            case "LEFT":
                                request.Direction = ShipDirection.Left;
                                boolDirection = true;
                                break;

                            case "RIGHT":
                                request.Direction = ShipDirection.Right;
                                boolDirection = true;
                                break;
                            default:
                                Console.WriteLine("Enter a valid direction...");
                                boolDirection = false;
                                break;
                        }
                    } while (boolDirection == false);


                    var checkPlaceShipResponse = playersBoard.PlaceShip(request);


                    if (checkPlaceShipResponse == ShipPlacement.NotEnoughSpace)
                    {
                        Console.WriteLine("Ship placement is out of bounds, please try again\n");
                        goodPlace = false;
                    }
                    else if (checkPlaceShipResponse == ShipPlacement.Overlap)
                    {
                        Console.WriteLine("You can't have ship overlapping, please try again\n");
                        goodPlace = false;
                    }
                    else
                    {
                        goodPlace = true;
                    }
                } while (goodPlace != true);
            }
            return playersBoard;
        }

        public int FireAShot(Player playShooting, Player opponetsBoard, int gamerounds)
        {
            BoardBuilder shotBoard = new BoardBuilder();
            CoordinateTranslate fireTranslate = new CoordinateTranslate();

            Console.WriteLine($"{playShooting.Name}, press Enter to begin your turn...");
            Console.ReadLine();


            shotBoard.PlayerShotBoard(opponetsBoard.PlayerBoard);


            bool shottrue = false;
            do
            {
                string playerMove = "";

                bool coordinateValidatebool = false;
                do
                {
                    Console.WriteLine($"{playShooting.Name}, enter your coordinates to take a shot!!!");

                    playerMove = Console.ReadLine();

                    coordinateValidatebool = fireTranslate.CoordinateValidate(playerMove);

                    if (coordinateValidatebool == false)
                    {
                        Console.WriteLine("Please enter a valid coordinate...\n");
                    }

                } while (coordinateValidatebool != true);


                fireTranslate.CoordinateValidate(playerMove);


                Coordinate playerCoordinate = fireTranslate.TranslteCoordinate(playerMove);


                var response = opponetsBoard.PlayerBoard.FireShot(playerCoordinate);


                Console.Clear();
                

                switch (response.ShotStatus)
                {
                    case ShotStatus.Invalid:
                        shotBoard.PlayerShotBoard(opponetsBoard.PlayerBoard);
                        shottrue = false;
                        Console.WriteLine($"{playShooting.Name}, enter a valid shot...");
                        break;

                    case ShotStatus.Duplicate:
                        shotBoard.PlayerShotBoard(opponetsBoard.PlayerBoard);
                        shottrue = false;
                        Console.WriteLine($"{playShooting.Name}, you already took that shot...");
                        break;

                    case ShotStatus.Miss:
                        shottrue = true;
                        Console.WriteLine($"{playShooting.Name}, missed");
                        break;

                    case ShotStatus.Hit:
                        shottrue = true;
                        Console.WriteLine($"{playShooting.Name}, hit a ship!");
                        break;

                    case ShotStatus.HitAndSunk:
                        shottrue = true;
                        Console.WriteLine($"Good Work!!! {playShooting.Name} sunk a boat!!!");
                        break;

                    case ShotStatus.Victory:
                        shottrue = true;
                        Console.WriteLine(
                            $"Nicely done, {playShooting.Name} sunk the {response.ShipImpacted}, winning the game!!!");
                        return 1;

                    default:
                        Console.WriteLine($"Eh...{playShooting.Name} did something...try again");
                        break;
                }

            } while (shottrue != true);

            return 0;
        }
    }
}
