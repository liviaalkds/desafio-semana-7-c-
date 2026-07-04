using System;
using System.Collections.Generic;

class Desafio4
{
    static void Main()
    {
        Console.WriteLine("=== Histórico de Navegação ===");

        // segue o conceito LIFO
        Stack<string> historico = new Stack<string>();

        historico.Push("Home");
        historico.Push("Produtos");
        historico.Push("Carrinho");

        Console.WriteLine("Página atual: " + historico.Peek());
        Console.WriteLine();

        // Simulando o usuário clicando voltar
        Console.WriteLine("Usuário clicou em Voltar...");
        string paginaAnterior = historico.Pop();
        Console.WriteLine($"Saiu de: {paginaAnterior} | Página atual: {historico.Peek()}");

        Console.WriteLine("Usuário clicou em Voltar novamente...");
        paginaAnterior = historico.Pop();
        Console.WriteLine($"Saiu de: {paginaAnterior} | Página atual: {historico.Peek()}");

        Console.WriteLine();
        Console.WriteLine("Histórico restante na pilha:");
        foreach (string pagina in historico)
        {
            Console.WriteLine($"- {pagina}");
        }
    }
}