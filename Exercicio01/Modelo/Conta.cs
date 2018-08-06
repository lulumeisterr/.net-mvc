using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Modelo
{
    abstract class Conta
    {

        public int Agencia { get; set; }
        public DateTime DataAbertura { get; set; }

        public int Numero { get; set; }

        public decimal Saldo { get; set; }

        public Conta()
        {

        }

        public Conta(int agencia , DateTime data , int numero , decimal saldo)

        {
     
            agencia = Agencia;
            data = DataAbertura;
            numero = Numero;
            saldo = Saldo;

        }


        public Conta(Decimal saldo)

        {
            saldo = Saldo;
   
        }


        public decimal Depositar(decimal valor)
        {
            return valor += valor;
        }

        public decimal Retirar(decimal valor)
        {
            return valor -= valor;
        }

    }

}
