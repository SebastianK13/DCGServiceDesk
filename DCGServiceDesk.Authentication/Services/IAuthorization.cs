using DCGServiceDesk.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DCGServiceDesk.Data
{
    public interface IAuthorization
    {
        Task<User> Login(string username, string password);
    }
}