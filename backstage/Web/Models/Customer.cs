using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Customercol { get; set; }
    }
}
