using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model.Conta
{
    abstract class Conta
    {

        public int Agencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Numero { get; set;}
        public decimal Saldo { get; set; }


        public Conta()
        {

        }

        public Conta(int agencia , DateTime data , int numero , decimal saldo)
        {
            agencia = this.Agencia;
            data = this.DataAbertura;
            numero = this.Numero;
            saldo = this.Saldo;
        }

        // Uma Classe abstrata pode conter metodos

        public abstract void Depositar(decimal valor);
        public abstract void Retirar(decimal valor);



    }
}
