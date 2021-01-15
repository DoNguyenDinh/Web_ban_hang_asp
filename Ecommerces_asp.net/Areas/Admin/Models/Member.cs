using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerces_asp.net.Areas.Admin.Models
{
    public class Member
    {
        [Key]
        [Column(TypeName ="varchar(50)")]
        public string Username { get; set; }
        [Column(TypeName="varchar(255)")]
        public string password { get; set; }
        public int Rule { get; set; }
    }
}
