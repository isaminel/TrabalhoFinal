using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinal.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Cpf")]
        public string Cpf { get; set; }
                
    }
}