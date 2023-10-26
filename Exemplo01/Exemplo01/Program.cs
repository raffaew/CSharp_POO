using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Exemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria um instancia do objeto Triangulo --> X
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            // Recebe um valor para atribuir a propriedade do triângulo --> A
            x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a seguinte(fórmula de Heron):
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            Console.WriteLine(areaX.ToString("F4", CultureInfo.InvariantCulture));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine(areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaY > areaX)
            {
                Console.WriteLine("Maior área: Y");
            }else
            {
                Console.WriteLine("Maior área: X");
            }
        }
    }
    
}
