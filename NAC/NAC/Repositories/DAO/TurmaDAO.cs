using NAC.Models;
using NAC.Persistencia;
using NAC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace NAC.Repositories.DAO
{
      //Chamar a interface
    public class TurmaDAO : ITurmaRepository
    {

        //Chamar o Persiste

        private AllPersistencia _context;

        //==============================================================

        // Criar o construtor e passar o context

        
        public TurmaDAO(AllPersistencia contexto)
        {
            _context = contexto;
        }

        //===============================================================

        // Atualizando

        public void Atualizar(Turma turma)
        {
            _context.Entry(turma).State = EntityState.Modified;
        }

        //===============================================================
        
        public IList<Turma> BuscarPor(Expression<Func<Turma, bool>> filtro)
        {
            return _context.Turmas.Where(filtro).ToList();
        }

        //===============================================================

        //Buscando por Codigo

        public Turma BuscarPorCodigo(int codigo)
        {
            return _context.Turmas.Find(codigo);
        }

        //===============================================================
        // Cadastrando
        public void Cadastrar(Turma turma)
        {
            _context.Turmas.Add(turma);
        }

        //===============================================================
        // Listando
        public IList<Turma> Listar()
        {
            return _context.Turmas.ToList();
        }

        //===============================================================
        //Removendo
        public void Remover(int codigo)
        {
            var turma = BuscarPorCodigo(codigo);
            _context.Turmas.Remove(turma);
        }
    }
}