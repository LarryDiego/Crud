using System;

namespace Crud
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      System.Console.WriteLine("CRUD - STEAM GAMES KEYS by Larry Diego\n");
      // Chamar Menu() ou criar o menu direto no Main()

      bool executar = true;

      while (executar)
      {
        Console.WriteLine("----- MENU (CRUD) -----");
        Console.WriteLine("1) Adicionar jogo");
        Console.WriteLine("2) Listar jogos");
        Console.WriteLine("3) Atualizar jogo pelo ID");
        Console.WriteLine("4) Remover jogo pelo ID");
        Console.WriteLine("5) Sair\n");

        Console.Write("Escolha uma opção (1 a 5): ");
        string opcao = Console.ReadLine();
        Console.WriteLine();

        switch (opcao)
        {
          case "1":
            {
              Console.Clear();
              AdicionarJogo();
              break;
            }
          case "2":
            {
              Console.Clear();
              ListarJogos();
              break;
            }
          case "3":
            {
              Console.Clear();
              AtualizarJogo();
              break;
            }
          case "4":
            {
              Console.Clear();
              RemoverJogo();
              break;
            }
          case "5":
            {
              Console.Clear();
              Console.WriteLine("Obrigado por usar nosso sistema de cadastro de jogos Steam!");
              executar = false;
              break;
            }
          default:
            {
              Console.Clear();
              Console.WriteLine("Opção inválida, por favor escolha uma das opções disponíveis\n");
              break;
            }
        }
      }
    }
    static void AdicionarJogo()
    {
      Console.Clear();
      Console.WriteLine("----- ADICIONAR JOGO -----");
      Console.ReadLine();
    }
    static void ListarJogos()
    {
      Console.WriteLine("----- LISTAR JOGOS -----");
    }
    static void AtualizarJogo()
    {
      Console.WriteLine("----- ATUALIZAR JOGO PELO ID -----");
    }
    static void RemoverJogo()
    {
      Console.WriteLine("----- REMOVER JOGO PELO ID -----");
    }
  }
}