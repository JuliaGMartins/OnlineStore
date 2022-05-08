using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using OnlineStore.Domain.Users.Entities;
using OnlineStore.Domain.Users.Interfaces;
using OnlineStore.Domain.Users.Interfaces.Services;

namespace OnlineStore.Domain.Users.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public void Create(User user)
        {
            userRepository.Create(user);
            userRepository.Commit();
        }

        public User GetByUserName(string userName)
        {
            var user = userRepository.GetByUserName(userName);
            return user;
        }

        public void Update(User user)
        {
            //ValidateUserName(user);
            userRepository.Update(user);
            userRepository.Commit();
        }

        public bool ValidateUser(User user)
        {
            var userTemp = userRepository.GetByUserName(user.UserName);
            if (userTemp == null)
            {
                return false;
            } else if (!userRepository.ValidatePassword(userTemp))
            {
                return false;
            }
            return true;
        }
    }
}
