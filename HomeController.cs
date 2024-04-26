using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Mvc;
using WebAPIClientApp.Models;

namespace WebAPIClientApp.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            var url = "http://localhost:56099/api/EmpApi";
            HttpResponseMessage resObj = client.GetAsync(url).Result;
            var emps = resObj.Content.ReadAsAsync<List<Employee>>().Result;
            return View(emps);
        }
        public ActionResult Details(int id)
        {
            var url = "http://localhost:56099/api/EmpApi/" + id;
            HttpResponseMessage resObj = client.GetAsync(url).Result;
            var emp = resObj.Content.ReadAsAsync<Employee>().Result;
            return View(emp);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            var url = "http://localhost:56099/api/EmpApi";
            HttpResponseMessage resObj =  client.PostAsJsonAsync<Employee>(url,emp).Result;
            var res = resObj.Content.ReadAsAsync<string>().Result;
            ViewBag.Result = res;
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var url = "http://localhost:56099/api/EmpApi/" + id;
            HttpResponseMessage resObj = client.GetAsync(url).Result;
            var emp = resObj.Content.ReadAsAsync<Employee>().Result;
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            var url = "http://localhost:56099/api/EmpApi";
            HttpResponseMessage resObj = client.PutAsJsonAsync<Employee>(url, emp).Result;
            var res = resObj.Content.ReadAsAsync<string>().Result;
            ViewBag.Result = res;
            return View();
        }
    }
}