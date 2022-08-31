using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class testController : Controller
    {
        MVCContext context = new MVCContext();

        public ActionResult Index()
        {
            List<student> st = context.students.ToList();

            return PartialView(st);
        }
    }
}