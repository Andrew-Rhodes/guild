using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SWCCorpADO.Data;

namespace SWCCorpADO.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var repo = new SWCCorpDapperRepository();
            return View(repo.GetAllEmployees());
        }
    }
}