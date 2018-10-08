using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NAC.Models
{
    public class Aluno
    {

        public int AlunoId { get; set; }
        public string nome { get; set; }
        public bool Aprovado { get; set; }

        //Relacionamento
        //FK
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }

    }
}