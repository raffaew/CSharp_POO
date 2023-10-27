using System;
using System.Globalization; 

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de duas instâncias da classe Funcionario
            Funcionario dados1 = new Funcionario();
            Funcionario dados2 = new Funcionario();

            // Solicita informações sobre o primeiro funcionário
            Console.WriteLine("Dados do primeiro funcionário");

            Console.Write("Nome: ");
            dados1.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            dados1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Solicita informações sobre o segundo funcionário
            Console.WriteLine("Dados do segundo funcionário");

            Console.Write("Nome: ");
            dados2.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            dados2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Cálculo da média salarial
            double media = (dados1.Salario + dados2.Salario) / 2.00;

            // Exibe a média salarial formatada
            Console.WriteLine($"Salário médio = R$: {media.ToString("F2",CultureInfo.InvariantCulture)}");



        }
    }
}
