using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Models
{
    public partial class Orderitem
    {
        public int OId { get; set; }
        public int OiId { get; set; }
        public int? PId { get; set; }
        public int? OiQuantity { get; set; }
        public float? OiDiscount { get; set; }
        public string OiSpecialoption { get; set; }
    }
}
