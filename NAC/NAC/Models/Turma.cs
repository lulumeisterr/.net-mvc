using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAC.Models
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public string nome { get; set; }

        //1:M
        public IList<Aluno> Alunos { get; set; }
    }
}