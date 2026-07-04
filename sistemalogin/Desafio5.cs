using System;

class Desafio5
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Login ===");

        const string usuarioCorreto = "admin";
        const string senhaCorreta = "123456";

        Console.Write("Usuário: ");
        string usuario = Console.ReadLine();

        Console.Write("Senha: ");
        string senha = Console.ReadLine();

        //  and q só libera acesso se ambos forem verdadeiros
        if (usuario == usuarioCorreto && senha == senhaCorreta)
        {
            Console.WriteLine("Acesso permitido! Bem-vindo, admin.");
        }
        else
        {
            Console.WriteLine("Acesso negado. Usuário ou senha incorretos.");
        }
    }
}