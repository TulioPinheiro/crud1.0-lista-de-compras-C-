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
            Console.WriteLine("5 . Sair Do programa");
            Console.WriteLine();
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

                    if (shoppingList.Count == 0)
                    {
                        Console.WriteLine("A lista de compras está vazia.");
                        break;
                    }

                    Console.WriteLine("Itens da lista:");

                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                    }

                    Console.Write("\nDigite o número do item que deseja remover: ");

                    if (int.TryParse(Console.ReadLine(), out int indice) &&
                        indice >= 1 &&
                        indice <= shoppingList.Count)
                    {
                        string itemRemovido = shoppingList[indice - 1];
                        shoppingList.RemoveAt(indice - 1);

                        Console.WriteLine($"Item '{itemRemovido}' removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
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

                case "5":
                    Console.WriteLine("Sair do Programa . Obrigado");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida."); // Mensagem de erro para opção inválida
                    break;
            }
        }
    }
}