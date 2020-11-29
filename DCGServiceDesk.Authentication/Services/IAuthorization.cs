using DCGServiceDesk.Authentication.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCGServiceDesk.Authentication
{
    public interface IAuthorization
    {
        Task<User> Login(string username, string password);
    }
}
