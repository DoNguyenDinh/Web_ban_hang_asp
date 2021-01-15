using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.Areas.Admin.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustommerName { get; set; }
        public string Receiver { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
