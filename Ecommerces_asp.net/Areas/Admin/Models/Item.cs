using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.Areas.Admin.Models
{
    public class Item
    {
        public Product product { get; set; }
        public int quantity { get; set; }
    }
}
