using FileUpload.EFEntities;
using FileUpload.Models;
using System;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FileUpload.Controllers
{
    public class FileUploadController : ApiController
    {
        FileUploadDBEntities DBContext = new FileUploadDBEntities();

        public IHttpActionResult GetFileUploadList()
        {
            var fileList = (from fileUpload in DBContext.FileUploads
                           from userDetail in DBContext.UserDetails
                           where fileUpload.FileUploadedUserId == userDetail.UserId
                           select new FileUploadModel
                           {
                               FileName = fileUpload.FileName,
                               UserName = userDetail.UserName
                           }).ToList();
            return Json(fileList);
        }

        public IHttpActionResult UploadFileInDB()
        {
            try
            {
                if (HttpContext.Current.Request.Files.AllKeys.Any())
                {
                    var fileDetails = HttpContext.Current.Request.Files[0];
                    if (fileDetails.FileName != null)
                    {
                        var model = new EFEntities.FileUpload()
                        {
                            FileUploadedUserId = 1, // User can be change from here
                            FileName = fileDetails.FileName
                        };
                        DBContext.FileUploads.Add(model);
                        DBContext.SaveChanges();
                    }
                }
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
