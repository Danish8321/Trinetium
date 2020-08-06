using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Trinetium.Entities.Models
{
    public partial class Shippers
    {
        public Shippers()
        {
            Orders = new HashSet<Orders>();
        }
        [Required]
        public int ShipperId { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Phone { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
