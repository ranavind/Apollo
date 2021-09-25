using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class LocationMaster
    {
        public long Id { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string Department { get; set; }
    }
}
