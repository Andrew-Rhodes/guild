using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSVPResponses.Models;

namespace RSVPResponses.Data
{
    public class AttendeeRepository
    {
        private static List<Attendee> _attendees;

        public AttendeeRepository()
        {
            if (_attendees == null)
            {
                _attendees = new List<Attendee>()
                {
                    new Attendee() {Name = "Liliana", Email = "Lili@softball.com", Attending = true, FavoriteGame = "7 Wonders"},
                    new Attendee() {Name = "Christian", Email = "pudge@minecraft.com", Attending = true, FavoriteGame = "Formula De"}
                };
            }
        }

        public List<Attendee> GetAll()
        {
            return _attendees;
        }

        public void Add(Attendee attendee)
        {
            _attendees.Add(attendee);
        }

        public void Delete(string name)
        {
            _attendees.Remove(_attendees.Where(a => a.Name == name).First());
        }
    }
}
