using FileReadingLibrary.Data.Implementations.Repositories;
using FileReadingLibrary.Data.Interfaces.Repositories;
using FileReadingLibrary.DataTransferObjects.Entities;
using FileReadingLibrary.Model.Entities;
using FileReadingLibrary.Services.Implementations.Others;
using FileReadingLibrary.Services.Interfaces.Others;
using FileReadingLibrary.Services.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Implementations.Services
{
    public class FileService : IFileService
    {
        private readonly IReadOnlyRepository<FileMetadata> fileRepository;
        private readonly IFileReaderFactory fileReaderFactory;

        public FileService()
        {
            this.fileRepository = new FileRepository();
            this.fileReaderFactory = new FileReaderFactory();
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

            var fileReaderStrategy = this.fileReaderFactory.Build(file);

            return new ReadFileDTO()
            {
                Name = file.Name,
                Content = fileReaderStrategy.Read()
            };
        }
    }
}