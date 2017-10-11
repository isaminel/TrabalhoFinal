using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.ViewModels
{
    public class GerenteIndexViewModel
    {
        public List<Gerente> Gerentes { get; set; }

        public Gerente Gerente { get; set; }
        public string Title
        {
            get
            {
                if (Gerente != null && Gerente.Id != 0)
                    return "Editar Gerente";

                return "Novo Gerente";
            }
        }
    }
}