using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Implementations
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override Choice GetChoice()
        {
            Choice choice = Choice.Unknown;

            while (choice == Choice.Unknown)
            {
                Console.Write($"{Name}, Enter a choice (R)ock, (P)aper, (S)cissors: ");
                string input = Console.ReadLine();

                switch (input.ToUpper())
                {
                    case "R":
                        choice = Choice.Rock;
                        break;
                    case "P":
                        choice = Choice.Paper;
                        break;
                    case "S":
                        choice = Choice.Scissors;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry, Please try again!");
                        break;
                }
            }

            return choice;
        }
    }
}
