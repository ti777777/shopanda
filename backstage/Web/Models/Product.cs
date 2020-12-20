using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Models
{
    public partial class Product
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public string PDescription { get; set; }
        public byte[] PImage { get; set; }
        public int? PPrice { get; set; }
        public string PCategory { get; set; }
        public string PContractor { get; set; }
        public int? PRemaining { get; set; }
        public string PStatus { get; set; }
        public DateTime? PSaledate { get; set; }
    }
}
