using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class AttributeMaster
    {
        public long Id { get; set; }
        public string AttributeName { get; set; }
        public string UnitOfMeasure { get; set; }
    }
}
