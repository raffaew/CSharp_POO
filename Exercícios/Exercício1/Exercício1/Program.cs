using System;

namespace Exercício1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de duas instâncias da classe Pessoa.
            Pessoa dados1 = new Pessoa();
            Pessoa dados2 = new Pessoa();

            // Solicita informações sobre a primeira pessoa.
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            dados1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            dados1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa:");
            Console.Write("Nome: ");
            dados2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            dados2.Idade = int.Parse(Console.ReadLine());

            // Compara as idades das duas pessoas e exibe a pessoa mais velha.
            if (dados1.Idade > dados2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha {dados1.Nome}");
            }

        }
    }
}
