using System;
using Crud.Models;

namespace Crud
{
  class Program
  {
    static List<Jogo> jogos = new List<Jogo>();
    static void Main(string[] args)
    {
      Console.Clear();
      System.Console.WriteLine("CRUD - STEAM GAMES KEYS by Larry Diego\n");

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
      Console.WriteLine("----- ADICIONAR JOGO -----\n");

      string nome = ValidarString("Nome do jogo: ");
      decimal preco = ValidarDecimal("Preço do jogo: R$ ");

      Jogo novoJogo = new Jogo(nome, preco);
      jogos.Add(novoJogo);

      Console.WriteLine($"Jogo adicionado com sucesso! ID: {novoJogo.Id}");
      Console.WriteLine("Pressione Enter para voltar.");
      Console.ReadLine();
    }
    static void ListarJogos()
    {
      Console.WriteLine("----- LISTAR JOGOS -----\n");
    }
    static void AtualizarJogo()
    {
      Console.WriteLine("----- ATUALIZAR JOGO PELO ID -----\n");
    }
    static void RemoverJogo()
    {
      Console.WriteLine("----- REMOVER JOGO PELO ID -----\n");
    }

    static string ValidarString(string mensagem)
    {
      string valor;

      do
      {
        Console.Write(mensagem);
        valor = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(valor))
        {
          Console.WriteLine("O campo não pode ser vazio.");
        }
      } while (string.IsNullOrWhiteSpace(valor));

      return valor;
    }

    static int ValidarInt(string mensagem)
    {
      {
        int valor;

        while (true)
        {
          Console.Write(mensagem);
          if (int.TryParse(Console.ReadLine(), out valor))
          {
            return valor;
          }

          Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }
      }
    }

    static decimal ValidarDecimal(string mensagem)
    {
      decimal valor;

      while (true)
      {
        Console.Write(mensagem);
        if (decimal.TryParse(Console.ReadLine(), out valor))
        {
          return valor;
        }

        Console.WriteLine("Entrada inválida. Digite um número decimal.");
      }
    }
  }
}