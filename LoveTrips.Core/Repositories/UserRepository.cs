using LoveTrips.Core.Interfaces.Repositories;
using LoveTrips.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveTrips.Core.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {

        private static readonly List<User> AllKnownUsers = new List<User>
        {
            new User { UserName = "ricshik", Password="abc", UserId = 1}, 
            new User { UserName = "jondoe", Password="456", UserId = 2},
            new User { UserName = "shyo", Password="123", UserId = 3}
        };

        public async Task<User> SearchUser(string userName)
        {
            return await Task.FromResult(AllKnownUsers.FirstOrDefault(u => u.UserName == userName));
        }

        public async Task<User> Login(string userName, string password)
        {
            return await Task.FromResult(AllKnownUsers.FirstOrDefault(u => u.UserName == userName && u.Password == password));
        }
    }
}
