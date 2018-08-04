using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Pessoa
    {
        // propriedade de leitura
        // utilizar undesercor para se obter uma padronização 

        private string _nome;
      
        // Propriedades (get e sets) O Metodo Deve ser publico

        public float Peso { get; set;}

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
    }
}
