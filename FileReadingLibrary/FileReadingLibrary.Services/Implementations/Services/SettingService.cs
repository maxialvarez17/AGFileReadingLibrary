using FileReadingLibrary.Data.Implementations.Repositories;
using FileReadingLibrary.Data.Interfaces.Repositories;
using FileReadingLibrary.DataTransferObjects.Settings;
using FileReadingLibrary.Model.Entities;
using FileReadingLibrary.Model.Entities.Security;
using FileReadingLibrary.Services.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileReadingLibrary.Services.Implementations.Services
{
    public class SettingService : ISettingService
    {
        private readonly IRepository<FileReadingLibrarySettings> fileReadingLibrarySettingsRepository;
        private readonly IReadOnlyRepository<User> userRepository;

        public SettingService()
        {
            this.fileReadingLibrarySettingsRepository = new FileReadingLibrarySettingsRepository();
            this.userRepository = new UserRepository();
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            return this.userRepository.GetAll()
                .Select(x => new UserDTO()
                {
                    Id = x.Id,
                    Username = x.Username
                });
        }

        public void SaveSettings(ApplicationSettingsDTO applicationSettingsDTO)
        {
            var fileReadingLibrarySettings = new FileReadingLibrarySettings()
            {
                LoggedUserId = applicationSettingsDTO.UserId
            };

            this.fileReadingLibrarySettingsRepository.Update(fileReadingLibrarySettings);
        }
    }
}