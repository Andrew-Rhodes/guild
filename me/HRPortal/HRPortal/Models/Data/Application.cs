using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.WebPages.Instrumentation;

namespace HRPortal.Models.Data
{
    public class Application
    {
        [Required(ErrorMessage = "Enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your street address")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Enter your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter your state")]
        public string State { get; set; }

        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Enter the position you would like")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Must check the box to continue")]
        public bool? OkTerms { get; set; }

        public int ApplicationNumber { get; set; }

        public DateTime TheDate { get; set; }

    }
}