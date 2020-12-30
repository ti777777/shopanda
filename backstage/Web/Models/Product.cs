using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int? Price { get; set; }
        public string Category { get; set; }
        public string Contractor { get; set; }
        public int? Remaining { get; set; }
        public string Status { get; set; }
        public DateTime? Saledate { get; set; }
    }
}
