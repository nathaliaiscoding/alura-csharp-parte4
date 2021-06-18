﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank4
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            Console.WriteLine("Execução finalizada, tecle enter para sair.");
            Console.ReadLine();
            // ============ AULA 5 =============
            // try
            // {
            //     ContaCorrente conta1 = new ContaCorrente(4564, 789684);
            //     ContaCorrente conta2 = new ContaCorrente(7891, 456794);

            //     // conta1.Transferir(10000, conta2);
            //     conta1.Sacar(10000);
            // }
            // catch (OperacaoFinanceiraException e)
            // {
            //     Console.WriteLine(e.Message);
            //     Console.WriteLine(e.StackTrace);

            //     Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

            //     Console.WriteLine(e.InnerException.Message);
            //     Console.WriteLine(e.InnerException.StackTrace);
            // }
        }
        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
        }
    }
}
