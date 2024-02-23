using FileManagers.Common;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace FileManagers.Controllers
{
    [ApiController]
    [Route("filemanager")]
    public class FileManagerController
    {
        FileManager _fm;
        public FileManagerController(IWebHostEnvironment env)
        {
            //lấy đường dẫn thư mục upload
            var wwwroot = env.WebRootPath;
            //nối chuổi để có đường dẫn thư mục upload
            var uploadPath = Path.Combine(wwwroot, "upload");


            _fm = new FileManager(uploadPath);
        }

        [Route("getalldir")]
        public string[] GetAllDirs()
        {
            return _fm.GetAllDirs();
        }
    }
}
