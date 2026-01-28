using Xunit;
using CalculadoraPortfolio;

namespace CalculadoraPortfolioTest
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calc = new Calculadora();

        [Fact]
        public void TesteSomar()
        {
            Assert.Equal(5, _calc.Somar(2, 3));
        }

        [Fact]
        public void TesteSubtrair()
        {
            Assert.Equal(1, _calc.Subtrair(3, 2));
        }

        [Fact]
        public void TesteMultiplicar()
        {
            Assert.Equal(6, _calc.Multiplicar(2, 3));
        }

        [Fact]
        public void TesteDividir()
        {
            Assert.Equal(2, _calc.Dividir(6, 3));
        }

        [Fact]
        public void TesteModulo()
        {
            Assert.Equal(1, _calc.Modulo(7, 3));
        }

        [Fact]
        public void TestePotencia()
        {
            Assert.Equal(8, _calc.Potencia(2, 3));
        }

        [Fact]
        public void TesteRaizQuadrada()
        {
            Assert.Equal(3, _calc.RaizQuadrada(9));
        }

        [Fact]
        public void TesteLogNatural()
        {
            Assert.Equal(1, Math.Round(_calc.LogNatural(Math.E)));
        }

        [Fact]
        public void TesteLogBase10()
        {
            Assert.Equal(2, _calc.LogBase10(100));
        }

        [Fact]
        public void TesteExponencial()
        {
            Assert.Equal(Math.E, _calc.Exponencial(1));
        }

        [Fact]
        public void TesteSeno()
        {
            Assert.Equal(0, _calc.Seno(0));
        }

        [Fact]
        public void TesteCosseno()
        {
            Assert.Equal(1, _calc.Cosseno(0));
        }

        [Fact]
        public void TesteTangente()
        {
            Assert.Equal(0, _calc.Tangente(0));
        }

        [Fact]
        public void TesteValorAbsoluto()
        {
            Assert.Equal(5, _calc.ValorAbsoluto(-5));
        }

        [Fact]
        public void TesteArredondar()
        {
            Assert.Equal(3, _calc.Arredondar(2.7));
        }

        [Fact]
        public void TestePiso()
        {
            Assert.Equal(2, _calc.Piso(2.7));
        }

        [Fact]
        public void TesteTeto()
        {
            Assert.Equal(3, _calc.Teto(2.1));
        }

        [Fact]
        public void TesteMaximo()
        {
            Assert.Equal(10, _calc.Maximo(10, 5));
        }

        [Fact]
        public void TesteMinimo()
        {
            Assert.Equal(5, _calc.Minimo(10, 5));
        }
    }
}