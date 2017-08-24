using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;
using TrabalhoFinal.ViewModels;

namespace TrabalhoFinal.Controllers
{
    public class ContaCorrenteController : Controller
    {
        public List<ContaCorrente> ContasCorrente = new List<ContaCorrente>
        {
            new ContaCorrente {Agencia = "Bradesco", Id = 1, Titular = "Maria", NrConta = 35556},
            new ContaCorrente {Agencia = "Caixa", Id = 2, Titular = "João", NrConta = 85870}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new ContaCorrenteIndexViewModel
            {
                ContasCorrente = ContasCorrente
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (ContasCorrente.Count < id)
            {
                return HttpNotFound();
            }

            var contas = ContasCorrente[id - 1];

            return View(contas);

        }
    }
}