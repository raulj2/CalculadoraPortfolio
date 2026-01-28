using System;

namespace CalculadoraPortfolio
{
    public class Calculadora
    {
        public double Somar(double a, double b) => a + b;
        public double Subtrair(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;
        public double Dividir(double a, double b) => a / b;
        public double Modulo(double a, double b) => a % b;

        public double Potencia(double a, double b) => Math.Pow(a, b);
        public double RaizQuadrada(double a) => Math.Sqrt(a);
        public double LogNatural(double a) => Math.Log(a);
        public double LogBase10(double a) => Math.Log10(a);
        public double Exponencial(double a) => Math.Exp(a);

        public double Seno(double a) => Math.Sin(a);
        public double Cosseno(double a) => Math.Cos(a);
        public double Tangente(double a) => Math.Tan(a);

        public double ValorAbsoluto(double a) => Math.Abs(a);
        public double Arredondar(double a) => Math.Round(a);
        public double Piso(double a) => Math.Floor(a);
        public double Teto(double a) => Math.Ceiling(a);

        public double Maximo(double a, double b) => Math.Max(a, b);
        public double Minimo(double a, double b) => Math.Min(a, b);
    }
}