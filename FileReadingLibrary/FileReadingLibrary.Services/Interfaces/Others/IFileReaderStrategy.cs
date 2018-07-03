using FileReadingLibrary.DataTransferObjects.Entities;
using FileReadingLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Interfaces.Others
{
    public interface IFileReaderStrategy
    {
        string FilePath { get; set; }

        string Read();
    }
}