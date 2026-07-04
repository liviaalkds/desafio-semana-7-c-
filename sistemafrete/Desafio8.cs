using System;

class Desafio8
{
    // Função responsável por calcular o valor do frete com base no valor da compra
    static double CalcularFrete(double valorCompra)
    {
        if (valorCompra > 300)
        {
            return 0; // Frete grátis
        }
        else if (valorCompra >= 200) 
        {
            return 15;
        }
        else
        {
            return 30;
        }
    }

    static void Main()
    {
        Console.WriteLine("=== Sistema de Frete ===");

        Console.Write("Valor da compra: R$ ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        double frete = CalcularFrete(valorCompra);
        double valorFinal = valorCompra + frete;

        Console.WriteLine();
        if (frete == 0)
        {
            Console.WriteLine("Frete: Grátis");
        }
        else
        {
            Console.WriteLine($"Frete: R$ {frete:F2}");
        }

        Console.WriteLine($"Valor final do pedido: R$ {valorFinal:F2}");
    }
}