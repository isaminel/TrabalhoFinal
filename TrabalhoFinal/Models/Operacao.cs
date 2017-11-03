using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinal.Models
{
    public class Operacao
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nome da operação")]
        public string NomeOperacao { get; set; }

        [Required]
        [Display(Name = "Valor")]
        public double Valor { get; set; }


        [Display(Name = "Número da conta destino")]
        public int NrContaDestino { get; set; }

    }
}