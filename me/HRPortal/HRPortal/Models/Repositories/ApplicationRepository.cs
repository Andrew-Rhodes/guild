using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRPortal.Models.Data;
using HRPortal.Models.View_Model;

namespace HRPortal.Models.Repositories
{
    public class ApplicationRepository
    {
        private static List<Application> _application;

        static ApplicationRepository()
        {
            _application = new List<Application>
            {
                new Application()
                {
                    FirstName = "Aaron",
                    LastName = "Smith",
                    StreetAddress = "123 ave",
                    City = "Fakeplace",
                    State = "Ohio",
                    CompanyId = 2,
                    Position = "Cashier",
                    OkTerms = true,
                    ApplicationNumber = 1,
                    TheDate = DateTime.Parse("1/1/2016")
                },
                new Application()
                {
                    FirstName = "Tim",
                    LastName = "Horton",
                    StreetAddress = "456 St",
                    City = "Fake Town",
                    State = "Indiana",
                    CompanyId = 2,
                    Position = "Janitor",
                    OkTerms = true,
                    ApplicationNumber = 2,
                    TheDate = DateTime.Parse("1/1/2016")
                },
                new Application()
                {
                    FirstName = "Amanda",
                    LastName = "Doe",
                    StreetAddress = "789 Point",
                    City = "Made up Town",
                    State = "Pennsylvania",
                    CompanyId = 4,
                    Position = "Boss",
                    OkTerms = true,
                    ApplicationNumber = 3,
                    TheDate = DateTime.Parse("1/1/2016")
                },
            };
        }

        public static IEnumerable<Application> GetAll()
        {
            return _application;
        }

        public static Application Get(int companyId)
        {
            return _application.FirstOrDefault(c => c.CompanyId == companyId);
        }

        public static List<Application> GetSome(int companyId)
        {
            var companyApps = new List<Application>();

            foreach (var a in _application)
            {
                if (a.CompanyId == companyId)
                    companyApps.Add(a);
            }

            return companyApps;
        }

        public static void Add( CompanyApplicationViewModel CAVM)
        {
            var app = CAVM.Application;

            app.CompanyId = CAVM.Company.CompanyId;
            app.TheDate = DateTime.Now;
            app.ApplicationNumber = int.Parse(DateTime.Now.ToString("HHmmss"));

            _application.Add(app);

            
        }

        public static void Edit(Company company)
        {
            //var selectedCourse = _company.FirstOrDefault(c => c.CompanyId == company.CompanyId);

            //selectedCourse.CompanyName = company.CompanyName;
        }

        public static void Delete(int compnayId)
        {
 //           _company.RemoveAll(c => c.CompanyId == compnayId);
        }
    }
}