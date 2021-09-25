using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class MaterialCategoryMaster
    {
        public long Id { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }
    }
}
