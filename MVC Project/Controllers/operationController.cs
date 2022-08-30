using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class operationController : Controller
    {
        MVCContext context = new MVCContext();
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(logindata login)
        {
            student s = context.students.Where(l => l.Email == login.email && l.password == login.password).FirstOrDefault();

            if (s != null)
            {
                Session.Add("userid", s.id);
                return RedirectToAction("details", "students", new { id = s.id });
            }
            else
            {
                ViewBag.msg = "incorrect username or password";
                return View();
            }
        }


        public ActionResult logout()
        {
            return RedirectToAction("login");
        }

    }
}