using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRPortal.Models.Data;

namespace HRPortal.Models.Repositories
{
    public class CompanyRepository
    {
        private static List<Company> _company;

        static CompanyRepository()
        {
            // sample data
            _company = new List<Company>
            {
                new Company() {CompanyId = 1, CompanyName = "Coffee Shop"},
                new Company() {CompanyId = 2, CompanyName = "Guitar Shop"},
                new Company() {CompanyId = 3, CompanyName = "Tech Shop"},
                new Company() {CompanyId = 4, CompanyName = ".NET Shop"},
                new Company() {CompanyId = 5, CompanyName = "Food Shop"},
                new Company() {CompanyId = 6, CompanyName = "Candy Shop"},
            };
        }

        public static IEnumerable<Company> GetAll()
        {
            return _company;
        }

        public static Company Get(int companyId)
        {
            return _company.FirstOrDefault(c => c.CompanyId == companyId);
        }

        public static void Add(string companyName)
        {
            Company company = new Company();

            company.CompanyName = companyName;
            company.CompanyId = _company.Max(c => c.CompanyId + 1);

            _company.Add(company);
        }

        public static void Edit(Company company)
        {
            var selectedCourse = _company.FirstOrDefault(c => c.CompanyId == company.CompanyId);

            selectedCourse.CompanyName = company.CompanyName;
        }

        public static void Delete(int compnayId)
        {
            _company.RemoveAll(c => c.CompanyId == compnayId);
        }
    }
}
