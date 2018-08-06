using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{

    // Classe abstrata : Não pode ser instanciada e pode conter metodos abstratos

    abstract class Pessoa
    {
        // propriedade de leitura
        // utilizar undesercor para se obter uma padronização 

        private string _nome;

        // Propriedades (get e sets) O Metodo Deve ser publico

        public float Peso { get; set; }

        // Construtor Cheio

        public Pessoa(string nome, float peso)
        {
            // Construtor da classe filha necessita chamar pelomenos 1 construtor da classe pai

            _nome = nome;
            peso = Peso;
        }

        // GET e SET

        // Usando Enum
        public Genero Genero { get; set; }

        public string Nome
        {
            get { return _nome; }

            set
            {

                if (!string.IsNullOrEmpty(value))
                {
                    _nome = value;
                }

            }
        }

        // metodos

        public virtual void Estudar()
        {
            Console.WriteLine("Pessoa estudando");
        }


        // Classe abstrata pode conter metodos abstratos
        public abstract void FazerProva();

    }
}
