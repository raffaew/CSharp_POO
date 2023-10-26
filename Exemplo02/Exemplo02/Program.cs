using System;
using System.Globalization;

namespace Exemplo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // x e y: é uma instância do objeto e atribui valores para os atributos (.A .B .C dentro do objeto)!
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // areaX recebe a função Area() com os valores de retornado, delegando as operações. 
            double areaX = x.Area();
            Console.WriteLine(areaX.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com as medidas do triângulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaY = y.Area();
            Console.WriteLine(areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
