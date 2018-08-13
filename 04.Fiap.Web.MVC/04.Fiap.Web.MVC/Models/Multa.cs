using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04.Fiap.Web.MVC.Models
{
    public class Multa
    {

        public string nivel { get; set; }
        public DateTime data{ get; set; }
        public bool notificado { get; set; }
        public decimal valor { get; set; }

        public string endereco { get; set; }

        public string placa { get; set; }
    }
}