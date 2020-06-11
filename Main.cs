using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Bem vindo");
    Console.WriteLine("==================");

    do
    {
      Menu();
      try
      {
        int opcao = int.Parse (Console.ReadLine());
        if (opcao == 0) break;
      }
      Execucao(opcao);

      catch (FormatException)
    } while (true);

  private static void Execucao(int opcao)
  {
    Console.Clear();
    switch (opcao)
    {
      case 1:
      {
        // 1 Cadastrar Acao
        CadastrarAcao();

      } break;

      case 2:
      {
        //2 Pesquisar Acao 
        PesquisarAcao();

      } break;

      case 3: 
      {
        //3 Listar Acao
        ListarAcao();

      } break;
      
    }
  }
  public static Menu()
  {
    Console.Clear();
    Console.WriteLine("*** Cadastro Bolsa De Ações ***")

    Console.WriteLine ("1. Cadastrar Acoes");
    Console.WriteLine ("2. Pesquisar uma Ação");
    Console.WriteLine ("3. Lista todas ações");
    Console.WriteLine ("0. Sair");
  }

  }
}