using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Models
{
    public partial class Orderitem
    {
        public int Id { get; set; }
        public int Iid { get; set; }
        public int? Pid { get; set; }
        public int? Quantity { get; set; }
        public float? Discount { get; set; }
        public string Specialoption { get; set; }
    }
}
