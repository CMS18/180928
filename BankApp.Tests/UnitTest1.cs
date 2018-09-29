using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public int Adder(int a, int b, int c = 0)
        {
            return a + b + c;
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 15;

            // Act
            int result = Adder(a, b);

            // Assert
            Assert.AreEqual(expected, result);  // Expected == Actual?
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int a = 3;
            int b = 4;
            int expected = 7;

            // Act
            int result = Adder(a, b);

            // Assert
            Assert.AreEqual(expected, result);  // Expected == Actual?
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int a = 3;
            int b = 4;
            int c = 5;
            int expected = 12;

            // Act
            int result = Adder(a, b, c);

            // Assert
            Assert.AreEqual(expected, result);  // Expected == Actual?
        }
    }
}
