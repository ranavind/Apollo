using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class DelayCodeMaster
    {
        public long Id { get; set; }
        public string DelayCode { get; set; }
        public string Description { get; set; }
    }
}
