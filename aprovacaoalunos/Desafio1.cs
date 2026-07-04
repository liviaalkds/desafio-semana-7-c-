using System;

class Desafio1
{
    //  calcular a média das duas notas
    static double CalcularMedia(double nota1, double nota2)
    {
        return (nota1 + nota2) / 2;
    }

    // retornar a situação do aluno com base na média
    static string ObterSituacao(double media)
    {
        if (media >= 7)
            return "Aprovado";
        else if (media >= 5)
            return "Recuperação";
        else
            return "Reprovado";
    }

    static void Main()
    {
        Console.WriteLine("=== Sistema de Aprovação de Alunos ===");

        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Nota 1: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nota 2: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        double media = CalcularMedia(nota1, nota2);
        string situacao = ObterSituacao(media);

        Console.WriteLine();
        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine($"Situação: {situacao}");
    }
}