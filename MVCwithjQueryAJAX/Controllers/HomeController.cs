using MVCwithjQueryAJAX.Models;
using System.Linq;
using System.Web.Mvc;

namespace MVCwithjQueryAJAX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmpCount(string id)
        {
            CompanyDBEntities db = new CompanyDBEntities();
            var emps = from emp in db.Employees.ToList()
                        where emp.Dname == id 
                        select emp;
            string str = "Employee Count is: " + emps.Count();
            return Json(str,JsonRequestBehavior.AllowGet);
        }
    }
}