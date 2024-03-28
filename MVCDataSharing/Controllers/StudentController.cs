using System.Web.Mvc;

namespace MVCDataSharing.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            ViewData["StudentID"] = 101;
            ViewData["StudentName"] = "Srikanth";
            ViewData["Marks"] = new int[] { 65, 85, 69, 85, 41, 35 };
            return View();
        }
        public ActionResult Index1()
        {
            ViewBag.StudentID = 101;
            ViewBag.StudentName = "Srikanth";
            ViewBag.Marks = new int[] { 65, 85, 69, 85, 41, 35 };
            return View();
        }
    }
}