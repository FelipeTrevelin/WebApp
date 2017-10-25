using WebApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Core.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<int> AddUser(User user);
        bool ValidateUser(User user);
    }
}
