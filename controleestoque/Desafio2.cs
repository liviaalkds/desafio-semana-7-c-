using System;

class Desafio2
{
    static void Main()
    {
        Console.WriteLine("=== Controle de Estoque ===");

        Console.Write("Nome do produto: ");
        string produto = Console.ReadLine();

        Console.Write("Quantidade atual: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        string status;

        if (quantidade < 5)
        {
            status = "Estoque Crítico";
        }
        else if (quantidade <= 10) // entre 5 e 10
        {
            status = "Estoque Baixo";
        }
        else
        {
            status = "Estoque OK";
        }

        Console.WriteLine();
        Console.WriteLine($"Produto: {produto}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Status: {status}");
    }
}