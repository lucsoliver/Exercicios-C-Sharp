using System;
using System.Collections.Generic;

class exercicio2B
{
    public static void Main()
    {
        List<string> guestList = new List<string>();

        Console.WriteLine("Bem-vindo ao gerenciador de lista de convidados!");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("O que você gostaria de fazer?");
            Console.WriteLine("1. Adicionar um convidado à lista");
            Console.WriteLine("2. Remover um convidado da lista");
            Console.WriteLine("3. Veja a lista de convidados");
            Console.WriteLine("4. Sair do programa");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Insira o nome do convidado para adicionar: ");
                    string guestToAdd = Console.ReadLine();
                    guestList.Add(guestToAdd);
                    Console.WriteLine("Convidado adicionado com sucesso!");
                    break;

                case 2:
                    Console.Write("Insira o nome do convidado para remover: ");
                    string guestToRemove = Console.ReadLine();
                    if (guestList.Remove(guestToRemove))
                    {
                        Console.WriteLine("Convidado removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Convidado não encontrado na lista.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Lista de convidados:");
                    foreach (string guest in guestList)
                    {
                        Console.WriteLine("- " + guest);
                    }
                    break;

                case 4:
                    Console.WriteLine("Saindo do programa...");
                    return;

                default:
                    Console.WriteLine("Escolha inválida. Por favor, tente novamente.");
                    break;
            }
        }
    }
}
