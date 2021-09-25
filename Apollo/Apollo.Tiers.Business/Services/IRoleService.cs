using Apollo.Tiers.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Tiers.Business.Services
{
   public interface IRoleService
    {
        Task<List<Role>> GetRoles();
    }
}
