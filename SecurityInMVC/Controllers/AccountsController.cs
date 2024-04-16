using SecurityInMVC.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace SecurityInMVC.Controllers
{
    public class AccountsController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            using (SecurityDBEntities context = new SecurityDBEntities())
            {
                var isValiduser = false;
                List<User> users = context.Users.ToList();
                foreach (var item in users)
                {
                    if (item.Username == model.UserName && item.Password == model.Password)
                    {
                        isValiduser = true;
                        break;
                    }
                }

                //bool isValiduser = context.Users.Any(user=>user.Username.ToLower() == model.UserName.ToLower() && user.Password.ToLower() == model.Password.ToLower());

                if (isValiduser)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Employees");
                }
                
                ModelState.AddModelError("", "Invalid Username or Password");
                return View();
            }
        }

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(User model)
        {
            using(SecurityDBEntities context = new SecurityDBEntities())
            {
                context.Users.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Login");
        }
    }
}