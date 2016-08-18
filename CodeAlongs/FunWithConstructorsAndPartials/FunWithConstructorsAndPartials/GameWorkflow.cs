using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithConstructorsAndPartials
{
    public class GameWorkflow
    {
        // properties
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        // private static readonly field
        // private - only inside in the class
        // static - there is only one
        // readonly - can set in constructor only
        private static readonly Random _randonGenerator;

        // static constructor
        // can initialize static properties and fields
        // Note: It cannot interact with instances of the class
        static GameWorkflow()
        {
            _randonGenerator = new Random();
        }

        // private method, only used in this class
        private int RollDie()
        {
            return _randonGenerator.Next(1, 7);
        }

        public void PlayGame()
        {
            do
            {
                Player1.Score += RollDie();
                Player2.Score += RollDie();
            } while (Player1.Score < 100 && Player2.Score < 100);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("GAME OVER!");
            Console.WriteLine($"{Player1.Name}: {Player1.Score} vs {Player2.Name}: {Player2.Score}");
        }
    }
}
