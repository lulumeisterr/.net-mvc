using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap06.Wbe.MVC.Models
{
    public class Produto
    {
        [Column]
        public int ProdutoId { get; set; }
    }
}