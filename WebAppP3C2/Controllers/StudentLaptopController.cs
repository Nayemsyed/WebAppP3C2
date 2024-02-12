using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppP3C2.Models;

namespace WebAppP3C2.Controllers
{
    public class StudentLaptopController : Controller
    {
        // GET: StudentLaptop
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentLaptop/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentLaptop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentLaptop/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentLaptop/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentLaptop/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentLaptop/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentLaptop/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
