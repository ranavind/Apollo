using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class Config
    {
        public long Id { get; set; }
        public string ConfigKey { get; set; }
        public string Value { get; set; }
        public string Type { get; set; }
    }
}
