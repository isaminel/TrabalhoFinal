using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.ViewModels
{
    public class ContaCorrenteIndexViewModel
    {
        public List<ContaCorrente> ContasCorrente { get; set; }

        public ContaCorrente ContaCorrente { get; set; }
        public string Title
        {
            get
            {
                if (ContaCorrente != null && ContaCorrente.Id != 0)
                    return "Editar Conta Corrente";

                return "Nova Conta Corrente";
            }
        }
    }
}