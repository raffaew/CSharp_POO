using System;
using System.Globalization;

namespace Exemplo02
{
    internal class Triangulo
    {
        // Os atributos do objeto triângulo A B C, que recebem os valores do usuário
        public double A;
        public double B;
        public double C;

        public double Area() {
            //A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é aseguinte(fórmula de Heron)
            double p = (A + B + C) / 2.00;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            // Palavra reservada return retorna o valor da funcão Area() --> (resultado da formúla), para ser acessada fora da classe.
        }
      
    }
}
