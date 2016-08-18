using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.GameLogic;

namespace BattleShip.UI
{
    public class StartMenu
    {
        public void StartGame()
        {
            Console.WriteLine("Welcome to BATTLESHIP!!!");
            Console.WriteLine();
            Console.WriteLine("Press any key to begin...");
            Console.ReadKey();
        }
    }
}
