using NAC.Models;
using NAC.Persistencia;
using NAC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace NAC.Repositories.DAO
{
    // Chamar a interface

    public class AlunoDAO : IAlunoRepository
    {


        //Passar a persitencia para persistir nos metodos chamando o pacote Persistencia

        private AllPersistencia _context;

        //=========================================================

        // Construtor
        public AlunoDAO(AllPersistencia contexto)
        {
            _context = contexto;
        }

        //=========================================================

        //=========================================================
        //Cadastrando
        public void Cadastrar(Aluno a)
        {
            _context.Alunos.Add(a);

        }
        //=========================================================
        //Listando

        public IList<Aluno> Listar()
        {
            return _context.Alunos.Include("Turma").ToList();
        }

        //=========================================================
        //Buscando
        public Aluno BuscarPorCodigo(int codigo)
        {
            return _context.Alunos.Find(codigo);
   
        }

        //=========================================================
        //Excluindo
        public void Excluir(int codigo)
        {
            var excluindoAll = BuscarPorCodigo(codigo);
            _context.Alunos.Remove(excluindoAll);
        }

        public IList<Aluno> BuscarPor(Expression<Func<Aluno, bool>> filtro)
        {
            return _context.Alunos.Where(filtro).ToList();
        }
    }
}