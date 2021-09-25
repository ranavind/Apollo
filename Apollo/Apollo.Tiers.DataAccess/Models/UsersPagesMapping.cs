using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class UsersPagesMapping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PageId { get; set; }
        public bool Permission { get; set; }

        public virtual Page Page { get; set; }
        public virtual User User { get; set; }
    }
}
