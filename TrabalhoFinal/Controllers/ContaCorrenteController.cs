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
    public class ContaCorrenteController : Controller
    {
        /*public List<ContaCorrente> ContasCorrente = new List<ContaCorrente>
        {
            new ContaCorrente {Agencia = "Bradesco", Id = 1, Titular = "Julia Nascimento", NrConta = 35556},
            new ContaCorrente {Agencia = "Caixa", Id = 2, Titular = "Camila Maas", NrConta = 85870}
        };*/

        // GET: Customers

        private ApplicationDbContext _context;

        public ContaCorrenteController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var contas = _context.ContasCorrente.Include(c => c.MembershipType).ToList();
            return View(contas);
        }

        public ActionResult Details(int id)
        {
            var conta = _context.ContasCorrente.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (conta == null)
                return HttpNotFound();

            return View(conta);
        }

    }
}