using MVCDataSharing.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCDataSharing.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            //Step-1
            List<Emp> emps = EmpDataContext.GetEmployees();
            //Step-2
            return View(emps);
        }
        public ActionResult Index1()
        {
            //Step-1
            string[] courses = {"C#.Net","ASP.Net","MVC","MVC Core","Entity Framework" };
            //Step-2
            return View(courses);
        }
    }
}