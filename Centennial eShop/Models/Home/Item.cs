using System;
using Ecommerce.Dal2;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models.Home
{
    public class Item
    {
        public Tbl_Product Product { get; set; }
        public int Quantity { get; set; }
    }
}