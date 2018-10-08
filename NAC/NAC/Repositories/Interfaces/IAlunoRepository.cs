using NAC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NAC.Repositories.Interfaces
{
    public interface IAlunoRepository
    {
        void Cadastrar(Aluno a);
        IList<Aluno> Listar();
        void Excluir(int codigo);
        Aluno BuscarPorCodigo(int codigo);
        IList<Aluno> BuscarPor(Expression<Func<Aluno, bool>> filtro);
    }
}
