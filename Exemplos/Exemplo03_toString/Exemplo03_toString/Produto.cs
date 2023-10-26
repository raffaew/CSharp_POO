using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Exemplo03_toString
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double valorEstoque()
        {
            return Preco * Quantidade;
        }

        public void Adcionar (int add)
        {
            Quantidade += add;
        }

        public void Deletar (int del)
        {
            Quantidade -= del;
        }

        public override string ToString()
        {
            return $"{Nome}, R$: {Preco.ToString("F2",CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total R$: {valorEstoque().ToString("F2",CultureInfo.InvariantCulture)} ";
        } 

    }
}
