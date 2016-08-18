using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RSVPResponses.Models;

namespace RSVPResponses.MVC.Models
{
    public class AttendeeVM
    {
        public Attendee Guest { get; set; }
        public List<SelectListItem> Games { get; set; }

        public AttendeeVM()
        {
            Guest = new Attendee();
            Games = new List<SelectListItem>();
        }

        public void CreateGameList(List<string> gameList)
        {
            foreach (var game in gameList)
            {
                Games.Add(new SelectListItem() {Value = game, Text = game});
            }
        }
    }
}