using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;
using TrabalhoFinal.ViewModels;

namespace TrabalhoFinal.Controllers
{
    public class OperacaoController : Controller
    {
        public List<Operacao> Operacoes = new List<Operacao>
        {
            new Operacao {NomeOperacao = "Sacar", Id = 6, Valor = 500, NrContaDestino = 147854},
            new Operacao {NomeOperacao = "Depositar", Id = 6, Valor = 1000, NrContaDestino = 36633}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new OperacaoIndexViewModel
            {
                Operacoes = Operacoes
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Operacoes.Count < id)
            {
                return HttpNotFound();
            }

            var operacao = Operacoes[id - 1];

            return View(operacao);
        }
    }
}