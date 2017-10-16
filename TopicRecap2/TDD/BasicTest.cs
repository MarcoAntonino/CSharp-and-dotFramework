using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class BasicTest
    {
        [TestMethod]
        public void Sum_Two_Integers_Should_Return_One_Integer()
        {
            int numberOne = 2;
            int numberTwo = 3;

            Operation o = new Operation();
            int returnValue = o.Sum(numberOne, numberTwo);

            Assert.AreEqual(5, returnValue);
        }

        [TestMethod]
        public void Difference_Two_Integers_Should_Return_One_Integer()
        {
            int numberOne = 5;
            int numberTwo = 3;

            Operation o = new Operation();
            int returnValue = o.Dif(numberOne, numberTwo);

            Assert.AreEqual(5, returnValue);
        }

        [TestMethod]
        public void Multiply_Two_Integers_Should_Return_One_Integer()
        {
            int numberOne = 5;
            int numberTwo = 3;

            Operation o = new Operation();
            int returnValue = o.Mult(numberOne, numberTwo);

            Assert.AreEqual(12, returnValue);

        }
    }
}
