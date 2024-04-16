using System.Web.Mvc;

namespace WebMVCRouting.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var products = new[]
            {
                new {ProductID=101,ProductName="Mobile" },
               new  {ProductID=102,ProductName="Laptop" },
               new  {ProductID=103,ProductName="Tablet" },
               new {ProductID=104,ProductName="Ipod" }
            };
            return View(products);
        }
        public ActionResult Details(int? productID)
        {
            var products = new[]
            {
                new {ProductID=101,ProductName="Mobile" }               
            };
            return View(products);
        }
        public ActionResult Add()
        {
            return View();
        }
    }
}