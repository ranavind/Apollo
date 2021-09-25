using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class DepartmentMaster
    {
        public long Id { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
    }
}
