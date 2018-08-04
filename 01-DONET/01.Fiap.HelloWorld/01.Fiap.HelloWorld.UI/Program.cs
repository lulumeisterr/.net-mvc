using _01.Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Using São os Pacotes
// Program.cs - São nossos arquivos de executação
// Todos nomes de metodos começam com a letra M
// Solution - é a workspace
// Assembly - é um EXE pois quando vc compila ele gera um artefato final , Ou seja cada projeto ele gerará uma dll
// NameSpace - São os Pacotes : ex: br.com.fiap


// Herdar os dados de pai para filho
// encapsulamento : Protege os devidos conteudos
// polimorfismo : Sobrescrita de metodos , Sobrescrita com a mesma assinatura com nomes diferentes e 


// Primeiro Compila Depois Gera o Assembly E depois o exe

namespace _01.Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando o Aluno

            Aluno a = new Aluno();
            a.Nome = "Lucas";

            // Imprimindo
            Console.WriteLine(a.Nome);

        }
    }
}
