using br.com.fiap.ContaCorrente;
using br.com.fiap.ContaPoupanca;
using Fiap.Banco.Model.Conta;
using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // INSTANCIANDO CONTA CORRENTE

            var ContaC = new ContaCorrente()
            {
                Agencia = 10,
                Numero = 1,
                Saldo = 1000,
                tipo = Model.Conta.TipoConta.Comum,
                DataAbertura = DateTime.Now

            };

            var cp = new ContaPoupanca(0.06m)
            {
                Agencia = 1,
                Numero = 3,
                Saldo = 500,
                Taxa = 2,
                DataAbertura = new DateTime(2018, 1, 1)
            };

            try
            {
                ContaC.Retirar(800);
                Console.WriteLine(ContaC.Saldo);

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
