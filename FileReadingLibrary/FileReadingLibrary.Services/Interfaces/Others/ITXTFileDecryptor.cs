namespace FileReadingLibrary.Services.Interfaces.Others
{
    public interface ITXTFileDecryptor
    {
        string Decrypt(string[] fileLines);
    }
}