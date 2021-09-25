using Apollo.Tiers.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Tiers.Business.Services
{
    public interface IUserService
    {
        Task<User> AddUserAsync(User user);

        Task<User> GetUserByIdAsync(int id);
        Task<List<User>> GetUsers();
        Task<User> UpdateUserAsync(User user);
        Task<User> DeleteUser(User user);
        Task<List<Page>> GetPages();
    }
}
