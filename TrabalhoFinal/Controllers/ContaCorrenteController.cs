using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Controllers
{
    public class ContaCorrenteController : Controller
    {
        // GET: ContaCorrente
        public ActionResult Index()
        {
            var contaCorrente = new ContaCorrente()
            {
                Agencia = "Bradesco",
                Titular = "Ana",
                NrConta = 5555
            };

            return View(contaCorrente);
        }
    }
}