﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Shipping
    {
       
        public string Country { get; set; }
       
        public string FirstName { get; set; }
        
        public string LastName { get; set; }


       
        public string StreetAddress { get; set; }

        
        public int Apartment { get; set; }


      
        public string City { get; set; }


        
        public string ZipCode { get; set; }
    }
}