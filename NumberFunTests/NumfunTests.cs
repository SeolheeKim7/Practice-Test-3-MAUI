using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberFun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFun.Tests
{
    [TestClass()]
    public class NumfunTests
    {
        /// <summary>
        /// UseCase1 values: 5, 10 expected 10
        /// </summary>
        [TestMethod()]
        public void BiggestTestCase1()
        {
            //Arrange
            int a = 5;
            int b = 10;
            int expected = 10;

            //Act
            int actual = Numfun.Biggest(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UseCase2 values: 10, 5 expected 10
        /// </summary>
        [TestMethod()]
        public void BiggestTestCase2()
        {
            //Arrange
            int a = 10;
            int b = 5;
            int expected = 10;

            //Act
            int actual = Numfun.Biggest(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UseCase3 values: 10, 10 expected 10
        /// </summary>
        [TestMethod()]
        public void BiggestTestCase3()
        {
            //Arrange
            int a = 10;
            int b = 10;
            int expected = 10;

            //Act
            int actual = Numfun.Biggest(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UseCase5 Test for DivideByZeroException
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTestCase5()
        {
            //Arrange
            double Numerator = 1;
            double Denominator = 0;

            //Act
            try
            {
                var actual = Numfun.Division(Numerator, Denominator);
            }
            catch (DivideByZeroException)
            {
                throw;
            }

            //Assert
            Assert.Fail();
        }
    }
}