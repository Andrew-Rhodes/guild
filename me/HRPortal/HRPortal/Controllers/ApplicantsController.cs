using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPortal.Models.Data;
using HRPortal.Models.Repositories;
using HRPortal.Models.View_Model;

namespace HRPortal.Controllers
{
    public class ApplicantsController : Controller
    {
        public ActionResult ListOfCompanies()
        {
            var comp = CompanyRepository.GetAll();

            return View(comp.ToList());
        }

        [HttpGet]
        public ActionResult Applicants(int companyId)
        {
            var vm = new CompanyApplicationViewModel();

            var comp = CompanyRepository.Get(companyId);
            vm.Company = comp;

            vm.Application = new Application();


            return View(vm);
        }


        [HttpPost]
        public ActionResult ApplicationResult(CompanyApplicationViewModel vm)
        {
            
            
            if (!vm.Application.OkTerms.Value)
            {


            return View("Applicants", vm);
            }

                ApplicationRepository.Add(vm);
                return View("Thanks", vm);


        }
    }
}