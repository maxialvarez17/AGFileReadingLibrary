using FileReadingLibrary.Model.Entities;
using FileReadingLibrary.Services.Interfaces.Others;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Implementations.Others
{
    public class TXTFileReaderStrategy : IFileReaderStrategy
    {
        public string FilePath { get; set; }

        // NOTE: I assume all the txt files have just a line
        public string Read()
        {
            string[] fileLines = File.ReadAllLines(this.FilePath);

            return fileLines[0];
        }
    }
}