using System;

class Desafio10
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Permissões ===");

        Console.Write("Digite o cargo (Admin, Gerente, Funcionário): ");
        string cargo = Console.ReadLine();

        // Switch  define a permissão
        switch (cargo.Trim().ToLower())
        {
            case "admin":
                Console.WriteLine("Permissão: Acesso total ao sistema (criar, editar, excluir e gerenciar usuários).");
                break;

            case "gerente":
                Console.WriteLine("Permissão: Acesso a relatórios e gerenciamento de equipe, sem exclusão de dados críticos.");
                break;

            case "funcionário":
            case "funcionario": // sem acento, caso haja
                Console.WriteLine("Permissão: Acesso restrito às funções básicas do dia a dia.");
                break;

            default:
                Console.WriteLine("Cargo não reconhecido. Nenhuma permissão atribuída.");
                break;
        }
    }
}