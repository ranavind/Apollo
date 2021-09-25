using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class ScrapTypeMaster
    {
        public long Id { get; set; }
        public string Sapcode { get; set; }
        public string ScrapType { get; set; }
    }
}
