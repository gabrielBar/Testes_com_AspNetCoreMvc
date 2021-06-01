using System;

namespace Calculator
{
    public class Calcularora
    {
        public Calcularora()
        {
        }

        public static int Divide(int numerador, int denominador)
        {
            if (denominador == 0)
                throw new DivideByZeroException("O denominador não pode ser zero.");

            return numerador / denominador;
        }
        
        private bool EhPar(int numero)
        {
            return numero % 2 == 0;
        }

        private static bool EhPositivo(int numero)
        {
            return numero >= 0;
        }
    }
}