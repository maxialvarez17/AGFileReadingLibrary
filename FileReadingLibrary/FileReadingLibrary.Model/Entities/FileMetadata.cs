using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Model.Entities
{
    public class FileMetadata
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Extension { get; set; }
    }
}