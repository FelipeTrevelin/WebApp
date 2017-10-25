using WebApp.Core;
using WebApp.Core.Interfaces;
using WebApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WebApp.Service
{
    public class UserService : IUserService
    {
        private IRepository _repository = null;

        public UserService(IRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("IRepository", "Error on create instance!");
            }
            this._repository = repository;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _repository.GetAllAsync<User>();
        }


        public bool ValidateUser(User user)
        {
            return _repository.Get<User>(user.Email, user.UserName).FirstOrDefault() != null;
        }

        public async Task<int> AddUser(User user)
        {
            return await _repository.Insert<User>(user);
        }
    }
}
