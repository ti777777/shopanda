using System;
using System.Collections.Generic;

#nullable disable

namespace Web.Models
{
    public partial class Account
    {
        public string MId { get; set; }
        public string Account1 { get; set; }
        public string Password { get; set; }
        public string MRole { get; set; }
        public string MName { get; set; }
        public string MSex { get; set; }
        public DateTime? MBirth { get; set; }
        public string MPhone { get; set; }
        public string MAddress { get; set; }
        public string MEmail { get; set; }
    }
}
