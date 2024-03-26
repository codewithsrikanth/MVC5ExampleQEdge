using System.Reflection.Emit;
using System.Web.Mvc;

namespace MVCDataSharing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1(int stdNo,string stdName)
        {
            return View();
        }
        public ActionResult Index2(int stdNo, string stdName)
        {
            return View();
        }
        public ActionResult Index3(int stdNo, string stdName)
        {
            Response.Write("Student No is: " + stdNo);
            Response.Write("Student Name is: " + stdName);
            return View();
        }

        public ActionResult Index4(string id)
        {
            return View();
        }
    }
}