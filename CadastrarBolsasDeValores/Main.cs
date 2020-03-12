using System;
using System.Collections.Generic;
using System.Linq;

namespace CadastrarBolsasDeValores
{
    public class Aplicacao

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine("=========");

            do
            {
                Menu();

                try
                {
                    int opcao = int.Parse(Console.ReadLine());
                    if (opcao == 0) break;

                    Execucao(opcao);
                    Console.WriteLine("Entrer para continuar...");
                    Console.ReadLine();
                }

                catch (FormatException)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Opção inválida. Por favor digite uma opção válida!");
                    Console.WriteLine("Enter para continuar...");
                    Console.ReadLine();
                }

            } while (true);
        }

        private static void Execucao(int opcao)
                
        {
             Console.Clear();
             switch (opcao)
             {
                   case 1:
                         {
                        // 1 Cadastrar Acao
                        cadastrarAcao();

                         }
                         break;

                    case 2:
                          {
                          //2 Pesquisar Acao 
                          PesquisarAcao();

                          }
                          break;

                     case 3:
                          {
                         //3 Listar Acao
                         PesquisarAcao();

                          }
                          break;

                    }
                }

        private static void PesquisarAcao(Carteira carteira)
        {
            Console.WriteLine("Pesquisar por Ação");
            Console.Write("Digite o codigo do Ação: ");
            string cod = Console.ReadLine();

            Acao acao = BolsasDeValores.acoes.Where(p => p.Codigo.Contains(codigo, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            Console.WriteLine("----------------------------------");

            if (acao != null)
            {
                Console.WriteLine(acao);
                foreach (var acao in carteira.acoesRegistradas())
                {
                    Console.WriteLine(acao);
                }
            }
            else
                Console.WriteLine("Ação não encontrada! ");


        }
        private static void cadastrarAcao()
        {
            Console.WriteLine("Cadastrar Ação");
            Console.Write("Digite Codigo: ");
            string codigo = Console.ReadLine();

            Console.Write("Digite a quantidade: ");
            int quantidade = Console.Read();
            

            BolsasDeValores.acoes.Add(new Acao(codigo, quantidade));
        }
                
        public static void Menu()
        {
             Console.Clear();
             Console.WriteLine("*** Cadastro Bolsa De Ações ***");


             Console.WriteLine("1. Cadastrar Acoes");
             Console.WriteLine("2. Pesquisar uma Ação");
             Console.WriteLine("3. Lista carteira de ações");
             Console.WriteLine("0. Sair");

             Console.Write("Digite uma opção: ");
        }
    }
}
