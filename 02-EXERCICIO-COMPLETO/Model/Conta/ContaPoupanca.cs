using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model.Conta;
using Fiap.Banco.Model.Conta;



namespace br.com.fiap.ContaPoupanca
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        private readonly decimal _rendimento;

        // Propriedades

        public decimal Taxa { get; set; }

        public decimal Rendimento
        {
            get { return _rendimento; }
        }

        // Construtor

        public ContaPoupanca(decimal rendimento)
        {
            /*
             * Construtor: deve receber um valor decimal e atribuir esse valor ao field 
             * */

            _rendimento = rendimento;

        }
 
        public override void Depositar(decimal valor)
        {
            // Depositar: atribui valor ao saldo;
            Saldo += valor;
        }

    

        public override void Retirar(decimal valor)
        {

            /**
             * 
             * r: verifica se o saldo é suficiente, se for deve descontar também
                   a Taxa de retirada, se não, lance uma exceção;
             * */

            if (Saldo < valor)
            {
                Taxa -= valor;
            }
            else
            {
                throw new Exception("Insuficiente");
            }


        }

        public decimal CalculaInvestimento()
        {
           return  Saldo *= _rendimento;
        }
    }
}
