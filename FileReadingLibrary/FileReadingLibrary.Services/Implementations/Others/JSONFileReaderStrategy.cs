using FileReadingLibrary.Services.Interfaces.Others;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace FileReadingLibrary.Services.Implementations.Others
{
    public class JSONFileReaderStrategy : IFileReaderStrategy
    {
        public string FilePath { get; set; }

        public string Read()
        {
            using (StreamReader jsonFile = File.OpenText(this.FilePath))
            using (JsonTextReader reader = new JsonTextReader(jsonFile))
            {
                var jsonContent = (JObject)JToken.ReadFrom(reader);

                return jsonContent.ToString();
            };
        }
    }
}