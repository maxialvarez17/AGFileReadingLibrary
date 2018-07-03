using FileReadingLibrary.DataTransferObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Interfaces.Services
{
    public interface IFileService
    {
        IEnumerable<FileDTO> GetAllFiles();

        ReadFileDTO ReadFile(int fileId);
    }
}