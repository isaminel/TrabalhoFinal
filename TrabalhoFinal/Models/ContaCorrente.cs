﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoFinal.Models
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public int NrConta { get; set; }
    }
}