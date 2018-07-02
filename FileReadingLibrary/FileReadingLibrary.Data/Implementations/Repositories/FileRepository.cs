using FileReadingLibrary.Data.Interfaces.Repositories;
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

        public FileRepository()
        {
            this.fileReadingLibraryContext = new FileReadingLibraryContext();
        }

        public FileMetadata Get(int id)
        {
            return this.GetAll()
                .Where(x => x.Id.Equals(id))
                .FirstOrDefault();
        }

        public ICollection<FileMetadata> GetAll()
        {
            return this.fileReadingLibraryContext.Files;
        }
    }
}