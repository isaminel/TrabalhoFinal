using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente()
            {
                Nome = "José",
                Cpf = "784.659.999-89"
            };

            return View(cliente);
        }
    }
}