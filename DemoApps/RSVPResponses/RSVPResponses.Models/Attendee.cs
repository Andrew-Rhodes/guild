using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSVPResponses.Models
{
    public class Attendee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool Attending { get; set; }
        public string FavoriteGame { get; set; }
        public DaysOfTheWeek Days { get; set; }
    }
}
