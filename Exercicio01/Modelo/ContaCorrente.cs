using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Modelo
{
    class ContaCorrente : Conta
    {
        public TipoConta TipoConta { get; set; }

        public ContaCorrente (decimal saldo):base(saldo)
        {
            saldo += 1;
        }

        public double Retirar(decimal Saldo)
        {

            var x = Saldo;
            var x = 0.0;

            if (x <= 100 && TipoConta.Equals(TipoConta.Comum))
            {
                throw new Exception("Saldo insuficiente");
            }
            else
            {
                x -= 1;
                Console.Write("Saldo Sacado com Sucesso" + x);
            }

            return x;
        }

    }
}
