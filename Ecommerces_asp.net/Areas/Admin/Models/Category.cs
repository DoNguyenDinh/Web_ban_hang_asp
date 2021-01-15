using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.Areas.Admin.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string NameVN { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}
