using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class ShiftMaster
    {
        public long Id { get; set; }
        public string ShiftCode { get; set; }
        public string ShiftIdCode { get; set; }
        public string StratTime { get; set; }
        public string EndTime { get; set; }
    }
}
