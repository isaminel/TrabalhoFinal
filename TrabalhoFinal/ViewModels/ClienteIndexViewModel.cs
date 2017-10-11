using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.ViewModels
{
    public class ClienteIndexViewModel
    {
        public List<Cliente> Clientes { get; set; }

        public Cliente Cliente { get; set; }
        public string Title
        {
            get
            {
                if (Cliente != null && Cliente.Id != 0)
                    return "Editar Cliente";

                return "Novo Cliente";
            }
        }
    }
}