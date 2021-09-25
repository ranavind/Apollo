using Apollo.Tiers.DataAccess.Models;
using Apollo.Tiers.DataAccess.Repositroies.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Apollo.Tiers.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
             return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<User> AddUserAsync(User user)
        {
            return await _userRepository.AddAsync(user);
        }
        public async Task<User> UpdateUserAsync(User user)
        {
            return await _userRepository.UpdateAsync(user);
        }

        public Task<List<User>> GetUsers()
        {
            try
            {
                return _userRepository.GetAll().Include(author => author.RoleNavigation).ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> DeleteUser(User user)
        {
            return await _userRepository.Delete(user);
        }

        public async Task<List<Page>> GetPages()
        {
            return await _userRepository.GetPages();
        }
    }
}
