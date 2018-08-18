using _05.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05.Fiap.Web.MVC.Controllers
{

    // Simular um banco de dados
    public class ComidaController : Controller

    {

        private static List<Comida> _banco = new List<Comida>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_banco); 
        }

        // GET: Comida
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(Comida comida)
        {
            _banco.Add(comida);
            TempData["msg"] = "Comida cadastrada";
            return RedirectToAction("Listar");
        }


    }
}