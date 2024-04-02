using CodeFirstEF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CodeFirstEF.Controllers
{
    public class HomeController : Controller
    {
        CompanyDBEntities dbContext = new CompanyDBEntities();
        public ActionResult Index()
        {
            EmpDeptViewModel model = new EmpDeptViewModel();
            model.Emps =  dbContext.Employees.ToList();
            model.Depts =  dbContext.Depts.ToList();
            return View(model);
        }
    }
}