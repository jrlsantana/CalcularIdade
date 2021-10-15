using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalcularIdade.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Anos { get; set; }
    }
}