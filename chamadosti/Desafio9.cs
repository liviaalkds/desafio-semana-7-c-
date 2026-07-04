using System;
using System.Collections.Generic;

class Desafio9
{
    static void Main()
    {
        Console.WriteLine("=== Controle de Chamados de TI ===");

    //fila da ordem dos produtos
        Queue<string> chamados = new Queue<string>();

        chamados.Enqueue("Impressora não funciona");
        chamados.Enqueue("Computador lento");
        chamados.Enqueue("Problema no e-mail");

        Console.WriteLine("Chamados na fila:");
        foreach (string chamado in chamados)
        {
            Console.WriteLine($"- {chamado}");
        }

       //atende o mais antigo primeiro da fila
        string chamadoAtendido = chamados.Dequeue();

        Console.WriteLine();
        Console.WriteLine($"Chamado atendido: {chamadoAtendido}");
        Console.WriteLine();
        Console.WriteLine("Chamados restantes:");

        if (chamados.Count == 0)
        {
            Console.WriteLine("Nenhum chamado pendente.");
        }
        else
        {
            foreach (string chamado in chamados)
            {
                Console.WriteLine($"- {chamado}");
            }
        }
    }
}