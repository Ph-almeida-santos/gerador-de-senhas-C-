using System;

namespace GeradorDeSenhas
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao gerador de senha segura\n");

            Console.Write("Informe quantos caracteres terá a senha (mínimo 4): ");
            int tamanho = int.Parse(Console.ReadLine());

            GeradorSenha gerador = new GeradorSenha();

            try
            {
                string senha = gerador.GerarSenha(tamanho);
                Console.WriteLine($"\nSenha gerada: {senha}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}

