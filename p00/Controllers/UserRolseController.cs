using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace p00.Controllers
{
    public class UserRolseController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: UserRolse
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserRolse/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserRolse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserRolse/Create
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

        // GET: UserRolse/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserRolse/Edit/5
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

        // GET: UserRolse/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserRolse/Delete/5
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
