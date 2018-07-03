using FileReadingLibrary.DataTransferObjects.Settings;
using FileReadingLibrary.Services.Implementations.Services;
using FileReadingLibrary.Services.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileReadingLibrary.Controllers
{
    public class SettingController : Controller
    {
        private readonly ISettingService settingService;

        public SettingController()
        {
            this.settingService = new SettingService();
        }

        // GET: Setting/Index
        public ActionResult Start()
        {
            var applicationSettingsDTO = new ApplicationSettingsDTO();

            ViewBag.Users = this.settingService.GetUsers()
                .Select(x => new SelectListItem()
                {
                    Text = x.Username,
                    Value = x.Id.ToString()
                });

            return View(applicationSettingsDTO);
        }

        // POST: Setting/Submit
        [HttpPost]
        public ActionResult Start(ApplicationSettingsDTO applicationSettingsDTO)
        {
            try
            {
                this.settingService.SaveSettings(applicationSettingsDTO);

                return RedirectToAction("Index", "File");
            }
            catch
            {
                return View();
            }

            
        }
    }
}