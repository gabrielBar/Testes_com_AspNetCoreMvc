using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_MVC.Models.Tests
{
    [TestClass()]
    public class TesteModelTests
    {
        [TestMethod()]
        public void Mult_DoisNumPositivo_NumPositivo()
        {
            //arrange
            var p1 = 3;
            var p2 = 4;

            var expected = 12;

            var model = new Teste_MVC.Models.TesteModel();
            var actual = model.Mult(p1, p2);
            Assert.AreEqual(expected, actual);
            //Assert.Fail();
        }
    }
}