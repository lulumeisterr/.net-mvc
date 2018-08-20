using _05_MVC_Praticando.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05_MVC_Praticando.Controllers
{
    public class OficinaController : Controller
    {

        // Criando lista dinamica

        private static List<Oficina> _office = new List<Oficina>();

       
        [HttpGet]
        public ActionResult RetornoLista()
        {
            return View(_office);
        }

        // GET: Oficina
        [HttpGet]
        public ActionResult Index()
        {
            List<string> tipos = new List<string>();
            tipos.Add("PAPUM PIRULITO");
            tipos.Add("SEILA PIRULITO");
            tipos.Add("TRETA PIRULITO");

            // ENVIAR A LISTA DE TIPOS PARA A TELA EXIBIR O SELECT

            ViewBag.ListarSelect = new SelectList(tipos);

            return View();
        }

        // Retornando a Lista

     
        // Cadastrando
        [HttpPost]

        public ActionResult Index(Oficina oficina)
        {
            _office.Add(oficina);
            TempData["msg"] = "Comida cadastrada";

            // Redirect para nao realizar uma novo cadastro no f5
            return RedirectToAction("RetornoLista");
        }


    }
}