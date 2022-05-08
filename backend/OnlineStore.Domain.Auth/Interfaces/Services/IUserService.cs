using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Users.Entities;

namespace OnlineStore.Domain.Users.Interfaces.Services
{
    public interface IUserService
    {
        void Create(User user);

        User GetByUserName(string userName);

        void Update(User user);

        bool ValidateUser(User user);
    }
}
