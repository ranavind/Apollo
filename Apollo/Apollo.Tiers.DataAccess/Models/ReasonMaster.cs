using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class ReasonMaster
    {
        public long Id { get; set; }
        public string DelayCode { get; set; }
        public string Description { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonName { get; set; }
    }
}
