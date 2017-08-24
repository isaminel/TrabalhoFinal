using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;
using TrabalhoFinal.ViewModels;

namespace TrabalhoFinal.Controllers
{
    public class ClienteController : Controller
    {

        public List<Cliente> Clientes = new List<Cliente>
        {
            new Cliente {Nome = "Julia Nascimento", Id = 1, Cpf = "154.987.885-69"},
            new Cliente {Nome = "Camila Maas", Id = 2, Cpf = "544.001.878-31"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new ClienteIndexViewModel
            {
                Clientes = Clientes
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Clientes.Count < id)
            {
                return HttpNotFound();
            }

            var cliente = Clientes[id - 1];

            return View(cliente);
        }

    }
}