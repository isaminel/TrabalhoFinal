﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabalhoFinal.Models;
using TrabalhoFinal.ViewModels;

namespace TrabalhoFinal.Controllers
{
    public class ClienteController : Controller
    {
        private ApplicationDbContext _context;

        public ClienteController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var cliente = _context.Clientes.ToList();
            if (User.IsInRole(RoleName.CanManageCustomers))
                return View(cliente);
            return View("ReadOnlyIndex", cliente);
        }

        public ActionResult Details(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

        [Authorize(Roles = RoleName.CanManageCustomers)]               

        public ActionResult New()
        {
            var cliente = new Cliente();

            return View("ClienteForm", cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult Save(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View("ClienteForm", cliente);
            }
            if (cliente.Id == 0)
            {

                _context.Clientes.Add(cliente);
            }
            else
            {
                var clienteInDb = _context.Clientes.Single(c => c.Id == cliente.Id);

                clienteInDb.Nome = cliente.Nome;
                clienteInDb.Cpf = cliente.Cpf;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult Edit(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            
            return View("ClienteForm", cliente);
        }

        [Authorize(Roles = RoleName.CanManageCustomers)]
        public ActionResult Delete(int id)
        {
            var cliente = _context.Clientes.SingleOrDefault(c => c.Id == id);

            if (cliente == null)
                return HttpNotFound();

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            return new HttpStatusCodeResult(200);
        }
    }
}

    