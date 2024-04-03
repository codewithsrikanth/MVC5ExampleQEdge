using DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotations.Controllers
{
    public class AccountController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Msg = "Registration Succeded";
            }
            else
            {
                ViewBag.Msg = "Registration Failed";
            }
            
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Register model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Msg = "Registration Succeded";
            }
            else
            {
                ViewBag.Msg = "Registration Failed";
            }

            return View();
        }
    }
}