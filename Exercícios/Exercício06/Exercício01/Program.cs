using System;
using System.Globalization;

namespace Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria dados;

            Console.Write("Insira o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Insira o nome do títular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havará depósito inicial (s/n)?");
            string dpInicial = Console.ReadLine();

            if (dpInicial == "s" || dpInicial == "S") 
            {
                // Se a verificaçao retornar verdadeira executa os codigos abaixo, inserindo um valor inicial no construtor
                Console.Write("Insira o valor de deposito inicial: ");
                double dp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados = new ContaBancaria(num, titular, dp); // Atribui valores para os argumentos do construtor incluindo a sobrecarga

            }
            else
            {
                // Caso não seja verdadeira, atribui valores apenas ao construtor com dois parâmetros, e inicia o saldo da classe com o valor inicial "0"
                dados = new ContaBancaria(num, titular);
            }

            // Depois das verificações imprime-se os dados inseridos pelo usuário
            Console.WriteLine($"\nDados da conta:\n{dados}\n");

            // Solicida um valor para deposito, e executa o método depositar declarado na classe ContaBancaria
            Console.Write("insira um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.depositar(deposito);
            Console.WriteLine($"Dados da conta atualizados:\n{dados}\n");

            // Solicita um valor para saque, e executa o método sacar declarado na classe ContaBancaria
            Console.Write("Insira um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.sacar(saque);
            Console.WriteLine($"Dados da conta atualizados:\n{dados}\n");

        }
    }
}
