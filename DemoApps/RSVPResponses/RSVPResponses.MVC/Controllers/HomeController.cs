using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RSVPResponses.Data;
using RSVPResponses.MVC.Models;

namespace RSVPResponses.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var repo = new AttendeeRepository();
            return View(repo.GetAll());
        }

        public ActionResult AddRSVP()
        {
            var gameRepo = new GameRepository();

            var model = new AttendeeVM();
            model.CreateGameList(gameRepo.GetAll());

            return View(model);
        }

        [HttpPost]
        public ActionResult AddRSVP(AttendeeVM attendee)
        {
            var repo = new AttendeeRepository();
            repo.Add(attendee.Guest);

            return View("Index", repo.GetAll());
        }
    }
}