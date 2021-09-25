using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class OperatorMaster
    {
        public long Id { get; set; }
        public string OperatorCode { get; set; }
        public string OperatorName { get; set; }
        public string Department { get; set; }
        public bool? IsActive { get; set; }
    }
}
