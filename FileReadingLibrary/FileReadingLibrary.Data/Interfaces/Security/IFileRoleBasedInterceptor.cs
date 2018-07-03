using FileReadingLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Data.Interfaces.Security
{
    public interface IFileRoleBasedInterceptor
    {
        void Intercept(ref ICollection<FileMetadata> files);
    }
}