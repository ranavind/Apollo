using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class PackingTypeMaster
    {
        public long Id { get; set; }
        public string PackingCode { get; set; }
        public string PackingType { get; set; }
    }
}
