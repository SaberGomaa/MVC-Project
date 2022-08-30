﻿using MVC_Project.Models;
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

        public ActionResult create()
        {
            List<department> dept = context.departments.ToList();

            SelectList st = new SelectList(dept  , "id", "name");

            ViewBag.st = st;

            return View();
        }
        [HttpPost]
        public ActionResult create(student s, HttpPostedFileBase photo)
        {
            if (!ModelState.IsValid)
            {
                photo.SaveAs(Server.MapPath("~/attach/" + photo.FileName));

                s.img = photo.FileName;
                context.students.Add(s);
                context.SaveChanges();

                return RedirectToAction("display");
            }
            else
            {
                List<department> dept = context.departments.ToList();

                SelectList st = new SelectList(dept, "id", "name");

                ViewBag.st = st;

                return View(s);
            }
        }

        public ActionResult details(int id)
        {
            student s = context.students.Find(id);

            return View(s);
        }

        public ActionResult edit(int id)
        {
            List<department> dept = context.departments.ToList();

            SelectList st = new SelectList(dept, "id", "name");

            ViewBag.st = st;
            student s = context.students.Find(id);

            return View(s);
        }

    }

}