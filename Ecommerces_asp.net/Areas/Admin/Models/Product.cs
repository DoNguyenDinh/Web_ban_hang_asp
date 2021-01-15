using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.Areas.Admin.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string color { get; set; }
        public string UnitBrief { get; set; }
        public double UnitPrice { get; set; }
        public string Image { get; set; }
        public System.DateTime ProductDate { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public bool Special { get; set; }
        public bool Latest { get; set; }
        public int Views { get; set; }
       

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual supplier Supplier { get; set; }

       
    }
}
