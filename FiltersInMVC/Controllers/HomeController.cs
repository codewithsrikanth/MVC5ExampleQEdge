using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Web.Mvc;

namespace FiltersInMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CurrentTime = DateTime.Now.ToString();
            return View();
        }
        [HttpPost]
        [OutputCache(Duration = 120, VaryByParam = "Eno")]
        public ActionResult Index(int? id)
        {
            ViewBag.UpdatedTime = DateTime.Now.ToString();
            return View();
        }

        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index1(string empName)
        {
            ViewBag.EmpName = empName;
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        [HandleError(View = "_Error")]
        public ActionResult Index2(string sb1)
        {
            SqlConnection con = new SqlConnection("server=.;database=Company;integrated security=true;");
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
                ViewBag.Msg = "Connection Opened";
            }
            else
            {
                ViewBag.Msg = "Connection was already Opened";
            }
            con.Close();
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username,string password)
        {
            return View();
        }
    }
}