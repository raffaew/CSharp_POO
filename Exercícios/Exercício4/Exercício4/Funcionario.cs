using System;
using System.Globalization;
namespace Exercício4
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiq()
        {
            return SalarioBruto - Imposto;
        }

        public void AumetoSalarial(double porcent)
        {
            SalarioBruto += Imposto + (porcent / 100.0);
        }

        public override string ToString()
        {
            return $"{Nome}, R$: {SalarioLiq().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
