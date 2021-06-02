using System.Web.Mvc;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult FileUpload()
        {
            ViewBag.Title = "File Upload";

            return View();
        }
    }
}
