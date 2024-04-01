using EFDbFirstMVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web.Mvc;

namespace EFDbFirstMVCExample.Controllers
{
    public class HomeController : Controller
    {
        CompanyDBEntities entities = new CompanyDBEntities();
        public ActionResult Index()
        {
            List<Employee> emps = entities.Employees.ToList();
            return View(emps);
        }
        public ActionResult Create()
        {
            return View();  
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            entities.Employees.Add(emp);
            entities.SaveChanges(); //Perment Store
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            Employee emp =  entities.Employees.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            entities.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            entities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Employee emp = entities.Employees.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Delete(string id)
        {
            int eno = Convert.ToInt32(id);
            Employee emp = entities.Employees.Find(eno);
            entities.Employees.Remove(emp);
            entities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Employee emp = entities.Employees.Find(id);
            return View(emp);
        }
    }
}