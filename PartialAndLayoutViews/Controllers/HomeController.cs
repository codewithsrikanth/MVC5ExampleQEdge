using PartialAndLayoutViews.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PartialAndLayoutViews.Controllers
{
    public class HomeController : Controller
    {
        private CompanyDBEntities dbContext = new CompanyDBEntities();
        public ActionResult Index()
        {
            List<Employee> emps =  dbContext.Employees.ToList();
            return View(emps);
        }
        public ActionResult EmpData()
        {
            List<Employee> emps = dbContext.Employees.ToList();
            return View(emps);
        }
        public ActionResult GetSingleEmp()
        {
            Employee emp = dbContext.Employees.Find(101);
            return View(emp);
        }
    }
}