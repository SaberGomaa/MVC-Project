using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class studentsController : Controller
    {
        MVCContext  context = new MVCContext();
        public ActionResult display()
        {
            List<student> students = context.students.ToList();

            return View(students);
        }
    }
}