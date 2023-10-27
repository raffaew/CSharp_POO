using System;
using System.Globalization; 

namespace Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario dados = new Funcionario();

            Console.Write("Nome: ");
            dados.Nome = Console.ReadLine();

            Console.Write("Sálario bruto: ");
            dados.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            dados.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário {dados}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine());
            dados.AumetoSalarial(porcent);
            Console.WriteLine($"Dados atualizados:  {dados}");


        }
    }
}
