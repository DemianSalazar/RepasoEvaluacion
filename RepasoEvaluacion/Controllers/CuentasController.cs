using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepasoEvaluacion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoEvaluacion.Controllers
{
    public class CuentasController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CuentasController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: CuentasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CuentasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuentasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CuentasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CuentasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CuentasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CuentasController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
