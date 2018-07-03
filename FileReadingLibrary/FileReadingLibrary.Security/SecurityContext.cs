using FileReadingLibrary.Model.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Security
{
    public class SecurityContext
    {
        private static SecurityContext _instance;

        private SecurityContext()
        {
            this.LoggedUser = new LoggedUser();
        }

        public static SecurityContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SecurityContext();
                }

                return _instance;
            }
        }

        public LoggedUser LoggedUser { get; set; }

        public ICollection<User> Users
        {
            get
            {
                return new List<User>()
                {
                    new User() { Id = 1, Username = "Admin" },
                    new User() { Id = 2, Username = "UserA" },
                    new User() { Id = 3, Username = "UserB" }
                };
            }
        }

        public ICollection<Role> Roles
        {
            get
            {
                return new List<Role>()
                {
                    new Role() { Id = 1, Name = "Admin" },
                    new Role() { Id = 2, Name = "Manager" },
                    new Role() { Id = 3, Name = "Auditor" }
                };
            }
        }

        public ICollection<UserRole> UserRoles
        {
            get
            {
                return new List<UserRole>()
                {
                    new UserRole()
                    {
                        User = this.Users.Where(x => x.Username.Equals("Admin")).FirstOrDefault(),
                        Role = this.Roles.Where(x => x.Name.Equals("Admin")).FirstOrDefault()
                    },
                    new UserRole()
                    {
                        User = this.Users.Where(x => x.Username.Equals("UserA")).FirstOrDefault(),
                        Role = this.Roles.Where(x => x.Name.Equals("Manager")).FirstOrDefault()
                    },
                    new UserRole()
                    {
                        User = this.Users.Where(x => x.Username.Equals("UserA")).FirstOrDefault(),
                        Role = this.Roles.Where(x => x.Name.Equals("Auditor")).FirstOrDefault()
                    },
                    new UserRole()
                    {
                        User = this.Users.Where(x => x.Username.Equals("UserB")).FirstOrDefault(),
                        Role = this.Roles.Where(x => x.Name.Equals("Auditor")).FirstOrDefault()
                    },
                };
            }
        }
    }
}