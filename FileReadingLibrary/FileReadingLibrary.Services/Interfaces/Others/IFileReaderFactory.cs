using FileReadingLibrary.Model.Entities;

namespace FileReadingLibrary.Services.Interfaces.Others
{
    public interface IFileReaderFactory
    {
        IFileReaderStrategy Build(FileMetadata file);
    }
}