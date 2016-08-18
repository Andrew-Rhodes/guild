using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelValidation.Models.Attributes
{
    /// <summary>
    /// STEP 1
    /// create the NoGarfieldOnMondays Attribute that you will use on the class. 
    /// This attribute will test both the ClientName and Date attributes
    /// Because of testing multiple properties it should be used at the class level
    /// </summary>
    public class NoGarfieldOnMondaysAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Appointment app = value as Appointment;
            if (app == null || string.IsNullOrEmpty(app.ClientName))
            {
                return true;
            }
            else
            {
                return !(app.ClientName == "Garfield" &&
                         app.Date.DayOfWeek == DayOfWeek.Monday);
            }
        }
    }
}