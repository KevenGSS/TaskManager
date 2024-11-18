using System;
using System.Collections.Generic;

class Program
{
  // Lista para armazenar as tarefas
  static List<string> tarefas = new List<string>();
  static List<bool> concluido = new List<bool>();

  static void Main(string[] args)
  {
    while (true)
    {
      ExibirMenu();
      string opcao = Console.ReadLine();

      switch (opcao)
      {
        case "1":
          AdicionarTarefa();
          break;
        case "2":
          ListarTarefas();
          break;
        case "3":
          MarcarComoConcluida();
          break;
        case "0":
          Console.WriteLine("Saindo... Até logo!");
          return;
        default:
          Console.WriteLine("Opção inválida. Tente novamente.");
          break;
      }
    }
  }

  static void ExibirMenu()
  {
    Console.WriteLine("\nGerenciador de Tarefas");
    Console.WriteLine("1. Adicionar Tarefa");
    Console.WriteLine("2. Listar Tarefas");
    Console.WriteLine("3. Marcar Tarefa como Concluída");
    Console.WriteLine("0. Sair");
    Console.Write("Escolha uma opção: ");
  }

  static void AdicionarTarefa()
  {
    Console.Write("Digite a descrição da tarefa: ");
    string descricao = Console.ReadLine();
    tarefas.Add(descricao);
    concluido.Add(false);
    Console.WriteLine("Tarefa adicionada com sucesso!");
  }

  static void ListarTarefas()
  {
    if (tarefas.Count == 0)
    {
      Console.WriteLine("Nenhuma tarefa encontrada.");
    }
    else
    {
      Console.WriteLine("\nTarefas:");
      for (int i = 0; i < tarefas.Count; i++)
      {
        string status = concluido[i] ? "[Concluída]" : "[Pendente]";
        Console.WriteLine($"{i + 1}. {tarefas[i]} {status}");
      }
    }
  }

  static void MarcarComoConcluida()
  {
    ListarTarefas();
    Console.Write("Digite o número da tarefa para marcar como concluída: ");
    if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0 && numero <= tarefas.Count)
    {
      concluido[numero - 1] = true;
      Console.WriteLine("Tarefa marcada como concluída!");
    }
    else
    {
      Console.WriteLine("Número inválido. Tente novamente.");
    }
  }
}
