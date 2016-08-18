using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCIdentity.Models;

namespace MVCIdentity.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        [Authorize]
        public ActionResult ShowUserInformation()
        {
            var userStore = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var user = userStore.FindById(User.Identity.GetUserId());

            return View(user);
        }

        [Authorize(Roles="Admin")]
        public ActionResult ShowOnlyToAdmins()
        {
            return View();
        }
    }
}