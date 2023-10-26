using System;
using System.Globalization;

namespace Exemplo03_toString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto dados = new Produto();

            Console.WriteLine("Insira os dados do produto! Nome; Preço; Quantidade:");
            dados.Nome = Console.ReadLine();
            dados.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.Quantidade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"Dados do produto {dados}");

            Console.WriteLine("Digite o número de produtos para ser adcionado no estoque: ");
            int add = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.Adcionar(add);
            Console.WriteLine($"Dados atualizados: {dados}");

            Console.WriteLine("Digite um número de produtos a ser removido do estoque: ");
            int del = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.Deletar(del);
            Console.WriteLine($"Dados atualizados: {dados}");
        }
    }
}
