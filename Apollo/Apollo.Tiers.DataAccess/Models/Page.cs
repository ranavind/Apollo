using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class Page
    {
        public Page()
        {
            InverseParentpageNavigation = new HashSet<Page>();
            UsersPagesMappings = new HashSet<UsersPagesMapping>();
        }

        public int Id { get; set; }
        public string Page1 { get; set; }
        public int? Parentpage { get; set; }
        public int? RoleId { get; set; }

        public virtual Page ParentpageNavigation { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Page> InverseParentpageNavigation { get; set; }
        public virtual ICollection<UsersPagesMapping> UsersPagesMappings { get; set; }
    }
}
