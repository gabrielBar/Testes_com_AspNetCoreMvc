using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
       
       

        [TestMethod]
        [TestCategory("Demo")]
        [TestProperty("Test Group", "Security")]
        [Priority(1)]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }

        [TestMethod]
        [TestCategory("Demo")]
        [TestProperty("Test Group", "Performance")]
        [Priority(1)]
        public void TestMethod2()
        {
            //
            // TODO: Add test logic here
            //
        }
    }
}
