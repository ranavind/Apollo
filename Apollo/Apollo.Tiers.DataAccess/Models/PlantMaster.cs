using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class PlantMaster
    {
        public long Id { get; set; }
        public string PlantSapcode { get; set; }
        public string PlantName { get; set; }
        public string PlantAddr { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gstin { get; set; }
    }
}
