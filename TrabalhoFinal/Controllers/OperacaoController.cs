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
        /*public List<Operacao> Operacoes = new List<Operacao>
        {
            new Operacao {NomeOperacao = "Sacar", Id = 1, Valor = 500, NrContaDestino = 147854},
            new Operacao {NomeOperacao = "Depositar", Id = 2, Valor = 1000, NrContaDestino = 36633}
        };*/

        // GET: Customers

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
            return View(operacoes);
        }

        public ActionResult Details(int id)
        {
            var operacao = _context.Operacoes.SingleOrDefault(c => c.Id == id);

            if (operacao == null)
                return HttpNotFound();

            return View(operacao);
        }

        [HttpPost]
        public ActionResult Save(Operacao operacao)
        {
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

        public ActionResult Edit(int id)
        {
            var operacao = _context.Operacoes.SingleOrDefault(c => c.Id == id);

            if (operacao == null)
                return HttpNotFound();


            return View("OperacaoForm", operacao);
        }

    }
}