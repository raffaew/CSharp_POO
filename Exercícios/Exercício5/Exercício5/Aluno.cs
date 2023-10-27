using System;
using System.Globalization;

namespace Exercício5
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double Soma()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double Resto()
        {
            if(Resultado())
            {
                return 0.0; ;
            }else
            {
                return 60.0 - Soma();
            }
        }
        public bool Resultado()
        {
            if (Soma() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
