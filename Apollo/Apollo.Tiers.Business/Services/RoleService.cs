using Apollo.Tiers.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apollo.Tiers.DataAccess.Repositroies.Interfaces;

namespace Apollo.Tiers.Business.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public  Task<List<Role>> GetRoles()
        {
            return _roleRepository.GetAll().ToListAsync();
        }
    }
}
