using LoveTrips.Core.Model;
using System.Threading.Tasks;

namespace LoveTrips.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> SearchUser(string userName);

        Task<User> Login(string userName, string password);
    }
}
