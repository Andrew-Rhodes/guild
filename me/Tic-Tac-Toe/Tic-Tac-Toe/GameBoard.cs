using System;

namespace Tic_Tac_Toe
{
    public class GameBoard
    {
        public void Board(string[] MoveArray)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", MoveArray[0], MoveArray[1], MoveArray[2]);
            Console.WriteLine("     |     |      ");
            Console.WriteLine("------------------");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", MoveArray[3], MoveArray[4], MoveArray[5]);
            Console.WriteLine("     |     |      ");
            Console.WriteLine("------------------");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", MoveArray[6], MoveArray[7], MoveArray[8]);
            Console.WriteLine("     |     |      ");
        }

        public int CheckWin(string[] moveArray, int winValue)
        {
            //tie
            if (moveArray[0] != "1" && moveArray[1] != "2" && moveArray[2] != "3" && moveArray[3] != "4" &&
                moveArray[4] != "5" && moveArray[5] != "6" && moveArray[6] != "7" && moveArray[7] != "8" &&
                moveArray[8] != "9")
            {
                winValue = -1;
            }

            //horizantal win
            else if ((moveArray[0] == moveArray[1]) && (moveArray[2] == moveArray[1]))
            {
                winValue = 1;
            }
            else if ((moveArray[3] == moveArray[4]) && (moveArray[5] == moveArray[4]))
            {
                winValue = 1;
            }

            else if ((moveArray[6] == moveArray[7]) && (moveArray[8] == moveArray[7]))
            {
                winValue = 1;
            }


            //vertical win
            else if ((moveArray[0] == moveArray[3]) && (moveArray[6] == moveArray[3]))
            {
                winValue = 1;
            }
            else if ((moveArray[1] == moveArray[4]) && (moveArray[7] == moveArray[4]))
            {
                winValue = 1;
            }
            else if ((moveArray[2] == moveArray[5]) && (moveArray[8] == moveArray[5]))
            {
                winValue = 1;
            }


            //diagonal win
            else if ((moveArray[0] == moveArray[4]) && (moveArray[8] == moveArray[4]))
            {
                winValue = 1;
            }
            else if ((moveArray[2] == moveArray[4]) && (moveArray[6] == moveArray[4]))
            {
                winValue = 1;
            }


            return winValue;
        }


        //string to int, only numbers 1-9
        public int ParseNumber(string move)
        {
            int parsedMove;
            if (!int.TryParse(move, out parsedMove))
            {
                Console.WriteLine("Please enter a valid number");

                var newMove = Console.ReadLine();

                return ParseNumber(newMove);
            }


            if ((parsedMove > 9) || (parsedMove < 1))
            {
                Console.WriteLine("Please enter a valid number");

                var newMove = Console.ReadLine();

                return ParseNumber(newMove);
            }


            return parsedMove;
        }
    }
}