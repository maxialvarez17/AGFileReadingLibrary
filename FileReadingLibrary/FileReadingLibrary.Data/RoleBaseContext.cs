using FileReadingLibrary.Model.Entities;
using FileReadingLibrary.Model.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Data
{
    public class RoleBaseContext
    {
        private static RoleBaseContext _instance;

        private RoleBaseContext()
        {
            this.FileReadingLibrarySettings = new FileReadingLibrarySettings();
        }

        public static RoleBaseContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RoleBaseContext();
                }

                return _instance;
            }
        }

        public FileReadingLibrarySettings FileReadingLibrarySettings { get; set; }

        public ICollection<User> Users
        {
            get
            {
                return new List<User>()
                {
                    new User() { Id = User.AdminUserId, Username = "Admin" },
                    new User() { Id = User.UserAId, Username = "UserA" },
                    new User() { Id = User.UserBId, Username = "UserB" }
                };
            }
        }

        public ICollection<Role> Roles
        {
            get
            {
                return new List<Role>()
                {
                    new Role() { Id = Role.AdminRoleId, Name = "Admin" },
                    new Role() { Id = Role.ManagerRoleId, Name = "Manager" },
                    new Role() { Id = Role.AuditorRoleId, Name = "Auditor" }
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
                        UserId = User.AdminUserId,
                        RoleId = Role.AdminRoleId
                    },
                    new UserRole()
                    {
                        UserId = User.UserAId,
                        RoleId = Role.ManagerRoleId
                    },
                    new UserRole()
                    {
                        UserId = User.UserAId,
                        RoleId = Role.AuditorRoleId
                    },
                    new UserRole()
                    {
                        UserId = User.UserBId,
                        RoleId = Role.AuditorRoleId
                    },
                };
            }
        }
    }
}