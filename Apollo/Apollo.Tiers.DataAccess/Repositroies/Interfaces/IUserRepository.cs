using Apollo.Tiers.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Tiers.DataAccess.Repositroies.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        Task<User> GetUserByIdAsync(int id);
        Task<List<Page>> GetPages();
        
    }

}
