﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelBinding101.Models
{
    public class Person
    {
        public int? PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address HomeAddress { get; set; }
    }
}