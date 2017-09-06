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
    public class ClienteController : Controller
    {

        /*public List<Cliente> Clientes = new List<Cliente>
        {
            new Cliente {Nome = "Julia Nascimento", Id = 1, Cpf = "154.987.885-69"},
            new Cliente {Nome = "Camila Maas", Id = 2, Cpf = "544.001.878-31"}
        };*/

        // GET: Customers

        private ApplicationDbContext _context;

        public ClienteController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var clientes = _context.Clientes.Include(c => c.MembershipType).ToList();
            return View(clientes);
        }
            
        public ActionResult Details(int id)
        {
            var cliente = _context.Clientes.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

    }
}