using FileReadingLibrary.Data.Interfaces.Security;
using FileReadingLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Data.Implementations.Security
{
    public class FileRoleBasedInterceptor : IFileRoleBasedInterceptor
    {
        public RoleBasedContext roleBasedContext;

        public FileRoleBasedInterceptor()
        {
            this.roleBasedContext = RoleBasedContext.Instance;
        }

        public void Intercept(ref ICollection<FileMetadata> files)
        {
            var loggedUserId = this.roleBasedContext.FileReadingLibrarySettings.LoggedUserId;

            var loggedUserRoles = this.roleBasedContext.UserRoles
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