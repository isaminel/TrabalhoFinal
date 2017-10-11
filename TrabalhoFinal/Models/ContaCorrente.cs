using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinal.Models
{
    public class ContaCorrente
    {
        public int Id { get; set; }

        [Display(Name = "Agencia")]
        public string Agencia { get; set; }

        [Display(Name = "Titular")]
        public string Titular { get; set; }

        [Display(Name = "NrConta")]
        public int NrConta { get; set; }
    }
}