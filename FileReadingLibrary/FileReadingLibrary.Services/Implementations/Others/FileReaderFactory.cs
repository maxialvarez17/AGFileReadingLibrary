using FileReadingLibrary.Model.Entities;
using FileReadingLibrary.Services.Interfaces.Others;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Implementations.Others
{
    public class FileReaderFactory : IFileReaderFactory
    {
        public IFileReaderStrategy Build(FileMetadata file)
        {
            IFileReaderStrategy fileReaderStrategy = null;

            switch (file.Extension)
            {
                case FileExtension.Txt:
                    fileReaderStrategy = new TXTFileReaderStrategy(file);
                    break;
                case FileExtension.Xml:
                    fileReaderStrategy = new XMLFileReaderStrategy();
                    break;
                default:
                    break;
            }
            
            fileReaderStrategy.FilePath = this.GetFilePath(file.Name);

            return fileReaderStrategy;
        }

        private string GetFilePath(string fileName)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Concat(@"PhysicalFiles\", fileName));
        }
    }
}