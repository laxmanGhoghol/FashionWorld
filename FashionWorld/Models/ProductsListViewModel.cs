using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FashionWorld.Models
{
    public class ProductsListViewModel
    {
        public products productMain { get; set; }
        public List<products> productRelated { get; set; }
    }
}