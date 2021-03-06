﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Trinetium.Entities.Models
{
    public partial class Region
    {
        public Region()
        {
            Territories = new HashSet<Territories>();
        }
        [Required]
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        public virtual ICollection<Territories> Territories { get; set; }
    }
}
