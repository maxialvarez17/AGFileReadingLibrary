using FileReadingLibrary.Model.Entities;
using FileReadingLibrary.Services.Interfaces.Others;
using System.IO;
using System.Text;
using System.Xml;

namespace FileReadingLibrary.Services.Implementations.Others
{
    public class XMLFileReaderStrategy : IFileReaderStrategy
    {
        private readonly FileMetadata file;
        private readonly IXMLFileDecryptor xmlFileDecryptor;

        public XMLFileReaderStrategy(FileMetadata file)
        {
            this.file = file;

            this.xmlFileDecryptor = new XMLFileDecryptor();
        }

        public string FilePath { get; set; }

        public string Read()
        {
            if (this.file.IsEncrypted)
            {
                var fileLines = File.ReadAllLines(this.FilePath);

                return this.xmlFileDecryptor.Decrypt(fileLines); 
            }

            var doc = new XmlDocument();

            doc.Load(this.FilePath);

            return doc.OuterXml;
        }
    }
}