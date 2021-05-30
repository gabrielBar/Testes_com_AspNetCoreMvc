using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculetorTests
    {
        private static TestContext _textContext;
        public TestContext TextContext { 
            get { return _textContext    ; } 
            set { _textContext = value; } 
        }

        [ClassInitialize]
        public static void ClassInit(TestContext contexto)
        {
            _textContext = contexto;
        }

        [TestMethod]
        [TestCategory("Demo"), TestCategory("Calculator")]
        [TestProperty("Test Group", "Functional")]
        [Owner("Gabriel")]
        [Priority(0)]
        public void Divide_PositiveNumbers_ReturnsPositiveQuociente()
        {
            


            var ValorEsperado = 5;
            var Numerador = 20;
            var Denominador = 4;
            var ValorAtual = Calcularora.Divide(Numerador, Denominador);
            
          
            Assert.AreEqual(ValorEsperado, ValorAtual);
        }
        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Functional")]
        [Owner("Gabriel")]
        [Priority(0)]

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
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Functional")]
        [Owner("Adriano")]
        [Priority(0)]
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

        [TestMethod]
        public void Teste_Output()
        {
            System.Diagnostics.Debug.WriteLine($"Debug: Teste_Output executado");
            TextContext.WriteLine($"TestContext: Teste_Output executado");
            Assert.IsTrue(true);
        }
    }
}
