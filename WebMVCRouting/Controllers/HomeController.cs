using System.Web.Mvc;

namespace WebMVCRouting.Controllers
{
    [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("First")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("sample/{id:int}")]
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}