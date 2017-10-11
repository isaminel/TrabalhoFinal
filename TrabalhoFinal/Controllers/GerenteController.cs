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
        /*public List<Gerente> Gerentes = new List<Gerente>
        {
            new Gerente {Nome = "Anderson Frare", Id = 1, Cpf = "757.998.965-10"},
            new Gerente {Nome = "Thiago Zils", Id = 2, Cpf = "665.989.778-85"}
        };*/

        // GET: Customers

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

        [HttpPost]
        public ActionResult Save(Gerente gerente)
        {
            if (gerente.Id == 0)
            {
                // armazena o cliente em memória
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