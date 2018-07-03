using FileReadingLibrary.Services.Interfaces.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Implementations.Others
{
    public class JSONFileDecryptor : IJSONFileDecryptor
    {
        public string Decrypt(string[] fileLines)
        {
            var encryptedValue = fileLines[0];

            var base64EncodedBytes = System.Convert.FromBase64String(encryptedValue);

            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}