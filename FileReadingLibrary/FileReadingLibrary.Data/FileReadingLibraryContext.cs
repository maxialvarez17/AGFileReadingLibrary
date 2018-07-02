using FileReadingLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Data
{
    public class FileReadingLibraryContext
    {
        public ICollection<FileMetadata> Files
        {
            get
            {
                return new List<FileMetadata>()
                {
                    new FileMetadata() { Id = 1, Name = "TxtFile1.txt", Extension = "txt" },
                    new FileMetadata() { Id = 2, Name = "TxtFile2.txt", Extension = "txt" }
                };
            }
        }
    }
}