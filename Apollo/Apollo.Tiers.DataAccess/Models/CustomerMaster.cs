using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class CustomerMaster
    {
        public long Id { get; set; }
        public string CustomerSapcode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Pincode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gstin { get; set; }
    }
}
