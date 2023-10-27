using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    internal class Retangulo
    {
        public double Largura; // A propriedade pública Largura, armazena a largura do retângulo.
        public double Altura; // A propriedade pública Altura, armazena a largura do retângulo.


        // O método público Area(), Perimetro() e Diagonal calcula os valores usando as formulas necessárias para retornar os resultados
        public double Area() 
        {
            return Largura * Altura;
        }

        public double Perimetro ()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal ()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}

