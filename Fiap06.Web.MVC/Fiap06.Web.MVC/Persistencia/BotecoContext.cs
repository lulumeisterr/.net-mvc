using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Persistencia
{
    public class BotecoContext : DbContext
    {

        // DbSet é uma coleção Onde você edita , cadastra e remove do banco ou seja como se fosse um DAO
 
        public DbSet<Bebida> Bebidas { get; set; }

        public DbSet<Petisco> Petiscos { get; set; }

    }
}