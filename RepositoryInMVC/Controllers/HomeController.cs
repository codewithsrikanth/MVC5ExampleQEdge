using RepositoryInMVC.RepositoryLayer.Implementation;
using RepositoryInMVC.RepositoryLayer.Interfaces;
using RepositoryInMVC.RepositoryLayer.ViewModels;
using System.Web.Mvc;

namespace RepositoryInMVC.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _repository;
        public HomeController()
        {
            this._repository = new  EmployeeRepository();
        }
        public ActionResult Index()
        {
            return View(_repository.GetEmployees());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmpViewModel model)
        {
            _repository.InsertEmployee(model);
            return RedirectToAction("Index");
        }
    }
}