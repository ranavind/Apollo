using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class TransporterMaster
    {
        public long Id { get; set; }
        public string TranspoterSapcode { get; set; }
        public string TranspoterName { get; set; }
        public string TranspoterAddress { get; set; }
        public string Pincode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gstin { get; set; }
    }
}
