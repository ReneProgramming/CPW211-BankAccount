﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Deposit_APositiveAmount_AddToBalance()
        {
            Account acc = new Account("J Doe");
            acc.Deposit(100);

            Assert.AreEqual(100, acc.Balance);
        }

        [TestMethod]
        public void Deposit_APositiveAmount_ReturnsUpdatedBalance()
        {
            // AAA - Arrange Act Assert
            // Arrange
            double depositAmount = 100;
            double expectedReturn = 100;

            // Act
            double returnValue = acc.Deposit(depositAmount);

            // Assert 
            Assert.AreEqual(expectedReturn, returnValue);
        }
    }
}