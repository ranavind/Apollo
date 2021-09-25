using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class StorageCreationMaster
    {
        public long Id { get; set; }
        public string StorageType { get; set; }
        public string StorageCode { get; set; }
        public string Description { get; set; }
        public string StorageNo { get; set; }
        public bool? Status { get; set; }
    }
}
