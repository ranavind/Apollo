using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class MachineMaster
    {
        public long Id { get; set; }
        public string MachineCode { get; set; }
        public string MachineName { get; set; }
        public string Description { get; set; }
        public string MachineGroup { get; set; }
        public bool? IsActive { get; set; }
    }
}
