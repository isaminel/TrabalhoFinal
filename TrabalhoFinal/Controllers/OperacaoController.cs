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
    public class OperacaoController : Controller
    {
        
        private ApplicationDbContext _context;

        public OperacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        
        public ActionResult Index()
        {
            var operacoes = _context.Operacoes.ToList();
            if (User.IsInRole(RoleName.CanManageCustomers))
                return View(operacoes);
            return View("ReadOnlyIndex", operacoes);
        }

        [Authorize(Roles = RoleName.CanManageCustomers)]

        public ActionResult New()
        {
            var operacao = new Operacao();

            return View("OperacaoForm", operacao);
        }

        public ActionResult Details(int id)
        {
            var operacao = _context.Operacoes.SingleOrDefault(c => c.Id == id);

            if (operacao == null)
                return HttpNotFound();

            return View(operacao);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult Save(Operacao operacao)
        {
            if (!ModelState.IsValid)
            {
                return View("OperacaoForm", operacao);
            }
            if (operacao.Id == 0)
            {
                
                _context.Operacoes.Add(operacao);
            }
            else
            {
                var operacaoInDb = _context.Operacoes.Single(c => c.Id == operacao.Id);

                operacaoInDb.NomeOperacao = operacao.NomeOperacao;
                operacaoInDb.Valor = operacao.Valor;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult Edit(int id)
        {
            var operacao = _context.Operacoes.SingleOrDefault(c => c.Id == id);

            if (operacao == null)
                return HttpNotFound();


            return View("OperacaoForm", operacao);
        }

        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult Delete(int id)
        {
            var operacao = _context.Operacoes.SingleOrDefault(c => c.Id == id);

            if (operacao == null)
                return HttpNotFound();

            _context.Operacoes.Remove(operacao);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}

    