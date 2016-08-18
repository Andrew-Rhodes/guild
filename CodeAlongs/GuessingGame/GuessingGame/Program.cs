using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE GUESSING GAME");
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            bool keepPlaying = true;

            do
            {
                GameWorkflow game = new GameWorkflow();
                game.PlayGame(name);

                Console.Write("Would you like to play again? ");
                string response = Console.ReadLine();

                keepPlaying = TranslateResponse(response);
            } while (keepPlaying);

            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("hit enter key to exit");
            Console.ReadLine();
        }

        static bool TranslateResponse(string response)
        {
            switch (response.ToUpper())
            {
                case "Y":
                case "YES":
                case "SURE":
                    return true;
                default:
                    return false;
            }
        }
    }
}
