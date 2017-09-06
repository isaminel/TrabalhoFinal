﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoFinal.Models
{
    public class Operacao
    {
        public int Id { get; set; }
        public string NomeOperacao { get; set; }
        public double Valor { get; set; }
        public int NrContaDestino { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}