using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Aluno : Pessoa

    {

        // Construtor
        // Base se referencia no super do java
        public Aluno(string nome,float peso) : base(nome , peso)
        {

        }
        // Implementando 
        private string Rm { get; set; }
        public bool Bolsista { get; set; }

        // Metodos

        public override void FazerProva()
        {
            Console.Write("Aluno respondendo o teste");
        }

        // Sobrescrita metodo com mesmo nome mas com assinatura diferente 
        public virtual void Estudar()
        {
            // Todos os metodos nao podem ser sobrescrito , para deixar sobrescrito 
            // deve -se marcar no metodo como virtual para permitir a sobrescrita
            
        }

    }
}
