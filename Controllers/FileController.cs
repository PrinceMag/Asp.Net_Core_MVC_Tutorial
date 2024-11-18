using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Asp.Net_Core_MVC.Controllers
{
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public FileResult Show()
        {
            var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "Content", "myFile.txt");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/plain");
        }

        public FileResult Download()
        {
            var filePath = Path.Combine(_webHostEnvironment.ContentRootPath, "Content", "myFile.txt");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "text/plain","MVC5.txt");
        }
    }
}
