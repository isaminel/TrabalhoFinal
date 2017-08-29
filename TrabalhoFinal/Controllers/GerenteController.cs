using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;
using TrabalhoFinal.ViewModels;

namespace TrabalhoFinal.Controllers
{
    public class GerenteController : Controller
    {
        public List<Gerente> Gerentes = new List<Gerente>
        {
            new Gerente {Nome = "Anderson Frare", Id = 1, Cpf = "757.998.965-10"},
            new Gerente {Nome = "Thiago Zils", Id = 2, Cpf = "665.989.778-85"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new GerenteIndexViewModel
            {
                Gerentes = Gerentes
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Gerentes.Count < id)
            {
                return HttpNotFound();
            }

            var gerente = Gerentes[id - 1];

            return View(gerente);
        }
    }
}