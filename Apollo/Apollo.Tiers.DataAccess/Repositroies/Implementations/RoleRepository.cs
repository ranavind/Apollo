using Apollo.Tiers.DataAccess.Models;
using Apollo.Tiers.DataAccess.Repositroies.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Tiers.DataAccess.Repositroies.Implementations
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(MyDbContext repositoryPatternDemoContext) : base(repositoryPatternDemoContext)
        {
        }
    }
}
