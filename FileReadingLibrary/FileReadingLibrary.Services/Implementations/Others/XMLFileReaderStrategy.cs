using FileReadingLibrary.Services.Interfaces.Others;

namespace FileReadingLibrary.Services.Implementations.Others
{
    public class XMLFileReaderStrategy : IFileReaderStrategy
    {
        public string FilePath { get; set; }

        // NOTE: XML files will be displayed as stringifyed json
        public string Read()
        {
            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(this.FilePath);
            //return doc.OuterXml;

            return "This is the strategy for XML files";
        }
    }
}