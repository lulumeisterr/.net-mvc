using NAC.Models;
using NAC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAC.Controllers
{
    public class TurmaController : Controller
    {
        //====================================================================
        //Chamando o orquestrador de persistencia
        private UnitOfWork _units = new UnitOfWork();
        //====================================================================

        //Cadastrando uma Turma

        [HttpGet]
        // GET: Turma
        public ActionResult CadastrarTurma()
        {

            return View();
        }

        [HttpPost]

        public ActionResult CadastrarTurma(Turma turma)
        {
            _units.TurmaRepository.Cadastrar(turma);
            _units.Salvar();
            //Mandar a msg
            TempData["msg"] = "Turma Cadastrada";
            return RedirectToAction("CadastrarTurma");
        }

        //===================================================================

    }
}