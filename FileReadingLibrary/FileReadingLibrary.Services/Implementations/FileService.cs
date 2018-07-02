using FileReadingLibrary.Data.Implementations.Repositories;
using FileReadingLibrary.Data.Interfaces.Repositories;
using FileReadingLibrary.DataTransferObjects.Entities;
using FileReadingLibrary.Model.Entities;
using FileReadingLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Implementations
{
    public class FileService : IFileService
    {
        private readonly IReadOnlyRepository<FileMetadata> fileRepository;

        public FileService()
        {
            this.fileRepository = new FileRepository();
        }

        public IEnumerable<FileDTO> GetAllFiles()
        {
            return this.fileRepository.GetAll()
                .Select(x => new FileDTO()
                {
                    Id = x.Id,
                    Name = x.Name
                });
        }

        public ReadFileDTO ReadFile(int fileId)
        {
            var file = this.fileRepository.Get(fileId);

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Concat(@"PhysicalFiles\", file.Name));

            string[] files = File.ReadAllLines(path);

            return new ReadFileDTO() { Name = file.Name, Content = files[0] };
        }
    }
}