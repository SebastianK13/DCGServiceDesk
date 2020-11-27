using System.Threading.Tasks;
using DCGServiceDesk.Authentication.Models;

namespace DCGServiceDesk.Authentication.Services
{
    public interface IUserService
    {
        Task<User> GetByName(string username);
    }
}