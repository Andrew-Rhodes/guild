using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ModelValidation.Models.Attributes;

namespace ModelValidation.Models
{
    /// <summary>
    /// STEP 2
    /// Set the NoGarfieldOnMondays attribute on the class
    /// 
    /// STEP 3
    /// Commend out all of the attributes.
    /// We are no longer going to use attribute configuration
    /// 
    /// STEP 4
    /// Implement Ivalidatable on the Appointment class.
    /// This is known as a self-validating model. 
    /// </summary>
    //[NoGarfieldOnMondays]
    public class Appointment
    {
        //[Required]
        public string ClientName { get; set; }

        [DataType(DataType.Date)]
        //[Required(ErrorMessage = "Please enter a date")]
        //[FutureDate]
        public DateTime Date { get; set; }

        //[Range(typeof(bool), "true", "true", ErrorMessage = "You must accept the terms")]
        //[MustBeTrue(ErrorMessage = "You really need to check this!")]
        public bool TermsAccepted { get; set; }

        /// <summary>
        /// STEP 5
        /// Implement the Validate method
        /// Place all the validation logic in the method. 
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrEmpty(ClientName))
            {
                errors.Add(new ValidationResult("Please enter your name", new[] { "ClientName" }));
            }

            if (DateTime.Now > Date)
            {
                errors.Add(new ValidationResult("Please enter a date in the future", new[] { "Date" }));
            }

            if (errors.Count == 0 && ClientName == "Garfield" && Date.DayOfWeek == DayOfWeek.Monday)
            {
                errors.Add(new ValidationResult("Garfield cannot book on Mondays"));
            }

            if (!TermsAccepted)
            {
                errors.Add(new ValidationResult("You must accept the terms", new[] { "TermsAccepted" }));
            }

            return errors;
        }

    }
}