using System;
using System.Globalization;

namespace Exercício5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma instância da classe Aluno
            Aluno dados = new Aluno();

            // Solicita ao usuário o nome do aluno e armazena-o no atributo "Nome" da instância "dados"
            Console.Write("Nome do Aluno: ");
            dados.Nome = Console.ReadLine();

            // Solicita ao usuário as três notas do aluno, lê as entradas e armazena-as nos atributos "Nota1", "Nota2" e "Nota3" da instância "dados"
            Console.WriteLine("Digite as três notas do aluno:");
            dados.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            dados.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Verifica se o aluno foi aprovado ou reprovado com base no resultado da função "Resultado()"
            if (dados.Resultado())
            {
                Console.WriteLine($"NOTA FINAL = {dados.Soma().ToString("F2",CultureInfo.InvariantCulture)}\nAPROVADO");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {dados.Soma().ToString("F2", CultureInfo.InvariantCulture)}\nREPROVADO\nFALTAM {dados.Resto().ToString("F2",CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
