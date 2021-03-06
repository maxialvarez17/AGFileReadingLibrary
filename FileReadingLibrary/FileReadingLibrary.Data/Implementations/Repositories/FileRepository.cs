﻿using FileReadingLibrary.Data.Implementations.Security;
using FileReadingLibrary.Data.Interfaces.Repositories;
using FileReadingLibrary.Data.Interfaces.Security;
using FileReadingLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Data.Implementations.Repositories
{
    public class FileRepository : IReadOnlyRepository<FileMetadata>
    {
        private readonly FileReadingLibraryContext fileReadingLibraryContext;
        private readonly IFileRoleBasedInterceptor fileRoleBasedInterceptor;

        public FileRepository()
        {
            this.fileReadingLibraryContext = new FileReadingLibraryContext();
            this.fileRoleBasedInterceptor = new FileRoleBasedInterceptor();
        }

        public FileMetadata Get(int id)
        {
            return this.GetAll()
                .Where(x => x.Id.Equals(id))
                .FirstOrDefault();
        }

        public ICollection<FileMetadata> GetAll()
        {
            var files = this.fileReadingLibraryContext.Files;

            this.fileRoleBasedInterceptor.Intercept(ref files); 

            return files;
        }
    }
}