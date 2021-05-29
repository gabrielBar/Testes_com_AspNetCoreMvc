using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Test
{
    [TestClass]
    public class CalculetorTest
    {
        [TestMethod]
        public void TestMethod1()
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
    }
}
