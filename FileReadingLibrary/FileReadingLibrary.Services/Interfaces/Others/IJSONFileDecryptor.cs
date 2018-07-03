using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Interfaces.Others
{
    public interface IJSONFileDecryptor
    {
        string Decrypt(string[] fileLines);
    }
}