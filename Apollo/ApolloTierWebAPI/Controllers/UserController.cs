using Apollo.Tiers.Business.Services;
using Apollo.Tiers.DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApolloTierWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/<RoleController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetUsers().Result;
        }
        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return await _userService.GetUserByIdAsync(id);
        }
        // POST: api/UserMasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CreateUser")]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            
            return await _userService.AddUserAsync(user);
        }
       
        [HttpPut("UpdateUser")]
        public async Task<ActionResult<User>> UpdateUser(User user)
        {
            return await _userService.UpdateUserAsync(user);
        }
        [HttpDelete("DeleteUser")]
        public async Task<ActionResult<User>> DeleteUser(User user)
        {
            return await _userService.DeleteUser(user);
        }
        [HttpGet("GetPages")]
        public IEnumerable<Page> GetPages()
        {
            return  _userService.GetPages().Result.ToList();
        }
    }
}
