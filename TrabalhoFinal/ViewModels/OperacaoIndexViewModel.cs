using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabalhoFinal.Models;

namespace TrabalhoFinal.ViewModels
{
    public class OperacaoIndexViewModel
    {
        public List<Operacao> Operacoes { get; set; }

        public Operacao Operacao { get; set; }
        public string Title
        {
            get
            {
                if (Operacao != null && Operacao.Id != 0)
                    return "Editar Operação";

                return "Nova Operação";
            }
        }
    }
}