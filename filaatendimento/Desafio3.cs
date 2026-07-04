using System;
using System.Collections.Generic;

class Desafio3
{
    static void Main()
    {
        Console.WriteLine("=== Fila de Atendimento (Clínica) ===");

        //  conceito FIFO
        Queue<string> fila = new Queue<string>();

        fila.Enqueue("Maria");
        fila.Enqueue("João");
        fila.Enqueue("Pedro");

        //primeiro a entrar é o primeiro a ser atendido
        string atendido = fila.Dequeue();

        Console.WriteLine($"Paciente atendido: {atendido}");
        Console.WriteLine();
        Console.WriteLine("Pacientes aguardando:");

        if (fila.Count == 0)
        {
            Console.WriteLine("Nenhum paciente na fila.");
        }
        else
        {
            foreach (string paciente in fila)
            {
                Console.WriteLine($"- {paciente}");
            }
        }
    }
}