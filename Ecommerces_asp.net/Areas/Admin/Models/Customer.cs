using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.Areas.Admin.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string  address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
