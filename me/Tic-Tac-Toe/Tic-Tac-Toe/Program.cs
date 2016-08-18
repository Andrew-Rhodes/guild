using System;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string playAgain = "Y";


            //player info
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Please enter the name of Player 1 : ");
            var playerOneName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter the name of Player 2 : ");
            var playerTwoName = Console.ReadLine();

            //start of game
            while (playAgain == "Y")
            {

                var board = new GameBoard();
                var player = 2;
                string[] moveArray = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
                var isValid = false;
                var winValue = 0;
                var playingPlayer = "";


                while (winValue == 0)
                {
                    //player turn, player win assignment
                    if (player%2 == 0)
                    {
                        Console.WriteLine($"{playerOneName} make your move!!!");
                        playingPlayer = playerOneName;
                    }
                    else
                    {
                        Console.WriteLine($"{playerTwoName} make your move!!!");
                        playingPlayer = playerTwoName;
                    }


                    board.Board(moveArray);

                    //Move entered into array
                    do
                    {
                        var move = Console.ReadLine();

                        //changing string to int
                        var parsedMove = board.ParseNumber(move);

                        //adjusting int for the 0-index
                        parsedMove = parsedMove - 1;

                        Console.Clear();

                        if ((moveArray[parsedMove] != "X") && (moveArray[parsedMove] != "O"))
                        {
                            if (player%2 == 0)
                            {
                                moveArray[parsedMove] = "X";
                                player++;
                            }
                            else
                            {
                                moveArray[parsedMove] = "O";
                                player++;
                            }

                            isValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that spot is already taken. Please try again.");
                        }
                    } while (isValid == false);



                    //Checking to see if move was a win or tie
                    winValue = board.CheckWin(moveArray, winValue);



                    //Winner or tie notification and end of game
                    if (winValue == 1)
                    {
                        Console.WriteLine("Congratulations {0} you win!!!", playingPlayer);
                        Console.ReadLine();
                    }
                    else if (winValue == -1)
                    {
                        Console.WriteLine("This game is a tie, you're both losers");
                        Console.ReadLine();
                    }
                }



                //Asking User if they want to play again
                Console.Clear();
                Console.WriteLine("Would you like to play again <Y/N>");
                playAgain = Console.ReadLine().ToUpper();


                if (playAgain == "N")
                {
                    Console.WriteLine("Goodbye!!!");
                    Console.ReadLine();
                }


                //User answer Validation
                while ((playAgain != "Y") && (playAgain != "N"))
                {
                    Console.WriteLine("What? Enter <Y/N>");
                    playAgain = Console.ReadLine().ToUpper();

                    Console.Clear();
                }
            }
        }
    }
}