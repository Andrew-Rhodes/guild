using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Models.Data;
using HRPortal.Models.Repositories;

namespace HRPortal.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult ListOfCompaniesAdmin()
        {
            var comp = CompanyRepository.GetAll();

            return View(comp.ToList());
        }

        [HttpGet]
        public ActionResult AddCompany()
        {
            return View(new Company());
        }

        [HttpPost]
        public ActionResult AddCompany(Company company)
        {
            CompanyRepository.Add(company.CompanyName);
            return RedirectToAction("ListOfCompaniesAdmin");
        }

        [HttpGet]
        public ActionResult CompanyHome(string id)
        {
            int parsedCompanyId = Int32.Parse(id);

            var appList = ApplicationRepository.GetSome(parsedCompanyId);

            return View(appList);
        }







    }
}