using FileReadingLibrary.Data.Interfaces.Repositories;
using FileReadingLibrary.Model.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Data.Implementations.Repositories
{
    public class UserRepository : IReadOnlyRepository<User>
    {
        private readonly RoleBaseContext roleBaseContext;

        public UserRepository()
        {
            this.roleBaseContext = RoleBaseContext.Instance;
        }

        public User Get(int id)
        {
            return this.GetAll()
                .Where(x => x.Id.Equals(id))
                .FirstOrDefault();
        }

        public ICollection<User> GetAll()
        {
            return this.roleBaseContext.Users;
        }
    }
}