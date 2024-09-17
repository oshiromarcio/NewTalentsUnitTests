using NewTalents;

namespace TestsNewTalents
{
    public class CalculadoraTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 4, 6)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultCalculo = calc.somar(num1, num2);

            Assert.Equal(resultado, resultCalculo);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(7, 1, 6)]
        [InlineData(20, 11, 9)]
        [InlineData(5, 5, 0)]
        public void TestSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultCalculo = calc.subtrair(num1, num2);

            Assert.Equal(resultado, resultCalculo);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(7, 1, 7)]
        [InlineData(20, 11, 220)]
        public void TestMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultCalculo = calc.multiplicar(num1, num2);

            Assert.Equal(resultado, resultCalculo);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(7, 1, 7)]
        [InlineData(20, 5, 4)]
        public void TestDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultCalculo = calc.dividir(num1, num2);

            Assert.Equal(resultado, resultCalculo);
        }

        [Fact]
        public void TestDividirPorZero()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act

            // Assert
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TestHistorico()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            calc.somar(5, 5);
            calc.subtrair(3, 3);
            calc.multiplicar(4, 2);
            calc.dividir(3, 3);
            calc.dividir(6, 3);
            List<string> lista = calc.historico();

            // Assert
            Assert.NotNull(lista);
            Assert.Equal(3, lista.Count());
            Assert.Contains("6 / 3", lista[2]);
            Assert.Contains("3 / 3", lista[1]);
            Assert.Contains("4 x 2", lista[0]);
        }
    }
}