using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Controllers
{
    public class GerenteController : Controller
    {
        // GET: Gerente
        public ActionResult Index()
        {
            var gerente = new Gerente
            {
                Nome = "",
                Cpf = ""
            };

            return View(gerente);
        }
    }
}