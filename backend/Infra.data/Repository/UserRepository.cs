using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.data.Context;
using OnlineStore.Domain.Users.Entities;
using OnlineStore.Domain.Users.Interfaces;

namespace Infra.data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext userContext;

        public UserRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public void Commit()
        {
            userContext.SaveChanges();
        }

        public void Create(User user)
        {
            userContext.Users.Add(user);
        }

        public User GetByUserName(string userName)
        {
            return userContext.Users.FirstOrDefault(user => user.UserName.Equals(userName));
        }

        public Boolean ValidatePassword(User user)
        {
            var password = user.Password;
            var userTemp = userContext.Users.FirstOrDefault(user => user.Password.Equals(password));

            if (userTemp != null)
            {
                return true;
            }

            return false;

        }

        public void Update(User user)
        {
            userContext.Users.Update(user);
        }
    }
}
