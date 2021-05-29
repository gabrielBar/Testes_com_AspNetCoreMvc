using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculetorTests
    {
        [TestMethod]
        public void Divide_PositiveNumber_ReturnsPositiveQuociente()
        {
            //Arrange
            var ValorEsperado = 5;
            var Numerador = 20;
            var Denominador = 4;

            //Act
            var ValorAtual = Calcularora.Divide(Numerador, Denominador);

            //Assert
            Assert.AreEqual(ValorEsperado, ValorAtual);
        }
        [TestMethod]
        public void Divide_PositiveNumeratorAndNegativeDenominator_ReturnsNegativeQuociente()
        {
            //Arrange
            var ValorEsperado = -5;
            var Numerador = 20;
            var Denominador = -4;

            //Act
            var ValorAtual = Calcularora.Divide(Numerador, Denominador);

            //Assert
            Assert.AreEqual(ValorEsperado, ValorAtual);
        }

        [TestMethod]
        public void Divide_NegativeNumbers_ReturnsPositiveQuociente()
        {
            //Arrange
            var ValorEsperado = 5;
            var Numerador = -20;
            var Denominador = -4;

            //Act
            var ValorAtual = Calcularora.Divide(Numerador, Denominador);

            //Assert
            Assert.AreEqual(ValorEsperado, ValorAtual);
        }
    }
}
