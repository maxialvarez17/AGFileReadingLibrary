using FileReadingLibrary.DataTransferObjects.Entities;
using FileReadingLibrary.Services.Implementations.Services;
using FileReadingLibrary.Services.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileReadingLibrary.Controllers
{
    public class FileController : Controller
    {
        private readonly IFileService fileService;

        public FileController()
        {
            this.fileService = new FileService();
        }

        // GET: File
        public ActionResult Index()
        {
            var files = this.fileService.GetAllFiles();

            return View(files);
        }

        // GET: Flight/Read/5
        public ActionResult Read(int id)
        {
            var readFileDTO = this.fileService.ReadFile(id);

            return View(readFileDTO);
        }
    }
}