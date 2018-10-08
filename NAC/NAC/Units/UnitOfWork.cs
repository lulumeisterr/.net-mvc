using NAC.Persistencia;
using NAC.Repositories.DAO;
using NAC.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAC.Units
{
    //Gerenciador de DBContext
    public class UnitOfWork
    {

        private AllPersistencia _context = new AllPersistencia();

        //Chamar as Interfaces

        private IAlunoRepository _alunoRepository;
       
        public IAlunoRepository AlunoRepository
        {
            get
            {
                if(_alunoRepository == null)
                {
                    _alunoRepository = new AlunoDAO(_context);
                }
                return _alunoRepository;
            }
        }

        //=================================


        private ITurmaRepository _turmaRepository;

        //Chamar a interfaces

        public ITurmaRepository TurmaRepository
        {
            get
            {
                if(_turmaRepository == null)
                {
                    _turmaRepository = new TurmaDAO(_context);
                }
                return _turmaRepository;
            }
        }

        //================================

        //Commitando
        public void Salvar()
        {
            _context.SaveChanges();
        }

        //================================

        // Fechando a conexao
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}