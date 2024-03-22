using System.Diagnostics.Contracts;
using System.Linq;
using System.Web.Mvc;

namespace MVCControllers.Controllers
{
    public class ProductController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View("Sample");
        }
        public ContentResult GetEmpName(int id)
        {
            //Anonymous Types
            var employees = new[]
            {
                new {EmpID=101,EmpName="Srikanth",Salary=12345 },
                new {EmpID=102,EmpName="Scott",Salary=23658 },
                new {EmpID=103,EmpName="Madhu",Salary=85478 },
                new {EmpID=104,EmpName="Prasad",Salary=96587 }
            };
            string empName = string.Empty;
            foreach (var item in employees)
            {
                if(item.EmpID == id)
                {
                    empName = item.EmpName;
                }
            }
            if(!string.IsNullOrWhiteSpace(empName))
            {
                return Content(empName);
            }
            else
            {
                return Content("No Employee Found");
            }
        }
        public FileResult GetFile(int id)
        {
            string fileName = "~/Images/image" + id + ".jpg";
            return File(fileName,"image/jpg");
        }
        public RedirectResult GotoGoogle()
        {
            return Redirect("http://www.google.com");
        }

        public ActionResult GetStudentResult()
        {
            double[] marks = {63,96,45,85,23,74 };
            bool result = StudentResult(marks);
            if(result == true)
            {
                return Content("Student Pass");
            }
            else
            {
                return Content("Student Failed");
            }
            
        }
        [NonAction]
        public bool StudentResult(double[] marks)
        {
            foreach (var item in marks)
            {
                if(item < 35)
                {
                    return false;
                }
            }
            return true;
        }

        public ActionResult GetProductName(int id)
        {
            var products = new[]
            {
                new {ID=1,Name="Mobile"},
                new {ID=2,Name="Laptop"},
                new {ID=3,Name="Desktop"},
                new {ID=4,Name="XBox 360"},
            };
            var isAvailble = products.Where(x => x.ID == id).FirstOrDefault().Name;
            if (!string.IsNullOrWhiteSpace(isAvailble))
                return RedirectToAction("Index");
            else
                return Content("Product is Not Available");

        }

    }
}