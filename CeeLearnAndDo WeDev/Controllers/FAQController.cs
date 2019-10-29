using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CeeLearnAndDo_WeDev.Controllers
{
    public class FAQController : Controller
    {
        // GET: FAQ
        public ActionResult Index()
        {
            return View();
        }

        // GET: FAQ/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FAQ/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FAQ/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FAQ/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FAQ/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FAQ/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FAQ/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}