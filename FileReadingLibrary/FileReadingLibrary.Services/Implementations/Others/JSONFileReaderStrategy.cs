using FileReadingLibrary.Model.Entities;
using FileReadingLibrary.Services.Interfaces.Others;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace FileReadingLibrary.Services.Implementations.Others
{
    public class JSONFileReaderStrategy : IFileReaderStrategy
    {
        private readonly FileMetadata file;
        private readonly IJSONFileDecryptor jsonFileDecryptor;

        public JSONFileReaderStrategy(FileMetadata file)
        {
            this.file = file;
            this.jsonFileDecryptor = new JSONFileDecryptor();
        }

        public string FilePath { get; set; }

        public string Read()
        {
            if (this.file.IsEncrypted)
            {
                var fileLines = File.ReadAllLines(this.FilePath);

                return this.jsonFileDecryptor.Decrypt(fileLines);
            }

            using (StreamReader jsonFile = File.OpenText(this.FilePath))
            using (JsonTextReader reader = new JsonTextReader(jsonFile))
            {
                var jsonContent = (JObject)JToken.ReadFrom(reader);

                return jsonContent.ToString();
            };
        }
    }
}