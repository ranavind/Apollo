using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class Role
    {
        public Role()
        {
            Pages = new HashSet<Page>();
            Users = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public string Role1 { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Page> Pages { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
