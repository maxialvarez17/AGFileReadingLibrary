using FileReadingLibrary.DataTransferObjects.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileReadingLibrary.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            var fileDTOs = new List<FileDTO>();

            return View(fileDTOs);
        }
    }
}