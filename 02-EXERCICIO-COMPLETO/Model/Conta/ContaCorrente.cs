
using ConsoleApp1.Model.Conta; // Tipo Conta
using Fiap.Banco.Model.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace br.com.fiap.ContaCorrente
{
    // sealed = Trava a classe e diz que não pode ser abstrata

    sealed class ContaCorrente : Conta
    {
        // Propriedades

        public TipoConta tipo { get; set; }

        // Depositar: adiciona valor ao saldo;

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            /**
             *: Se a conta for comum e o saldo fica negativo depois do saque
                deve lançar uma exceção e não permitir a retirada. 
             * */

            if(tipo == TipoConta.Comum && Saldo < valor)
                {
                throw new Exception("Saldo insuficiente");
                }

            Saldo -= valor;

        }
    }
}
