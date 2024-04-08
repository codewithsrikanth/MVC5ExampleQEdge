using LinqToSqlMVCDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace LinqToSqlMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private CompanyDBDataContext dbContext = new CompanyDBDataContext("server=.;database=CompanyDB;integrated security=true;");
        // GET: Home
        public ActionResult Index()
        {
            //List<Employee> emps =  dbContext.Employees.ToList();
            var emps = (from emp in dbContext.Employees select emp).ToList();
            //var emps = from emp in dbContext.Employees where emp.Ename.StartsWith("S") select emp;
            return View(emps);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            var empDetails = (from emp in dbContext.Employees where emp.Eno == id select emp).FirstOrDefault();
            return View(empDetails);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                dbContext.Employees.InsertOnSubmit(emp);
                dbContext.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            var empDetails = (from emp in dbContext.Employees where emp.Eno == id select emp).FirstOrDefault();
            return View(empDetails);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                Employee empExistingRecord = (from x in dbContext.Employees where x.Eno == id select x).FirstOrDefault();
                empExistingRecord.Ename = emp.Ename;
                empExistingRecord.Job = emp.Job;
                empExistingRecord.Salary = emp.Salary;
                empExistingRecord.DeptID = emp.DeptID;
                dbContext.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            var empDetails = (from emp in dbContext.Employees where emp.Eno == id select emp).FirstOrDefault();
            return View(empDetails);
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee x)
        {
            try
            {
                var empDetails = (from emp in dbContext.Employees where emp.Eno == id select emp).FirstOrDefault();
                dbContext.Employees.DeleteOnSubmit(empDetails);
                dbContext.SubmitChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
