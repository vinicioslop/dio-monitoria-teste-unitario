using Shouldly;
using System;
using Xunit;

namespace Calculator.Testes
{
    public class CalculatorTests
    {
        // AAA
        // Arrange - Configurações
        // Act     - Execução
        // Assert  - Verificação
        
        [Fact]
        public void Add_ShouldReturnTheCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(1, 2);

            // Assert
            result.ShouldBe(3);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(5, 2, 3)]
        public void Subtract_ShouldReturnTheCorrectSubtraction(int number1, int number2, int expectedResult)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Subtract(number1, number2);

            // Assert
            result.ShouldBe(expectedResult);
        }

        [Fact]
        public void Divide_ShouldThrowExceptionWhenDividingByZero()
        {
            // Arrange
            var calculator = new Calculator();

            // Act & Assert
            Should.Throw<Exception>(() => calculator.Divide(4, 0));
        }
    }
}
