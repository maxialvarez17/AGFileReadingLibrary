using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Interfaces.Others
{
    public interface IXMLFileDecryptor
    {
        string Decrypt(string[] fileLines);
    }
}