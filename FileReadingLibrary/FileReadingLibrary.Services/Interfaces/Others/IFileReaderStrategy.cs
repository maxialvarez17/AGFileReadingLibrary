namespace FileReadingLibrary.Services.Interfaces.Others
{
    public interface IFileReaderStrategy
    {
        string FilePath { get; set; }

        string Read();
    }
}