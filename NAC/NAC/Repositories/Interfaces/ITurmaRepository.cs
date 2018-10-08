using NAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NAC.Repositories.Interfaces
{
    public interface ITurmaRepository
    {

        void Cadastrar(Turma turma);
        IList<Turma> Listar();
        Turma BuscarPorCodigo(int codigo);
        void Remover(int codigo);
        void Atualizar(Turma turma);

        //Buscar fudidao
        IList<Turma> BuscarPor(Expression<Func<Turma, bool>> filtro);

    }
}
