using FileReadingLibrary.Services.Interfaces.Others;
using System;
namespace FileReadingLibrary.Services.Implementations.Others
{
    public class TXTFileDecryptor : ITXTFileDecryptor
    {
        // NOTE: A simple reverse of the text
        public string Decrypt(string[] fileLines)
        {
            var encryptedValue = fileLines[0];

            char[] cArray = encryptedValue.ToCharArray();

            var decryptedValue = String.Empty;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                decryptedValue += cArray[i];
            }

            return decryptedValue;
        }
    }
}