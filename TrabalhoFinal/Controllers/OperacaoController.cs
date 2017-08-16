using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        public ActionResult Index()
        {
            var operacao = new Operacao()
            {
                NomeOperacao = "Sacar",
                Valor = 100,
                NrContaDestino = 123


            };

            return View(operacao);
        }
    }
}