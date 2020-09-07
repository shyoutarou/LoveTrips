using LoveTrips.Core.Model;
using System.Threading.Tasks;

namespace LoveTrips.Core.Interfaces.Services
{
    public interface IUserDataService
    {
        Task<User> SearchUser(string userName);

        Task<User> Login(string userName, string password);

        User GetActiveUser();
    }
}
