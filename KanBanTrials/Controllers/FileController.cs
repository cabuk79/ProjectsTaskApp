using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KanBanTrials.Controllers
{
    [Route("api/file")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        public FileController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        /// <summary>
        /// Downloads the selected file for the user to view
        /// </summary>
        /// <param name="fileName">the location of the file to download</param>
        /// <returns>The downloaded file</returns>
        [HttpGet("[action]")]
        public IActionResult GetFile(string fileName)
        {
            string path = Path.Combine(
                            environment.WebRootPath,
                            "files",
                            fileName);

            var stream = new FileStream(path, FileMode.Open);

            var result = new FileStreamResult(stream, "text/plain");
            result.FileDownloadName = fileName;
            return result;
        }
    }
}
