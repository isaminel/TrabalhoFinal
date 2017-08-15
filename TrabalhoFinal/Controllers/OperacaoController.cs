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
            var operacao = new Operacao
            {
                NomeOperacao = "",
                Valor = 1,
                NrContaDestino = 1


            };

            return View(operacao);
        }
    }
}