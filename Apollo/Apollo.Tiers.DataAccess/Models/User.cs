using System;
using System.Collections.Generic;

#nullable disable

namespace Apollo.Tiers.DataAccess.Models
{
    public partial class User
    {
        public User()
        {
            UsersPagesMappings = new HashSet<UsersPagesMapping>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public int? Role { get; set; }

        public virtual Role RoleNavigation { get; set; }
        public virtual ICollection<UsersPagesMapping> UsersPagesMappings { get; set; }
    }
}
