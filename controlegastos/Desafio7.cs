using System;
using System.Collections.Generic;
using System.Linq;

class Desafio7
{
    static void Main()
    {
        Console.WriteLine("=== Controle de Gastos do Mês ===");

        List<double> gastos = new List<double> { 150, 250, 400, 80 };

        double total = gastos.Sum();
        double media = gastos.Average();

        Console.WriteLine("Gastos registrados:");
        foreach (double gasto in gastos)
        {
            Console.WriteLine($"- R$ {gasto:F2}");
        }

        Console.WriteLine();
        Console.WriteLine($"Total gasto: R$ {total:F2}");
        Console.WriteLine($"Média de gastos: R$ {media:F2}");

        if (media > 200)
        {
            Console.WriteLine("Mensagem: Gastos elevados");
        }
        else
        {
            Console.WriteLine("Mensagem: Gastos controlados");
        }
    }
}