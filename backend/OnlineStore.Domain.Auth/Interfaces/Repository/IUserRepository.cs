using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Domain.Users.Entities;

namespace OnlineStore.Domain.Users.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);

        void Update(User user);

        User GetByUserName(string userName);

        public Boolean ValidatePassword(User user);

        void Commit();
    }
}
