using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSVPResponses.Data
{
    public class GameRepository
    {
        private static List<string> _games;

        public GameRepository()
        {
            if (_games == null)
            {
                _games = new List<string>()
                {
                    "Pandemic", "Shadows Over Camelot", "Roll For The Galaxy", "Iota", "Formula De",
                    "Black Fleet", "7 Wonders", "Resistance", "Camel Up"
                };
            }
        }

        public List<string> GetAll()
        {
            return _games;
        }
    }
}
