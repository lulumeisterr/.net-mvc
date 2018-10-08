using NAC.Models;
using NAC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NAC.Controllers
{
    public class AlunoController : Controller
    {

        //Ter a instancia do gerenciador de persis Unit
        private UnitOfWork _units = new UnitOfWork();

        // Exibindo a primeira view e Cadastrando

        [HttpGet]
        // GET: Aluno
        public ActionResult Aluno()
        {
            // Carregando a lista de turmas ao iniciar a pagina
            var lista = _units.TurmaRepository.Listar();
            ViewBag.turmas = new SelectList(lista, "TurmaId", "Nome");
            return View();
        }

      

        [HttpPost]
        public ActionResult Aluno(Aluno a)
        {
            _units.AlunoRepository.Cadastrar(a);
            _units.Salvar();
            //Pàssando a MSG
            TempData["msg"] = "Aluno Cadastrado";
            return RedirectToAction("Aluno");
        }


        //========================================================================


        //Listando

        public ActionResult Listar()
        {

            //Recupera todos as bebidas e envia para a tela
            return View(_units.AlunoRepository.Listar());
        }


        //==========================================================================


        // Buscando
        [HttpGet]
        public ActionResult Pesquisar(string nome)
        {
            var lista = _units.AlunoRepository.BuscarPor(c => c.nome.Contains(nome)).ToList();
            return View("Listar", lista);
        }

        //========================================================================

        // Excluindo [Não esta funcionando]
        //Pesquisa o aluno no banco
        [HttpPost]
        public ActionResult Excluir(int id)
        {
            //Removendo o aluno do banco
            var students = _units.AlunoRepository.BuscarPorCodigo(id);
            _units.AlunoRepository.Excluir(students.AlunoId); 
            //Comito
            _units.Salvar();
            //Mensagem
            TempData["msg"] = "Aluno removido!";
            return RedirectToAction("Listar");
        }

        //========================================================================





        //Relaciondo a conexao
        protected override void Dispose(bool disposing)
        {
            _units.Dispose();
            base.Dispose(disposing);
        }

        //==================================================
    }
}