using Apollo.Tiers.DataAccess.Models;
using Apollo.Tiers.DataAccess.Repositroies.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Tiers.DataAccess.Repositroies.Implementations
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        protected readonly MyDbContext _context;

        public UserRepository(MyDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Page>> GetPages()
        {
            return await _context.Pages.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return  GetAll().ToList().FirstOrDefault(x => x.Id == id);
        }
    }
}
