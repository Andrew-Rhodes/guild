using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FlooringProgram.BLL;
using FlooringProgram.UI.Prompts;

namespace FlooringProgram.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu startMainMenu = new MainMenu();
            startMainMenu.MainMenuDisplay();

            Console.WriteLine("Press ENTER to EXIT");

            Console.ReadLine();
        }
    }
}
