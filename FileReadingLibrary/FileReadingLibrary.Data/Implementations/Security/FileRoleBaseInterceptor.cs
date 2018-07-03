using FileReadingLibrary.Data.Interfaces.Security;
using FileReadingLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Data.Implementations.Security
{
    public class FileRoleBaseInterceptor : IFileRoleBaseInterceptor
    {
        public RoleBaseContext roleBaseContext;

        public FileRoleBaseInterceptor()
        {
            this.roleBaseContext = RoleBaseContext.Instance;
        }

        public void Intercept(ref ICollection<FileMetadata> files)
        {
            var loggedUserId = this.roleBaseContext.FileReadingLibrarySettings.LoggedUserId;

            var loggedUserRoles = this.roleBaseContext.UserRoles
                .Where(x => x.UserId.Equals(loggedUserId))
                .Select(x => x.RoleId)
                .ToList();

            files = files
                .Where(file => file.Roles
                .Any(fileRole => loggedUserRoles.Any(userRole => userRole.Equals(fileRole))))
                .ToList();
        }
    }
}