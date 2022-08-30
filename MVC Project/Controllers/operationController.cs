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
            if (Request.Cookies["mvc"] != null)
            {
                Session["userid"] = Request.Cookies["mvc"].Values["id"];
                return RedirectToAction("details", "students", new { id = Session["userid"].ToString() });
            }

            return View();
        }
        [HttpPost]
        public ActionResult login(logindata login , bool saveme)
        {
            student s = context.students.Where(l => l.Email == login.email && l.password == login.password).FirstOrDefault();

            if (s != null)
            {
                if (saveme)
                {
                    HttpCookie co = new HttpCookie("mvc");
                    co.Values.Add("id", s.id.ToString());
                    co.Values.Add("name", s.name);
                    co.Expires = DateTime.Now.AddDays(10);
                    Response.Cookies.Add(co);
                }
                Session.Add("userid", s.id);
                return RedirectToAction("details", "students", new { id = s.id });
            }
            else
            {
                ViewBag.msg = "incorrect username or password";
                return View();
            }
        }


       

    }
}