using System;
using System.Globalization;

namespace Exercício01
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }

        public void depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void sacar(double saque)
        {
            Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Nome}, Saldo R$: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }


    }
}
