using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.Areas.Admin.Models
{
    public class supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
