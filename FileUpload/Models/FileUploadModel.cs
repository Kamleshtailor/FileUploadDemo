using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileUpload.Models
{
    public class FileUploadModel
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string UserName { get; set; }
        public int FileUploadedUserId { get; set; }

    }
}