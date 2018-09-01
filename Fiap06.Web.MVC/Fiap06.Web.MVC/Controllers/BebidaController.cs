using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class BebidaController : Controller
    {
        private BotecoContext _context = new BotecoContext();

        // Realizando a pesquisa

        [HttpGet]

        public ActionResult Pesquisar(string nome)
        {
           var lista = _context.Bebidas.Where(e => e.Nome.Contains(nome)).ToList();
           //Retornando para a pagina listar com a lista de bebida
          return View("Listar",lista);
        }
     
        [HttpPost]
        public ActionResult Atualizar(Bebida bebida)
        {
            //Atualiza o banco de dados
            _context.Entry(bebida).State = EntityState.Modified;
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Bebida Atualizada!";
            //Redirecionar
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Atualizar(int id)
        {
            //Busca a bebida no banco de dados
            var bebida = _context.Bebidas.Find(id);
            //Retorna a view com o objeto bebida
            return View(bebida);
        }


        // Removendo , devo mandar um ID para a pagina que lista 
        // Utilizar o Post para privatizar a url

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            // context é a classe contem as coleções para realizar o crud
            var bebida = _context.Bebidas.Find(id);
            _context.Bebidas.Remove(bebida);

            // Realizando o commit
            _context.SaveChanges();

            //Mandando msg
            TempData["msg"] = "Bebida Removida";
            return RedirectToAction("Listar");
        }

        // Listar

        [HttpGet]
        public ActionResult Listar()
        {
            //Recupera todas as bebidas e envia para a tela
            return View(_context.Bebidas.ToList());
        }


        // Exibindo

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        // Cadastrando

        [HttpPost]
        public ActionResult Cadastrar(Bebida bebida)
        {
            _context.Bebidas.Add(bebida);
            _context.SaveChanges();
            TempData["msg"] = "Bebida Cadastrada!";
            return RedirectToAction("Cadastrar");
        }




    }
}