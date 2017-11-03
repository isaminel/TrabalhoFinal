using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;
using TrabalhoFinal.ViewModels;
using System.Data.Entity;

namespace TrabalhoFinal.Controllers
{
    public class GerenteController : Controller
    {

        private ApplicationDbContext _context;

        public GerenteController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var gerentes = _context.Gerentes.ToList();
            return View(gerentes);
        }

        public ActionResult Details(int id)
        {
            var gerente = _context.Gerentes.SingleOrDefault(c => c.Id == id);

            if (gerente == null)
                return HttpNotFound();

            return View(gerente);

        }

        public ActionResult New()
        {
            var gerente = new Gerente();

            return View("GerenteForm", gerente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Gerente gerente)
        {
            if (!ModelState.IsValid)
            {
                return View("GerenteForm", gerente);
            }
            if (gerente.Id == 0)
            {

                _context.Gerentes.Add(gerente);
            }
            else
            {
                var gerenteInDb = _context.Gerentes.Single(c => c.Id == gerente.Id);

                gerenteInDb.Nome = gerente.Nome;
                gerenteInDb.Cpf = gerente.Cpf;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var gerente = _context.Gerentes.SingleOrDefault(c => c.Id == id);

            if (gerente == null)
                return HttpNotFound();


            return View("GerenteForm", gerente);
        }

    }
}