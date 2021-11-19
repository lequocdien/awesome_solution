using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net.Http.Headers;

namespace UploadFile.Controllers
{
    [ApiController]
    [Route("file-manager")]
    public class FileManagerController : ControllerBase
    {
        [HttpPost]
        [Route("upload")]
        public IActionResult Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                //var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                var pathToSave = @"C:\Users\lequo\Desktop\ServerImage";
                if (file.Length > 0)
                {
                    var fileName = String.Format("{0}_{1}_{2}", "support-request", DateTime.Now.ToString("yyyyMMddHHmmss"), ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"'));
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new {
                        uploaded = true,
                        url = String.Format("http://127.0.0.1:8080/{0}", fileName)
                        //url = "http://112.78.1.106:9002/assets/images/carousel/shutterstock_116494663_huge.jpg"
                    });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
