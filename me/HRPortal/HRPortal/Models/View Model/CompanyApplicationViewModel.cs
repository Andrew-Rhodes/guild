using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HRPortal.Models.Data;

namespace HRPortal.Models.View_Model
{
    public class CompanyApplicationViewModel
    {
        public Application Application { get; set; }
        public Company Company { get; set; }
    }
}