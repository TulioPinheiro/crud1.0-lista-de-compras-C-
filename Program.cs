namespace crud;

using System.IO;

public class Program
{
    public static void Main()
    { 
        List<string> shoppingList = new List<string>(); // Cria uma lista de compras com itens pré-definidos

        while (true)
        {
            Console.WriteLine("\n== Lista de Compras ==");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Exibir lista");
            Console.WriteLine("4. Limpar lista");
            
            Console.Write("Escolha uma opção: ");
            Console.WriteLine("Escolhe um numero pra continuar: ");

            string choiceUser = Console.ReadLine();

            switch (choiceUser)
            {

                case "1":
                    Console.WriteLine("Digite o item que deseja adicionar: "); // Solicita ao usuário que digite o item a ser adicionado
                    string itemInsert = Console.ReadLine(); // Lê o item digitado pelo usuário

                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoppingList.Add(itemInsert); // Adiciona o item à lista de compras
                        Console.WriteLine($"Item '{itemInsert}' adicionado à lista de compras!"); // Confirmação de que o item foi adicionado  
                    }
                    else
                    {
                        Console.WriteLine("Item inválido. Por favor, digite um item válido."); // Mensagem de erro para item inválido
                    }
                    break;

                case "2":
                    Console.WriteLine("Digite o item que deseja remover: "); // Solicita ao usuário que digite o item a ser removido
                    string itemRemove = Console.ReadLine(); // Lê o item digitado pelo usuário
                    if (shoppingList.Remove(itemRemove)) // Tenta remover o item da lista de compras
                    {
                        Console.WriteLine($"Item '{itemRemove}' removido da lista de compras!"); // Confirmação de que o item foi removido
                    }
                    else
                    {
                        Console.WriteLine($"Item '{itemRemove}' não encontrado na lista de compras."); // Mensagem de erro para item não encontrado
                    }
                    break;

                case "3":
                    Console.WriteLine("Lista de Compras:"); // Exibe a lista de compras

                    if (shoppingList.Count == 0) // Verifica se a lista de compras está vazia
                    {
                        Console.WriteLine("A lista de compras está vazia."); // Mensagem para lista vazia
                    }
                    else
                    {
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            Console.WriteLine($"- {i + 1}. {shoppingList[i]}"); // Exibe o item formatado
                        }
                    }
                    break;

                case "4":
                    shoppingList.Clear(); // Limpa a lista de compras
                    Console.WriteLine("Lista de compras limpa!"); // Confirmação de que a lista foi limpa
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida."); // Mensagem de erro para opção inválida
                    break;
            }
        }
    }
}