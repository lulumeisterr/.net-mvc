﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Professor : Pessoa , ITrabalhador
    {

        // Criando atributos e get Setter
        // prop e utilizar o TABx2
        public string Pf { get; set; }
        public IList<string> Disciplinas { get; set; }
        

        public Professor(string nome , float peso):base(nome , peso)
        {

        }

        public override void FazerProva()
        {
            Console.Write("Fazendo a prova");
        }

        public void ReceberSalario()
        {
            Console.Write('Salariooo');
        }
    }
}
