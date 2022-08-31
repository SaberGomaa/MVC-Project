using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class studentdeptController : Controller
    {

        MVCContext context = new MVCContext();

        public ActionResult Index()
        {
            SelectList st = new SelectList(context.departments.ToList() , "id" , "name");

            return View(st);
        }

        public ActionResult studentsindept(int id)
        {
            List<student> st = context.students.Where(n=>n.departmentid == id).ToList();
            ViewBag.st = st;
            return PartialView();
        }

    }
}