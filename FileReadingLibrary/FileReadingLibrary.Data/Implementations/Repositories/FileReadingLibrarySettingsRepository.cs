using FileReadingLibrary.Data.Interfaces.Repositories;
using FileReadingLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Data.Implementations.Repositories
{
    public class FileReadingLibrarySettingsRepository : IRepository<FileReadingLibrarySettings>
    {
        private readonly RoleBaseContext roleBaseContext;

        public FileReadingLibrarySettingsRepository()
        {
            this.roleBaseContext = RoleBaseContext.Instance;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public FileReadingLibrarySettings Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<FileReadingLibrarySettings> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(FileReadingLibrarySettings entity)
        {
            throw new NotImplementedException();
        }

        public void Update(FileReadingLibrarySettings entity)
        {
            this.roleBaseContext.FileReadingLibrarySettings = entity;
        }
    }
}