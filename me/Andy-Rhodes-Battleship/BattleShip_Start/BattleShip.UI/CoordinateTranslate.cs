using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BattleShip.BLL.Requests;

namespace BattleShip.UI
{
    public class CoordinateTranslate
    {
        public Dictionary<string, int> lettersDictionary = new Dictionary<string, int>()
        {
            {"A", 1},
            {"B", 2},
            {"C", 3},
            {"D", 4},
            {"E", 5},
            {"F", 6},
            {"G", 7},
            {"H", 8},
            {"I", 9},
            {"J", 10}
        };

        public bool CoordinateValidate(string playerMove)
        {
            if ((playerMove == "") || (playerMove.Length > 3))
            {
                return false;
            }

            string numberPortion = playerMove.Substring(1);
            string letterPortion = playerMove.Substring(0, 1).ToUpper();

            int parsedNumber;
            int.TryParse(numberPortion, out parsedNumber);

            if ((parsedNumber < 1) || (parsedNumber > 10))
            {
                return false;
            }


            if ((letterPortion == "A") ||
                (letterPortion == "B") ||
                (letterPortion == "C") ||
                (letterPortion == "D") ||
                (letterPortion == "E") ||
                (letterPortion == "F") ||
                (letterPortion == "G") ||
                (letterPortion == "H") ||
                (letterPortion == "I") ||
                (letterPortion == "J"))
            {
                return true;
            }

            return false;
        }

        public Coordinate TranslteCoordinate(string playerMove)
        {
            string numberPortion = playerMove.Substring(1);

            int parsedNumber;
            int.TryParse(numberPortion, out parsedNumber);
            int userXCoordinate = parsedNumber;

            string letterPortion = playerMove.Substring(0, 1).ToUpper();

            int userYCoordinate = lettersDictionary[letterPortion];

            return new Coordinate(userXCoordinate, userYCoordinate);
        }
    }
}
