using System;
using System.Collections.Generic;

class Desafio6
{
    static void Main()
    {
        Console.WriteLine("=== Cadastro de Produtos ===");

        //  armazena pares chave (nome do produto) e valor
        Dictionary<string, double> produtos = new Dictionary<string, double>
        {
            { "Mouse", 80 },
            { "Teclado", 120 },
            { "Monitor", 900 }
        };

        Console.Write("Digite o nome do produto que deseja consultar: ");
        string nomeProduto = Console.ReadLine();

        // tryget evita exceção caso o produto não exista no dicionário
        if (produtos.TryGetValue(nomeProduto, out double preco))
        {
            Console.WriteLine($"Preço de {nomeProduto}: R$ {preco:F2}");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
}