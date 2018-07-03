using FileReadingLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Interfaces.Others
{
    public interface IFileReaderFactory
    {
        IFileReaderStrategy Build(FileMetadata file);
    }
}