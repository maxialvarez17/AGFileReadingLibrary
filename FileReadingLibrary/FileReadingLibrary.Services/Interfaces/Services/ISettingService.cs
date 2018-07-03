using FileReadingLibrary.DataTransferObjects.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Interfaces.Services
{
    public interface ISettingService
    {
        IEnumerable<UserDTO> GetUsers();

        void SaveSettings(ApplicationSettingsDTO applicationSettingsDTO);
    }
}