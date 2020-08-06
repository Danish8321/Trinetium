using System;
using System.Collections.Generic;
using System.Text;

namespace Trinetium.Entities.DTO
{
    public class OrderListCustDto
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }

    }
}
