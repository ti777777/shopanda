using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? Cid { get; set; }
        public DateTime? Time { get; set; }
    }
}
