using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Models
{
    public partial class Order
    {
        public int OId { get; set; }
        public int? MId { get; set; }
        public DateTime? OTime { get; set; }
    }
}
