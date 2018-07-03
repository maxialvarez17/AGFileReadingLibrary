using FileReadingLibrary.Model.Entities;
using FileReadingLibrary.Services.Interfaces.Others;
using System.IO;

namespace FileReadingLibrary.Services.Implementations.Others
{
    public class TXTFileReaderStrategy : IFileReaderStrategy
    {
        private readonly FileMetadata file;
        private readonly ITXTFileDecryptor txtFileDecryptor;

        public TXTFileReaderStrategy(FileMetadata file)
        {
            this.file = file;

            this.txtFileDecryptor = new TXTFileDecryptor();
        }

        public string FilePath { get; set; }

        // NOTE: I assume all the txt files have just a line
        public string Read()
        {
            var fileLines = File.ReadAllLines(this.FilePath);

            return this.file.IsEncrypted
                ? this.txtFileDecryptor.Decrypt(fileLines)
                : fileLines[0];
        }
    }
}