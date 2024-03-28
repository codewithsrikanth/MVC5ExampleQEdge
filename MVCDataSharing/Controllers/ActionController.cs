using System.Web.Mvc;

namespace MVCDataSharing.Controllers
{
    public class ActionController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            if(username == "admin@gmail.com" && password == "admin@123")
            {
                TempData["Username"] = username;
                return RedirectToAction("Home");
            }
            else
            {
                ViewBag.Message = "Login Failed";
                return View();
            }
        }
        public ActionResult Home()
        {
            return View();
        }
    }
}