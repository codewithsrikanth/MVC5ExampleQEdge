using MVCWithADO.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCWithADO.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDataContext _context;
        public EmployeeController()
        {
            _context = new EmployeeDataContext();
        }
        public ActionResult Index()
        {
            List<Employee> employees =  _context.GetEmployees();
            return View(employees);
        }
        public ActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            int  i = _context.InsertEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Msg = "Record Not Inserted";
                return View();
            }           
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Employee emp = _context.GetEmployee(id);
            return View(emp);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Employee emp = _context.GetEmployee(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Update(Employee emp)
        {
            int i = _context.UpdateEmp(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Msg = "Record Not Updated";
                return View();
            }
        }
    }
}