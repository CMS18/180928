using System;
using Bank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankApp.Tests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void DebitTest()
        {
            // Arrange
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);
            double amount = 4;
            double expected = 11.99 - 4;

            // Act
            ba.Debit(amount);

            // Assert
            Assert.AreEqual(expected, ba.Balance);
        }
    }
}
