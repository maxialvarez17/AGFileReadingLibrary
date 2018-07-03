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
                    new FileMetadata() { Id = 1, Name = "TxtFile1.txt", Extension = FileExtension.Txt, IsEncrypted = false },
                    new FileMetadata() { Id = 2, Name = "TxtFile2.txt", Extension = FileExtension.Txt, IsEncrypted = false },
                    new FileMetadata() { Id = 3, Name = "XmlFile1.xml", Extension = FileExtension.Xml, IsEncrypted = false },
                    new FileMetadata() { Id = 4, Name = "XmlFile2.xml", Extension = FileExtension.Xml, IsEncrypted = false },
                    new FileMetadata() { Id = 5, Name = "EncryptedTxtFile1.txt", Extension = FileExtension.Txt, IsEncrypted = true },
                    new FileMetadata() { Id = 6, Name = "EncryptedTxtFile2.txt", Extension = FileExtension.Txt, IsEncrypted = true },
                    new FileMetadata() { Id = 7, Name = "EncryptedXmlFile1.xml", Extension = FileExtension.Xml, IsEncrypted = true },
                    new FileMetadata() { Id = 8, Name = "EncryptedXmlFile2.xml", Extension = FileExtension.Xml, IsEncrypted = true },
                    new FileMetadata() { Id = 9, Name = "JsonFile1.json", Extension = FileExtension.Json, IsEncrypted = false },
                    new FileMetadata() { Id = 10, Name = "JsonFile2.json", Extension = FileExtension.Json, IsEncrypted = false },
                };
            }
        }
    }
}