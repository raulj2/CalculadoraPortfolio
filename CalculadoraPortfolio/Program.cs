using System;

namespace CalculadoraPortfolio
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculadora();

            Console.WriteLine("=== Calculadora Portfolio ===");
            Console.WriteLine("Exemplo de operações:");

            Console.WriteLine($"2 + 3 = {calc.Somar(2, 3)}");
            Console.WriteLine($"6 - 2 = {calc.Subtrair(6, 2)}");
            Console.WriteLine($"4 * 5 = {calc.Multiplicar(4, 5)}");
            Console.WriteLine($"10 / 2 = {calc.Dividir(10, 2)}");
            Console.WriteLine($"7 % 3 = {calc.Modulo(7, 3)}");
            Console.WriteLine($"2 ^ 3 = {calc.Potencia(2, 3)}");
            Console.WriteLine($"Raiz quadrada de 9 = {calc.RaizQuadrada(9)}");
            Console.WriteLine($"Log base 10 de 100 = {calc.LogBase10(100)}");
            Console.WriteLine($"Seno de 0 = {calc.Seno(0)}");
            Console.WriteLine($"Cosseno de 0 = {calc.Cosseno(0)}");
            Console.WriteLine($"Tangente de 0 = {calc.Tangente(0)}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}