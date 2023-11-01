using System;
using System.Globalization;

namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de uma instância da classe Retangulo
            Retangulo valores = new Retangulo();

            // Solicita ao usuário a largura e altura do retângulo e armazena nas propriedades da instância valores
            Console.WriteLine("Insira a largura e altura do retângulo");
            valores.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            valores.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            // Calcula e exibe a ÁREA, PERÍTREMO E DIAGONAL do retângulo formatada com duas casas decimais
            Console.WriteLine($"AREA = {valores.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {valores.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {valores.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
