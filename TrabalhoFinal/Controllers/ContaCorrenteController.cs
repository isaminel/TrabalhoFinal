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
    public class ContaCorrenteController : Controller
    {
        private ApplicationDbContext _context;

        public ContaCorrenteController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var contas = _context.ContasCorrente.ToList();
            return View(contas);
        }

        public ActionResult Details(int id)
        {
            var conta = _context.ContasCorrente.SingleOrDefault(c => c.Id == id);

            if (conta == null)
                return HttpNotFound();

            return View(conta);
        }

        public ActionResult New()
        {
            var conta = new ContaCorrente();

            return View("ContaCorrenteForm", conta);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(ContaCorrente conta)
        {
            if (!ModelState.IsValid)
            {
                return View("ContaCorrenteForm", conta);
            }
            if (conta.Id == 0)
            {

                _context.ContasCorrente.Add(conta);
            }
            else
            {
                var contaInDb = _context.ContasCorrente.Single(c => c.Id == conta.Id);

                contaInDb.Agencia = conta.Agencia;
                contaInDb.Titular = conta.Titular;
                contaInDb.NrConta = conta.NrConta;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var conta = _context.ContasCorrente.SingleOrDefault(c => c.Id == id);

            if (conta == null)
                return HttpNotFound();


            return View("ContaCorrenteForm", conta);
        }

    }
}