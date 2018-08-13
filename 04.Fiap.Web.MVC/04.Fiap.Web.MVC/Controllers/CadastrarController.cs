using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _04.Fiap.Web.MVC.Models;

namespace _04.Fiap.Web.MVC.Models
{
    public class CadastrarController : Controller
    {
        // GET: Cadastrar
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost] // Recupera os dados e bd
        public ActionResult Index(Multa multa)
        {
            ViewBag.qualquerValor = multa.placa;

            // TempData sobrevive á um redirect
            TempData["msg"] = "Multa cadastrada";

            //Tipando a view Voce pode referenciar @model e acessar os atributos da classe
            // Retornando a mesma tela
            return View(multa);
        }
    }
}